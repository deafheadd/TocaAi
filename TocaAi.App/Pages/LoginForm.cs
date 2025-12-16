using Microsoft.Extensions.DependencyInjection;
using ReaLTaiizor.Forms;
using TocaAi.App.Session;
using TocaAi.Domain.Base;
using TocaAi.Domain.Entities;
using TocaAi.Domain.Interfaces;

namespace TocaAi.App.Pages
{
    public partial class LoginForm : LostForm
    {
        private readonly IUserAccountRepository _userAccountRepository;
        private readonly MainForm _mainForm;

        public LoginForm(IUserAccountRepository userAccountRepository, MainForm mainForm)
        {
            InitializeComponent();

            _userAccountRepository = userAccountRepository;
            _mainForm = mainForm;

            // trava o tamanho da janela
            this.MinimumSize = this.Size;
            this.MaximumSize = this.Size;

            // esconde a senha
            txtPassword.UseSystemPasswordChar = true;

            // hover do mouse
            lblRegister.MouseEnter += (s, e) =>
            {
                lblRegister.ForeColor = Color.DarkOrange;
            };

            lblRegister.MouseLeave += (s, e) =>
            {
                lblRegister.ForeColor = Color.DimGray;
            };
        }

        private void lblRegister_Click(object sender, EventArgs e)
        {
            var registerForm = Program.ServiceProvider.GetRequiredService<RegisterForm>();

            // centralizar sobre o login
            registerForm.StartPosition = FormStartPosition.Manual;
            registerForm.Location = new Point(
                this.Location.X + (this.Width - registerForm.Width) / 2,
                this.Location.Y + (this.Height - registerForm.Height) / 2
            );

            registerForm.FormClosed += (s, args) => this.Show(); // voltar ao login

            registerForm.Show();
            this.Hide();
        }

        private void LoginForm_FormClosing(object sender, FormClosingEventArgs e)
        {
            Application.Exit();
        }

        private void pBoxEye_Click(object sender, EventArgs e)
        {
            if (txtPassword.UseSystemPasswordChar == true)
            {
                // exibe senha
                txtPassword.UseSystemPasswordChar = false;
                pBoxEye.Image = Properties.Resources.eye_hidden;
            }
            else
            {
                // esconde senha
                txtPassword.UseSystemPasswordChar = true;
                pBoxEye.Image = Properties.Resources.eye_visible;
            }
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            string email = txtEmail.Text.Trim();
            string password = txtPassword.Text.Trim();

            if (string.IsNullOrEmpty(email) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Informe email e senha.", "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            var user = _userAccountRepository.GetByEmail(email);
            if (user == null || !user.IsActive || user.PasswordHash != password)
            {
                MessageBox.Show("Usuário ou senha inválidos.", "Erro", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            // login válido
            UserSession.Login(user); // inicia sessão

            OpenMainWindow();
        }

        private void OpenMainWindow()
        {
            var mainForm = _mainForm;

            // recupera role do usuário conectado
            UserRole userRole = UserSession.CurrentUser.Role;

            mainForm.SetTabs(userRole);
            
            mainForm.StartPosition = FormStartPosition.Manual;
            mainForm.Location = new Point(
                this.Location.X + (this.Width - mainForm.Width) / 2,
                this.Location.Y + (this.Height - mainForm.Height) / 2
            );

            mainForm.FormClosed += (s, args) =>
            {
                UserSession.Logout();
                this.Show();
            };

            mainForm.Show();
            this.Hide();
        }
    }
}
