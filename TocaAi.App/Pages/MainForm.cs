using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;
using TocaAi.App.Session;
using TocaAi.Service.Interfaces;

namespace TocaAi.App.Pages
{
    public partial class MainForm : LostForm
    {
        private readonly IEquipmentService _equipmentService;
        public MainForm(IEquipmentService equipmentService)
        {
            InitializeComponent();
            _equipmentService = equipmentService;
        }

        // configurar exibição de TabPages por Role
        public void SetTabs(UserRole role)
        {
            ConfigureTabsByRole(role);
        }
        private void ConfigureTabsByRole(UserRole role)
        {
            // limpa todas abas
            tabPageMain.Controls.Clear();

            // abas específicas por role
            switch (role)
            {
                case UserRole.Customer:
                    tabPageMain.Controls.Add(tpEquipment);
                    tabPageMain.Controls.Add(tpProfile);
                    tabPageMain.SelectedIndex = 0; // aba Equipamentos como inicial
                    break;
                case UserRole.Seller:
                    tabPageMain.Controls.Add(tpMyAds);
                    tabPageMain.Controls.Add(tpProfile);
                    tabPageMain.SelectedIndex = 0; // aba Meus Anúncios como inicial
                    break;
            }
        }

        // carregar dados do perfil
        private void LoadUserProfileData()
        {
            var user = UserSession.CurrentUser;

            if (user == null)
            {
                MessageBox.Show("Sessão de usuário não encontrada.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            var person = user.Person;
            // dados pessoais
            lblName.Text = $"Nome Completo: {person.FullName}";
            lblEmail.Text = $"Email: {user.Email}";
            lblDocument.Text = $"CPF: {person.DocumentNumber}";
            lblPhone.Text = $"Telefone: {person.PhoneNumber}";
            // endereço
            var address = person.Address;
            lblStreet.Text = $"Rua: {address.Street}";
            lblNumber.Text = $"Número: {address.Number}";
            lblNeighborhood.Text = $"Bairro: {address.Neighborhood}";
            lblComplement.Text = $"Complemento: {address.Complement}";
            lblCity.Text = $"Cidade: {address.City}";
            lblState.Text = $"Estado: {address.State}";
            lblPostalCode.Text = $"CEP: {address.PostalCode}";
        }

        // carregar anúncios
        private void LoadMyAdsList()
        {
            var ownerId = UserSession.CurrentUser.Id;

            try
            {
                var myAds = _equipmentService.GetByOwnerId(ownerId);

                dgvMyAds.DataSource = myAds;


                // configuração de exibição dos headers
                if (dgvMyAds.Columns.Contains("Name"))
                {
                    dgvMyAds.Columns["Name"].HeaderText = "Nome";
                }
                if (dgvMyAds.Columns.Contains("Brand"))
                {
                    dgvMyAds.Columns["Brand"].HeaderText = "Marca";
                }
                if (dgvMyAds.Columns.Contains("Model"))
                {
                    dgvMyAds.Columns["Model"].HeaderText = "Modelo";
                }
                if (dgvMyAds.Columns.Contains("SerialNumber"))
                {
                    dgvMyAds.Columns["SerialNumber"].HeaderText = "Número de Série";
                }
                if (dgvMyAds.Columns.Contains("Description"))
                {
                    dgvMyAds.Columns["Description"].HeaderText = "Descrição";
                }
                if (dgvMyAds.Columns.Contains("Type"))
                {
                    dgvMyAds.Columns["Type"].HeaderText = "Tipo";
                }
                if (dgvMyAds.Columns.Contains("AcquisitionDate"))
                {
                    dgvMyAds.Columns["AcquisitionDate"].HeaderText = "Data de Aquisição";
                }
                if (dgvMyAds.Columns.Contains("ConservationStatus"))
                {
                    dgvMyAds.Columns["ConservationStatus"].HeaderText = "Estado de Conservação";
                }
                if (dgvMyAds.Columns.Contains("DailyRate"))
                {
                    dgvMyAds.Columns["DailyRate"].HeaderText = "Taxa Diária (R$)";
                    dgvMyAds.Columns["DailyRate"].DefaultCellStyle.Format = "C2"; // formatação
                }
                if (dgvMyAds.Columns.Contains("Notes"))
                {
                    dgvMyAds.Columns["Notes"].HeaderText = "Observações";
                }
                if (dgvMyAds.Columns.Contains("IsAvailable"))
                {
                    dgvMyAds.Columns["IsAvailable"].HeaderText = "Está Disponível";
                }
                // esconde IDs e email
                if (dgvMyAds.Columns.Contains("Id"))
                {
                    dgvMyAds.Columns["Id"].Visible = false;
                }
                if (dgvMyAds.Columns.Contains("OwnerId"))
                {
                    dgvMyAds.Columns["OwnerId"].Visible = false;
                }
                if (dgvMyAds.Columns.Contains("OwnerEmail"))
                {
                    dgvMyAds.Columns["OwnerEmail"].Visible = false;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadAvailableEquipment()
        {
            try
            {
                // busca todos os anúncios disponíveis
                var allAds = _equipmentService.GetAllAvailable();

                dgvAllAds.DataSource = allAds;

                // configuração de exibição dos headers
                if (dgvAllAds.Columns.Contains("Name"))
                {
                    dgvAllAds.Columns["Name"].HeaderText = "Nome";
                }
                if (dgvAllAds.Columns.Contains("Brand"))
                {
                    dgvAllAds.Columns["Brand"].HeaderText = "Marca";
                }
                if (dgvAllAds.Columns.Contains("Model"))
                {
                    dgvAllAds.Columns["Model"].HeaderText = "Modelo";
                }
                if (dgvAllAds.Columns.Contains("SerialNumber"))
                {
                    dgvAllAds.Columns["SerialNumber"].HeaderText = "Número de Série";
                }
                if (dgvAllAds.Columns.Contains("Description"))
                {
                    dgvAllAds.Columns["Description"].HeaderText = "Descrição";
                }
                if (dgvAllAds.Columns.Contains("Type"))
                {
                    dgvAllAds.Columns["Type"].HeaderText = "Tipo";
                }
                if (dgvAllAds.Columns.Contains("AcquisitionDate"))
                {
                    dgvAllAds.Columns["AcquisitionDate"].HeaderText = "Data de Aquisição";
                }
                if (dgvAllAds.Columns.Contains("ConservationStatus"))
                {
                    dgvAllAds.Columns["ConservationStatus"].HeaderText = "Estado de Conservação";
                }
                if (dgvAllAds.Columns.Contains("DailyRate"))
                {
                    dgvAllAds.Columns["DailyRate"].HeaderText = "Taxa Diária (R$)";
                    dgvAllAds.Columns["DailyRate"].DefaultCellStyle.Format = "C2"; // formatação
                }
                if (dgvAllAds.Columns.Contains("Notes"))
                {
                    dgvAllAds.Columns["Notes"].HeaderText = "Observações";
                }
                if (dgvAllAds.Columns.Contains("IsAvailable"))
                {
                    dgvAllAds.Columns["IsAvailable"].HeaderText = "Está Disponível";
                }
                // esconde IDs e email
                if (dgvAllAds.Columns.Contains("Id"))
                {
                    dgvAllAds.Columns["Id"].Visible = false;
                }
                if (dgvAllAds.Columns.Contains("OwnerId"))
                {
                    dgvAllAds.Columns["OwnerId"].Visible = false;
                }
                if (dgvAllAds.Columns.Contains("OwnerEmail"))
                {
                    dgvAllAds.Columns["OwnerEmail"].Visible = false;
                }

                dgvAllAds.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Erro ao carregar: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadUserProfileData();

            if (UserSession.CurrentUser.Role == UserRole.Seller)
                LoadMyAdsList();
            else if (UserSession.CurrentUser.Role == UserRole.Customer)
                LoadAvailableEquipment();
        }

        private void btnCreateAd_Click(object sender, EventArgs e)
        {
            var createAdForm = Program.ServiceProvider.GetRequiredService<CreateAdForm>();

            createAdForm.StartPosition = FormStartPosition.Manual;
            createAdForm.Location = new Point(
                this.Location.X + (this.Width - createAdForm.Width) / 2,
                this.Location.Y + (this.Height - createAdForm.Height) / 2
            );
            createAdForm.FormClosed += (s, args) =>
            {
                this.Show();
                LoadMyAdsList();
            };

            createAdForm.Show();
        }

        private void tabPageMain_SelectedIndexChanged(object sender, EventArgs e)
        {
            // verificar aba selecionada
            if (tabPageMain.SelectedTab == tpMyAds)
            {
                LoadMyAdsList();
            }
            else if (tabPageMain.SelectedTab == tpEquipment)
            {
                LoadAvailableEquipment();
            }
        }

        private void btnDeleteAd_Click(object sender, EventArgs e)
        {
            if (dgvMyAds.SelectedRows.Count == 0)
            {
                MessageBox.Show("Selecione um anúncio para excluir.", "Atenção", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            // obter ID do equipamento
            var selectedRow = dgvMyAds.SelectedRows[0];
            var equipmentId = (Guid)selectedRow.Cells["Id"].Value;
            var equipmentName = selectedRow.Cells["Name"].Value.ToString();
            var ownerId = UserSession.CurrentUser.Id;

            // confirmação
            DialogResult confirm = MessageBox.Show(
                $"Tem certeza que deseja excluir o anúncio '{equipmentName}'?",
                "Confirmar Exclusão",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirm == DialogResult.Yes)
            {
                try
                {
                    _equipmentService.Delete(equipmentId, ownerId);

                    MessageBox.Show("Anúncio excluído com sucesso.", "Sucesso", MessageBoxButtons.OK, MessageBoxIcon.Information);

                    // recarregar lista
                    LoadMyAdsList();
                }
                catch (UnauthorizedAccessException ex)
                {
                    MessageBox.Show(ex.Message, "Erro de Autorização", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Erro ao excluir: {ex.Message}", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }
    }
}
