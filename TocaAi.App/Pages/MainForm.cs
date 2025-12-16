using ReaLTaiizor.Forms;
using TocaAi.App.Session;

namespace TocaAi.App.Pages
{
    public partial class MainForm : LostForm
    {
        public MainForm()
        {
            InitializeComponent();
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
                    tabPageMain.Controls.Add(tpCreateAd);
                    tabPageMain.Controls.Add(tpMyAds);
                    tabPageMain.Controls.Add(tpProfile);
                    tabPageMain.SelectedIndex = 1; // aba Meus Anúncios como inicial
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

        private void MainForm_Load(object sender, EventArgs e)
        {
            LoadUserProfileData();
        }
    }
}
