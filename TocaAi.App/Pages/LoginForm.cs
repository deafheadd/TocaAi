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
    }
}
