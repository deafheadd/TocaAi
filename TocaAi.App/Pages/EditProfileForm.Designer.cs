namespace TocaAi.App.Pages
{
    partial class EditProfileForm
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
            txtPhoneNumber = new ReaLTaiizor.Controls.HopeTextBox();
            txtStreet = new ReaLTaiizor.Controls.HopeTextBox();
            txtNumber = new ReaLTaiizor.Controls.HopeTextBox();
            txtNeighborhood = new ReaLTaiizor.Controls.HopeTextBox();
            cboState = new ReaLTaiizor.Controls.HopeComboBox();
            txtCity = new ReaLTaiizor.Controls.HopeTextBox();
            txtPostalCode = new ReaLTaiizor.Controls.HopeTextBox();
            txtComplement = new ReaLTaiizor.Controls.HopeTextBox();
            txtName = new ReaLTaiizor.Controls.HopeTextBox();
            btnSaveChanges = new ReaLTaiizor.Controls.Button();
            labelEdit1 = new ReaLTaiizor.Controls.LabelEdit();
            labelEdit2 = new ReaLTaiizor.Controls.LabelEdit();
            SuspendLayout();
            // 
            // txtPhoneNumber
            // 
            txtPhoneNumber.BackColor = Color.White;
            txtPhoneNumber.BaseColor = Color.White;
            txtPhoneNumber.BorderColorA = Color.FromArgb(64, 158, 255);
            txtPhoneNumber.BorderColorB = Color.FromArgb(220, 223, 230);
            txtPhoneNumber.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPhoneNumber.ForeColor = Color.FromArgb(48, 49, 51);
            txtPhoneNumber.Hint = "Número de Telefone";
            txtPhoneNumber.Location = new Point(70, 146);
            txtPhoneNumber.MaxLength = 32767;
            txtPhoneNumber.Multiline = false;
            txtPhoneNumber.Name = "txtPhoneNumber";
            txtPhoneNumber.PasswordChar = '\0';
            txtPhoneNumber.ScrollBars = ScrollBars.None;
            txtPhoneNumber.SelectedText = "";
            txtPhoneNumber.SelectionLength = 0;
            txtPhoneNumber.SelectionStart = 0;
            txtPhoneNumber.Size = new Size(548, 40);
            txtPhoneNumber.TabIndex = 19;
            txtPhoneNumber.TabStop = false;
            txtPhoneNumber.UseSystemPasswordChar = false;
            // 
            // txtStreet
            // 
            txtStreet.BackColor = Color.White;
            txtStreet.BaseColor = Color.White;
            txtStreet.BorderColorA = Color.FromArgb(64, 158, 255);
            txtStreet.BorderColorB = Color.FromArgb(220, 223, 230);
            txtStreet.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStreet.ForeColor = Color.FromArgb(48, 49, 51);
            txtStreet.Hint = "Rua";
            txtStreet.Location = new Point(70, 243);
            txtStreet.MaxLength = 32767;
            txtStreet.Multiline = false;
            txtStreet.Name = "txtStreet";
            txtStreet.PasswordChar = '\0';
            txtStreet.ScrollBars = ScrollBars.None;
            txtStreet.SelectedText = "";
            txtStreet.SelectionLength = 0;
            txtStreet.SelectionStart = 0;
            txtStreet.Size = new Size(439, 40);
            txtStreet.TabIndex = 20;
            txtStreet.TabStop = false;
            txtStreet.UseSystemPasswordChar = false;
            // 
            // txtNumber
            // 
            txtNumber.BackColor = Color.White;
            txtNumber.BaseColor = Color.White;
            txtNumber.BorderColorA = Color.FromArgb(64, 158, 255);
            txtNumber.BorderColorB = Color.FromArgb(220, 223, 230);
            txtNumber.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNumber.ForeColor = Color.FromArgb(48, 49, 51);
            txtNumber.Hint = "Número";
            txtNumber.Location = new Point(515, 243);
            txtNumber.MaxLength = 32767;
            txtNumber.Multiline = false;
            txtNumber.Name = "txtNumber";
            txtNumber.PasswordChar = '\0';
            txtNumber.ScrollBars = ScrollBars.None;
            txtNumber.SelectedText = "";
            txtNumber.SelectionLength = 0;
            txtNumber.SelectionStart = 0;
            txtNumber.Size = new Size(103, 40);
            txtNumber.TabIndex = 21;
            txtNumber.TabStop = false;
            txtNumber.UseSystemPasswordChar = false;
            // 
            // txtNeighborhood
            // 
            txtNeighborhood.BackColor = Color.White;
            txtNeighborhood.BaseColor = Color.White;
            txtNeighborhood.BorderColorA = Color.FromArgb(64, 158, 255);
            txtNeighborhood.BorderColorB = Color.FromArgb(220, 223, 230);
            txtNeighborhood.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNeighborhood.ForeColor = Color.FromArgb(48, 49, 51);
            txtNeighborhood.Hint = "Bairro";
            txtNeighborhood.Location = new Point(70, 289);
            txtNeighborhood.MaxLength = 32767;
            txtNeighborhood.Multiline = false;
            txtNeighborhood.Name = "txtNeighborhood";
            txtNeighborhood.PasswordChar = '\0';
            txtNeighborhood.ScrollBars = ScrollBars.None;
            txtNeighborhood.SelectedText = "";
            txtNeighborhood.SelectionLength = 0;
            txtNeighborhood.SelectionStart = 0;
            txtNeighborhood.Size = new Size(548, 40);
            txtNeighborhood.TabIndex = 22;
            txtNeighborhood.TabStop = false;
            txtNeighborhood.UseSystemPasswordChar = false;
            // 
            // cboState
            // 
            cboState.DrawMode = DrawMode.OwnerDrawFixed;
            cboState.FlatStyle = FlatStyle.Flat;
            cboState.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            cboState.ForeColor = SystemColors.WindowFrame;
            cboState.FormattingEnabled = true;
            cboState.ItemHeight = 30;
            cboState.Items.AddRange(new object[] { "AC", "AL", "AP", "AM", "BA", "CE", "DF", "ES", "GO", "MA", "MT", "MS", "MG", "PA", "PB", "PR", "PE", "PI", "RJ", "RN", "RS", "RO", "RR", "SC", "SP", "SE", "TO" });
            cboState.Location = new Point(515, 335);
            cboState.Name = "cboState";
            cboState.Size = new Size(103, 36);
            cboState.TabIndex = 23;
            cboState.Text = "Estado";
            // 
            // txtCity
            // 
            txtCity.BackColor = Color.White;
            txtCity.BaseColor = Color.White;
            txtCity.BorderColorA = Color.FromArgb(64, 158, 255);
            txtCity.BorderColorB = Color.FromArgb(220, 223, 230);
            txtCity.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtCity.ForeColor = Color.FromArgb(48, 49, 51);
            txtCity.Hint = "Cidade";
            txtCity.Location = new Point(70, 335);
            txtCity.MaxLength = 32767;
            txtCity.Multiline = false;
            txtCity.Name = "txtCity";
            txtCity.PasswordChar = '\0';
            txtCity.ScrollBars = ScrollBars.None;
            txtCity.SelectedText = "";
            txtCity.SelectionLength = 0;
            txtCity.SelectionStart = 0;
            txtCity.Size = new Size(439, 40);
            txtCity.TabIndex = 24;
            txtCity.TabStop = false;
            txtCity.UseSystemPasswordChar = false;
            // 
            // txtPostalCode
            // 
            txtPostalCode.BackColor = Color.White;
            txtPostalCode.BaseColor = Color.White;
            txtPostalCode.BorderColorA = Color.FromArgb(64, 158, 255);
            txtPostalCode.BorderColorB = Color.FromArgb(220, 223, 230);
            txtPostalCode.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPostalCode.ForeColor = Color.FromArgb(48, 49, 51);
            txtPostalCode.Hint = "CEP";
            txtPostalCode.Location = new Point(70, 381);
            txtPostalCode.MaxLength = 32767;
            txtPostalCode.Multiline = false;
            txtPostalCode.Name = "txtPostalCode";
            txtPostalCode.PasswordChar = '\0';
            txtPostalCode.ScrollBars = ScrollBars.None;
            txtPostalCode.SelectedText = "";
            txtPostalCode.SelectionLength = 0;
            txtPostalCode.SelectionStart = 0;
            txtPostalCode.Size = new Size(548, 40);
            txtPostalCode.TabIndex = 25;
            txtPostalCode.TabStop = false;
            txtPostalCode.UseSystemPasswordChar = false;
            // 
            // txtComplement
            // 
            txtComplement.BackColor = Color.White;
            txtComplement.BaseColor = Color.White;
            txtComplement.BorderColorA = Color.FromArgb(64, 158, 255);
            txtComplement.BorderColorB = Color.FromArgb(220, 223, 230);
            txtComplement.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtComplement.ForeColor = Color.FromArgb(48, 49, 51);
            txtComplement.Hint = "Complemento";
            txtComplement.Location = new Point(70, 427);
            txtComplement.MaxLength = 32767;
            txtComplement.Multiline = false;
            txtComplement.Name = "txtComplement";
            txtComplement.PasswordChar = '\0';
            txtComplement.ScrollBars = ScrollBars.None;
            txtComplement.SelectedText = "";
            txtComplement.SelectionLength = 0;
            txtComplement.SelectionStart = 0;
            txtComplement.Size = new Size(548, 40);
            txtComplement.TabIndex = 26;
            txtComplement.TabStop = false;
            txtComplement.UseSystemPasswordChar = false;
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.BaseColor = Color.White;
            txtName.BorderColorA = Color.FromArgb(64, 158, 255);
            txtName.BorderColorB = Color.FromArgb(220, 223, 230);
            txtName.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.ForeColor = Color.FromArgb(48, 49, 51);
            txtName.Hint = "Nome Completo";
            txtName.Location = new Point(70, 100);
            txtName.MaxLength = 32767;
            txtName.Multiline = false;
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.ScrollBars = ScrollBars.None;
            txtName.SelectedText = "";
            txtName.SelectionLength = 0;
            txtName.SelectionStart = 0;
            txtName.Size = new Size(548, 40);
            txtName.TabIndex = 27;
            txtName.TabStop = false;
            txtName.UseSystemPasswordChar = false;
            // 
            // btnSaveChanges
            // 
            btnSaveChanges.BackColor = Color.Transparent;
            btnSaveChanges.BorderColor = Color.SaddleBrown;
            btnSaveChanges.EnteredBorderColor = Color.SaddleBrown;
            btnSaveChanges.EnteredColor = Color.Chocolate;
            btnSaveChanges.Font = new Font("Lato", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnSaveChanges.Image = null;
            btnSaveChanges.ImageAlign = ContentAlignment.MiddleLeft;
            btnSaveChanges.InactiveColor = Color.DarkOrange;
            btnSaveChanges.Location = new Point(427, 488);
            btnSaveChanges.Name = "btnSaveChanges";
            btnSaveChanges.PressedBorderColor = Color.SaddleBrown;
            btnSaveChanges.PressedColor = Color.Chocolate;
            btnSaveChanges.Size = new Size(191, 37);
            btnSaveChanges.TabIndex = 28;
            btnSaveChanges.Text = "Salvar Alterações";
            btnSaveChanges.TextAlignment = StringAlignment.Center;
            btnSaveChanges.Click += btnSaveChanges_Click;
            // 
            // labelEdit1
            // 
            labelEdit1.AutoSize = true;
            labelEdit1.BackColor = Color.Transparent;
            labelEdit1.Font = new Font("Lato", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEdit1.ForeColor = Color.DimGray;
            labelEdit1.Location = new Point(70, 73);
            labelEdit1.Name = "labelEdit1";
            labelEdit1.Size = new Size(168, 21);
            labelEdit1.TabIndex = 29;
            labelEdit1.Text = "Informações pessoais";
            // 
            // labelEdit2
            // 
            labelEdit2.AutoSize = true;
            labelEdit2.BackColor = Color.Transparent;
            labelEdit2.Font = new Font("Lato", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEdit2.ForeColor = Color.DimGray;
            labelEdit2.Location = new Point(70, 217);
            labelEdit2.Name = "labelEdit2";
            labelEdit2.Size = new Size(81, 21);
            labelEdit2.TabIndex = 30;
            labelEdit2.Text = "Endereço";
            // 
            // EditProfileForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BorderColor = Color.Transparent;
            ClientSize = new Size(692, 576);
            Controls.Add(labelEdit2);
            Controls.Add(labelEdit1);
            Controls.Add(btnSaveChanges);
            Controls.Add(txtName);
            Controls.Add(txtComplement);
            Controls.Add(txtPostalCode);
            Controls.Add(txtCity);
            Controls.Add(cboState);
            Controls.Add(txtNeighborhood);
            Controls.Add(txtNumber);
            Controls.Add(txtStreet);
            Controls.Add(txtPhoneNumber);
            HeaderColor = Color.Gray;
            MaximizeBox = false;
            Name = "EditProfileForm";
            Text = "TocaAi - Editar Perfil";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ReaLTaiizor.Controls.Button btnSaveChanges;
        private ReaLTaiizor.Controls.LabelEdit labelEdit1;
        private ReaLTaiizor.Controls.LabelEdit labelEdit2;
        public ReaLTaiizor.Controls.HopeTextBox txtPhoneNumber;
        public ReaLTaiizor.Controls.HopeTextBox txtStreet;
        public ReaLTaiizor.Controls.HopeTextBox txtNumber;
        public ReaLTaiizor.Controls.HopeTextBox txtNeighborhood;
        public ReaLTaiizor.Controls.HopeComboBox cboState;
        public ReaLTaiizor.Controls.HopeTextBox txtCity;
        public ReaLTaiizor.Controls.HopeTextBox txtPostalCode;
        public ReaLTaiizor.Controls.HopeTextBox txtComplement;
        public ReaLTaiizor.Controls.HopeTextBox txtName;
    }
}