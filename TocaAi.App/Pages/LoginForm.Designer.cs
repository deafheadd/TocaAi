namespace TocaAi.App.Pages
{
    partial class LoginForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            labelEdit1 = new ReaLTaiizor.Controls.LabelEdit();
            txtEmail = new ReaLTaiizor.Controls.HopeTextBox();
            txtPassword = new ReaLTaiizor.Controls.HopeTextBox();
            btnLogin = new ReaLTaiizor.Controls.Button();
            labelEdit2 = new ReaLTaiizor.Controls.LabelEdit();
            lblRegister = new ReaLTaiizor.Controls.LabelEdit();
            pBoxEye = new ReaLTaiizor.Controls.HopePictureBox();
            ((System.ComponentModel.ISupportInitialize)pBoxEye).BeginInit();
            SuspendLayout();
            // 
            // labelEdit1
            // 
            labelEdit1.AutoSize = true;
            labelEdit1.BackColor = Color.Transparent;
            labelEdit1.Font = new Font("Lato", 22.1999989F, FontStyle.Bold, GraphicsUnit.Point, 0);
            labelEdit1.ForeColor = Color.DarkOrange;
            labelEdit1.Location = new Point(182, 112);
            labelEdit1.Name = "labelEdit1";
            labelEdit1.Size = new Size(131, 45);
            labelEdit1.TabIndex = 0;
            labelEdit1.Text = "TocaAi";
            // 
            // txtEmail
            // 
            txtEmail.BackColor = Color.White;
            txtEmail.BaseColor = Color.White;
            txtEmail.BorderColorA = Color.FromArgb(64, 158, 255);
            txtEmail.BorderColorB = Color.FromArgb(220, 223, 230);
            txtEmail.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtEmail.ForeColor = Color.FromArgb(48, 49, 51);
            txtEmail.Hint = "Email";
            txtEmail.Location = new Point(74, 219);
            txtEmail.MaxLength = 32767;
            txtEmail.Multiline = false;
            txtEmail.Name = "txtEmail";
            txtEmail.PasswordChar = '\0';
            txtEmail.ScrollBars = ScrollBars.None;
            txtEmail.SelectedText = "";
            txtEmail.SelectionLength = 0;
            txtEmail.SelectionStart = 0;
            txtEmail.Size = new Size(362, 40);
            txtEmail.TabIndex = 1;
            txtEmail.TabStop = false;
            txtEmail.UseSystemPasswordChar = false;
            // 
            // txtPassword
            // 
            txtPassword.BackColor = Color.White;
            txtPassword.BaseColor = Color.White;
            txtPassword.BorderColorA = Color.FromArgb(64, 158, 255);
            txtPassword.BorderColorB = Color.FromArgb(220, 223, 230);
            txtPassword.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPassword.ForeColor = Color.FromArgb(48, 49, 51);
            txtPassword.Hint = "Senha";
            txtPassword.Location = new Point(74, 277);
            txtPassword.MaxLength = 32767;
            txtPassword.Multiline = false;
            txtPassword.Name = "txtPassword";
            txtPassword.PasswordChar = '\0';
            txtPassword.ScrollBars = ScrollBars.None;
            txtPassword.SelectedText = "";
            txtPassword.SelectionLength = 0;
            txtPassword.SelectionStart = 0;
            txtPassword.Size = new Size(362, 40);
            txtPassword.TabIndex = 2;
            txtPassword.TabStop = false;
            txtPassword.UseSystemPasswordChar = false;
            // 
            // btnLogin
            // 
            btnLogin.BackColor = Color.Transparent;
            btnLogin.BorderColor = Color.SaddleBrown;
            btnLogin.EnteredBorderColor = Color.SaddleBrown;
            btnLogin.EnteredColor = Color.Chocolate;
            btnLogin.Font = new Font("Lato", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnLogin.Image = null;
            btnLogin.ImageAlign = ContentAlignment.MiddleLeft;
            btnLogin.InactiveColor = Color.DarkOrange;
            btnLogin.Location = new Point(151, 348);
            btnLogin.Name = "btnLogin";
            btnLogin.PressedBorderColor = Color.SaddleBrown;
            btnLogin.PressedColor = Color.Chocolate;
            btnLogin.Size = new Size(205, 40);
            btnLogin.TabIndex = 3;
            btnLogin.Text = "Entrar";
            btnLogin.TextAlignment = StringAlignment.Center;
            btnLogin.Click += btnLogin_Click;
            // 
            // labelEdit2
            // 
            labelEdit2.AutoSize = true;
            labelEdit2.BackColor = Color.Transparent;
            labelEdit2.Font = new Font("Lato", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEdit2.ForeColor = Color.DimGray;
            labelEdit2.Location = new Point(90, 410);
            labelEdit2.Name = "labelEdit2";
            labelEdit2.Size = new Size(223, 21);
            labelEdit2.TabIndex = 4;
            labelEdit2.Text = "Ainda não possui uma conta?";
            // 
            // lblRegister
            // 
            lblRegister.AutoSize = true;
            lblRegister.BackColor = Color.Transparent;
            lblRegister.Font = new Font("Lato", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblRegister.ForeColor = Color.DimGray;
            lblRegister.Location = new Point(309, 410);
            lblRegister.Name = "lblRegister";
            lblRegister.Size = new Size(92, 21);
            lblRegister.TabIndex = 5;
            lblRegister.Text = "Registre-se";
            lblRegister.Click += lblRegister_Click;
            // 
            // pBoxEye
            // 
            pBoxEye.BackColor = Color.White;
            pBoxEye.Image = Properties.Resources.eye_visible;
            pBoxEye.Location = new Point(399, 280);
            pBoxEye.Name = "pBoxEye";
            pBoxEye.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            pBoxEye.Size = new Size(34, 34);
            pBoxEye.SizeMode = PictureBoxSizeMode.Zoom;
            pBoxEye.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            pBoxEye.TabIndex = 6;
            pBoxEye.TabStop = false;
            pBoxEye.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            pBoxEye.Click += pBoxEye_Click;
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BorderColor = Color.Transparent;
            ClientSize = new Size(510, 455);
            Controls.Add(pBoxEye);
            Controls.Add(lblRegister);
            Controls.Add(labelEdit2);
            Controls.Add(btnLogin);
            Controls.Add(txtPassword);
            Controls.Add(txtEmail);
            Controls.Add(labelEdit1);
            HeaderColor = Color.Gray;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TocaAi";
            FormClosing += LoginForm_FormClosing;
            ((System.ComponentModel.ISupportInitialize)pBoxEye).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.LabelEdit labelEdit1;
        private ReaLTaiizor.Controls.HopeTextBox txtEmail;
        private ReaLTaiizor.Controls.HopeTextBox txtPassword;
        private ReaLTaiizor.Controls.Button btnLogin;
        private ReaLTaiizor.Controls.LabelEdit labelEdit2;
        private ReaLTaiizor.Controls.LabelEdit lblRegister;
        private ReaLTaiizor.Controls.HopePictureBox pBoxEye;
    }
}