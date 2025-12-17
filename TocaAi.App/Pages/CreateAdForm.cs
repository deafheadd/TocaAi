using FluentValidation;
using ReaLTaiizor.Forms;
using TocaAi.App.Session;
using TocaAi.App.ViewModels;
using TocaAi.Domain.Entities;
using TocaAi.Domain.Validators;
using TocaAi.Service.DTOs;
using TocaAi.Service.Interfaces;

namespace TocaAi.App.Pages
{
    public partial class CreateAdForm : LostForm
    {
        // serviço
        private readonly IEquipmentService _equipmentService;
        // edição
        private readonly Guid? _editId; // se for null é novo cadastro

        // tentando resolver disponiblidade
        private bool _isAvailableOriginal;
        public CreateAdForm(IEquipmentService equipmentService)
        {
            InitializeComponent();

            _equipmentService = equipmentService;

            LoadEnums();

            chkIsAvailable.Checked = true;
        }

        // construtor para edição
        public CreateAdForm(IEquipmentService equipmentService, Equipment model) : this(equipmentService)
        {
            chkIsAvailable.Checked = model.IsAvailable;
            if (!model.IsAvailable)
            {
                chkIsAvailable.Enable = true;
            }

            _editId = model.Id;
            //_isAvailableOriginal = model.IsAvailable;
            //chkIsAvailable.Checked = model.IsAvailable;
            this.Text = "Editar Anúncio";
            btnPostAd.Text = "Salvar Alterações";

            // preencher campos
            txtName.Text = model.Name;
            txtBrand.Text = model.Brand;
            txtModel.Text = model.Model;
            txtSerialNumber.Text = model.SerialNumber;
            txtDescription.Text = model.Description;
            numericUpDownDailyRate.Value = model.DailyRate;
            dtpAcquisition.Value = model.AcquisitionDate;
            cboType.SelectedItem = model.Type;
            cboConservation.SelectedItem = model.ConservationStatus;
            txtNotes.Text = model.Notes;
        }

        private void LoadEnums()
        {
            cboType.DataSource = Enum.GetValues(typeof(EquipmentType));
            cboConservation.DataSource = Enum.GetValues(typeof(ConservationStatus));
        }

        private void btnPostAd_Click(object sender, EventArgs e)
        {
            // conversão de dados
            if (!decimal.TryParse(numericUpDownDailyRate.Text, out decimal dailyRate))
            {
                MessageBox.Show("A taxa diária deve ser um valor numérico válido.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (dtpAcquisition.Value == null)
            {
                MessageBox.Show("A data de aquisição é obrigatória.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var acquisitionDate = dtpAcquisition.Value;

            // criação do input model
            var inputModel = new EquipmentInputModel(
                txtName.Text.Trim(),
                (EquipmentType)cboType.SelectedItem,
                txtBrand.Text.Trim(),
                txtModel.Text.Trim(),
                txtSerialNumber.Text.Trim(),
                txtDescription.Text.Trim(),
                dailyRate,
                acquisitionDate,
                (ConservationStatus)cboConservation.SelectedItem,
                txtNotes.Text.Trim(),
                chkIsAvailable.Checked
            );

            // confirmação
            DialogResult confirmResult = MessageBox.Show(
                $"Deseja confirmar a publicação do anúncio '{inputModel.Name}'?",
                "Confirmar Anúncio",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmResult == DialogResult.Yes)
            {
                try
                {
                    if (_editId.HasValue)
                    {
                        // modo de edição
                        var eq = new Equipment(
                            _editId.Value,
                            UserSession.CurrentUser.Id,
                            inputModel.Name,
                            inputModel.Type,
                            inputModel.Brand,
                            inputModel.Model,
                            inputModel.SerialNumber,
                            inputModel.Description,
                            inputModel.DailyRate,
                            inputModel.AcquisitionDate,
                            inputModel.ConservationStatus,
                            inputModel.Notes,
                            inputModel.IsAvailable
                        //_isAvailableOriginal
                        );

                        _equipmentService.UpdateEquipment(_editId.Value, eq);
                        MessageBox.Show("Anúncio atualizado com sucesso.");
                    }
                    else
                    {
                        // modo de criação
                        // usa o método específico, passando o DTO e o OwnerId
                        _equipmentService.Announce(inputModel, UserSession.CurrentUser.Id);

                        MessageBox.Show(
                            "Equipamento anunciado com sucesso. Está disponível para aluguel.",
                            "Anúncio Concluído",
                            MessageBoxButtons.OK,
                            MessageBoxIcon.Information
                        );
                    }

                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (ValidationException ex)
                {
                    MessageBox.Show(ex.Errors.First().ErrorMessage, "Erro de validação", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao salvar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
