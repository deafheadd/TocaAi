using ReaLTaiizor.Forms;
using TocaAi.Domain.Entities;

namespace TocaAi.App.Pages
{
    public partial class EditProfileForm : LostForm
    {
        private Guid _personId;
        public EditProfileForm(Person person)
        {
            InitializeComponent();

            _personId = person.Id;

            txtName.Text = person.FullName;
            txtPhoneNumber.Text = person.PhoneNumber;

            var addr = person.Address;
            txtStreet.Text = addr.Street;
            txtNumber.Text = addr.Number;
            txtNeighborhood.Text = addr.Neighborhood;
            txtComplement.Text = addr.Complement;
            txtCity.Text = addr.City;
            cboState.SelectedItem = addr.State;
            txtPostalCode.Text = addr.PostalCode;
        }

        private void btnSaveChanges_Click(object sender, EventArgs e)
        {
            try
            {
                if (cboState.SelectedItem == null)
                {
                    MessageBox.Show("Selecione um estado.");
                    return;
                }

                // confirmação
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Erro ao validar: " + ex.Message);
            }
        }
    }
}
