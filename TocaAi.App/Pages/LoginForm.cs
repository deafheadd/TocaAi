using ReaLTaiizor.Forms;

namespace TocaAi.App.Pages
{
    public partial class LoginForm : LostForm
    {
        public LoginForm()
        {
            InitializeComponent();

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
            var registerForm = new RegisterForm();

            // centralizar sobre o form atual
            registerForm.StartPosition = FormStartPosition.Manual;
            registerForm.Location = new Point(
                this.Location.X + (this.Width - registerForm.Width) / 2,
                this.Location.Y + (this.Height - registerForm.Height) / 2
            );

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
    }
}
