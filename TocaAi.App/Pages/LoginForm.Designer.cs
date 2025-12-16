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
            hopeTextBox1 = new ReaLTaiizor.Controls.HopeTextBox();
            hopeTextBox2 = new ReaLTaiizor.Controls.HopeTextBox();
            button1 = new ReaLTaiizor.Controls.Button();
            labelEdit2 = new ReaLTaiizor.Controls.LabelEdit();
            lblRegister = new ReaLTaiizor.Controls.LabelEdit();
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
            // hopeTextBox1
            // 
            hopeTextBox1.BackColor = Color.White;
            hopeTextBox1.BaseColor = Color.White;
            hopeTextBox1.BorderColorA = Color.FromArgb(64, 158, 255);
            hopeTextBox1.BorderColorB = Color.FromArgb(220, 223, 230);
            hopeTextBox1.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hopeTextBox1.ForeColor = Color.FromArgb(48, 49, 51);
            hopeTextBox1.Hint = "Email";
            hopeTextBox1.Location = new Point(74, 219);
            hopeTextBox1.MaxLength = 32767;
            hopeTextBox1.Multiline = false;
            hopeTextBox1.Name = "hopeTextBox1";
            hopeTextBox1.PasswordChar = '\0';
            hopeTextBox1.ScrollBars = ScrollBars.None;
            hopeTextBox1.SelectedText = "";
            hopeTextBox1.SelectionLength = 0;
            hopeTextBox1.SelectionStart = 0;
            hopeTextBox1.Size = new Size(362, 40);
            hopeTextBox1.TabIndex = 1;
            hopeTextBox1.TabStop = false;
            hopeTextBox1.UseSystemPasswordChar = false;
            // 
            // hopeTextBox2
            // 
            hopeTextBox2.BackColor = Color.White;
            hopeTextBox2.BaseColor = Color.White;
            hopeTextBox2.BorderColorA = Color.FromArgb(64, 158, 255);
            hopeTextBox2.BorderColorB = Color.FromArgb(220, 223, 230);
            hopeTextBox2.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            hopeTextBox2.ForeColor = Color.FromArgb(48, 49, 51);
            hopeTextBox2.Hint = "Senha";
            hopeTextBox2.Location = new Point(74, 277);
            hopeTextBox2.MaxLength = 32767;
            hopeTextBox2.Multiline = false;
            hopeTextBox2.Name = "hopeTextBox2";
            hopeTextBox2.PasswordChar = '\0';
            hopeTextBox2.ScrollBars = ScrollBars.None;
            hopeTextBox2.SelectedText = "";
            hopeTextBox2.SelectionLength = 0;
            hopeTextBox2.SelectionStart = 0;
            hopeTextBox2.Size = new Size(362, 40);
            hopeTextBox2.TabIndex = 2;
            hopeTextBox2.TabStop = false;
            hopeTextBox2.UseSystemPasswordChar = false;
            // 
            // button1
            // 
            button1.BackColor = Color.Transparent;
            button1.BorderColor = Color.SaddleBrown;
            button1.EnteredBorderColor = Color.SaddleBrown;
            button1.EnteredColor = Color.Chocolate;
            button1.Font = new Font("Lato", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            button1.Image = null;
            button1.ImageAlign = ContentAlignment.MiddleLeft;
            button1.InactiveColor = Color.DarkOrange;
            button1.Location = new Point(151, 348);
            button1.Name = "button1";
            button1.PressedBorderColor = Color.SaddleBrown;
            button1.PressedColor = Color.Chocolate;
            button1.Size = new Size(205, 40);
            button1.TabIndex = 3;
            button1.Text = "Entrar";
            button1.TextAlignment = StringAlignment.Center;
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
            // 
            // LoginForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BorderColor = Color.Transparent;
            ClientSize = new Size(521, 455);
            Controls.Add(lblRegister);
            Controls.Add(labelEdit2);
            Controls.Add(button1);
            Controls.Add(hopeTextBox2);
            Controls.Add(hopeTextBox1);
            Controls.Add(labelEdit1);
            HeaderColor = Color.Gray;
            MaximizeBox = false;
            Name = "LoginForm";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TocaAi";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.LabelEdit labelEdit1;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBox1;
        private ReaLTaiizor.Controls.HopeTextBox hopeTextBox2;
        private ReaLTaiizor.Controls.Button button1;
        private ReaLTaiizor.Controls.LabelEdit labelEdit2;
        private ReaLTaiizor.Controls.LabelEdit lblRegister;
    }
}