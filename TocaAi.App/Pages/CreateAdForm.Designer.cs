namespace TocaAi.App.Pages
{
    partial class CreateAdForm
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
            txtName = new ReaLTaiizor.Controls.HopeTextBox();
            txtDescription = new ReaLTaiizor.Controls.HopeTextBox();
            labelEdit1 = new ReaLTaiizor.Controls.LabelEdit();
            numericUpDownDailyRate = new NumericUpDown();
            labelEdit2 = new ReaLTaiizor.Controls.LabelEdit();
            cboType = new ReaLTaiizor.Controls.HopeComboBox();
            txtModel = new ReaLTaiizor.Controls.HopeTextBox();
            txtBrand = new ReaLTaiizor.Controls.HopeTextBox();
            dtpAcquisition = new ReaLTaiizor.Controls.PoisonDateTime();
            labelEdit3 = new ReaLTaiizor.Controls.LabelEdit();
            cboConservation = new ReaLTaiizor.Controls.HopeComboBox();
            labelEdit4 = new ReaLTaiizor.Controls.LabelEdit();
            txtSerialNumber = new ReaLTaiizor.Controls.HopeTextBox();
            labelEdit5 = new ReaLTaiizor.Controls.LabelEdit();
            txtNotes = new ReaLTaiizor.Controls.HopeTextBox();
            labelEdit6 = new ReaLTaiizor.Controls.LabelEdit();
            chkIsAvailable = new ReaLTaiizor.Controls.HopeCheckBox();
            btnPostAd = new ReaLTaiizor.Controls.Button();
            ((System.ComponentModel.ISupportInitialize)numericUpDownDailyRate).BeginInit();
            SuspendLayout();
            // 
            // txtName
            // 
            txtName.BackColor = Color.White;
            txtName.BaseColor = Color.White;
            txtName.BorderColorA = Color.FromArgb(64, 158, 255);
            txtName.BorderColorB = Color.FromArgb(220, 223, 230);
            txtName.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtName.ForeColor = Color.FromArgb(48, 49, 51);
            txtName.Hint = "Nome";
            txtName.Location = new Point(43, 74);
            txtName.MaxLength = 32767;
            txtName.Multiline = false;
            txtName.Name = "txtName";
            txtName.PasswordChar = '\0';
            txtName.ScrollBars = ScrollBars.None;
            txtName.SelectedText = "";
            txtName.SelectionLength = 0;
            txtName.SelectionStart = 0;
            txtName.Size = new Size(548, 40);
            txtName.TabIndex = 18;
            txtName.TabStop = false;
            txtName.UseSystemPasswordChar = false;
            // 
            // txtDescription
            // 
            txtDescription.BackColor = Color.White;
            txtDescription.BaseColor = Color.White;
            txtDescription.BorderColorA = Color.FromArgb(64, 158, 255);
            txtDescription.BorderColorB = Color.FromArgb(220, 223, 230);
            txtDescription.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtDescription.ForeColor = Color.FromArgb(48, 49, 51);
            txtDescription.Hint = "";
            txtDescription.Location = new Point(43, 350);
            txtDescription.MaxLength = 32767;
            txtDescription.Multiline = true;
            txtDescription.Name = "txtDescription";
            txtDescription.PasswordChar = '\0';
            txtDescription.ScrollBars = ScrollBars.None;
            txtDescription.SelectedText = "";
            txtDescription.SelectionLength = 0;
            txtDescription.SelectionStart = 0;
            txtDescription.Size = new Size(548, 215);
            txtDescription.TabIndex = 19;
            txtDescription.TabStop = false;
            txtDescription.UseSystemPasswordChar = false;
            // 
            // labelEdit1
            // 
            labelEdit1.AutoSize = true;
            labelEdit1.BackColor = Color.Transparent;
            labelEdit1.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEdit1.ForeColor = Color.DimGray;
            labelEdit1.Location = new Point(49, 321);
            labelEdit1.Name = "labelEdit1";
            labelEdit1.Size = new Size(103, 24);
            labelEdit1.TabIndex = 20;
            labelEdit1.Text = "Descrição:";
            // 
            // numericUpDownDailyRate
            // 
            numericUpDownDailyRate.ForeColor = Color.DimGray;
            numericUpDownDailyRate.Location = new Point(959, 267);
            numericUpDownDailyRate.Maximum = new decimal(new int[] { 999999, 0, 0, 0 });
            numericUpDownDailyRate.Name = "numericUpDownDailyRate";
            numericUpDownDailyRate.Size = new Size(152, 34);
            numericUpDownDailyRate.TabIndex = 21;
            // 
            // labelEdit2
            // 
            labelEdit2.AutoSize = true;
            labelEdit2.BackColor = Color.Transparent;
            labelEdit2.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEdit2.ForeColor = Color.DimGray;
            labelEdit2.Location = new Point(821, 272);
            labelEdit2.Name = "labelEdit2";
            labelEdit2.Size = new Size(121, 24);
            labelEdit2.TabIndex = 22;
            labelEdit2.Text = "Tarifa Diária:";
            // 
            // cboType
            // 
            cboType.DrawMode = DrawMode.OwnerDrawFixed;
            cboType.FlatStyle = FlatStyle.Flat;
            cboType.Font = new Font("Segoe UI", 12F);
            cboType.FormattingEnabled = true;
            cboType.ItemHeight = 30;
            cboType.Location = new Point(839, 74);
            cboType.Name = "cboType";
            cboType.Size = new Size(272, 36);
            cboType.TabIndex = 23;
            // 
            // txtModel
            // 
            txtModel.BackColor = Color.White;
            txtModel.BaseColor = Color.White;
            txtModel.BorderColorA = Color.FromArgb(64, 158, 255);
            txtModel.BorderColorB = Color.FromArgb(220, 223, 230);
            txtModel.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtModel.ForeColor = Color.FromArgb(48, 49, 51);
            txtModel.Hint = "Modelo";
            txtModel.Location = new Point(43, 198);
            txtModel.MaxLength = 32767;
            txtModel.Multiline = false;
            txtModel.Name = "txtModel";
            txtModel.PasswordChar = '\0';
            txtModel.ScrollBars = ScrollBars.None;
            txtModel.SelectedText = "";
            txtModel.SelectionLength = 0;
            txtModel.SelectionStart = 0;
            txtModel.Size = new Size(548, 40);
            txtModel.TabIndex = 24;
            txtModel.TabStop = false;
            txtModel.UseSystemPasswordChar = false;
            // 
            // txtBrand
            // 
            txtBrand.BackColor = Color.White;
            txtBrand.BaseColor = Color.White;
            txtBrand.BorderColorA = Color.FromArgb(64, 158, 255);
            txtBrand.BorderColorB = Color.FromArgb(220, 223, 230);
            txtBrand.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtBrand.ForeColor = Color.FromArgb(48, 49, 51);
            txtBrand.Hint = "Marca";
            txtBrand.Location = new Point(43, 135);
            txtBrand.MaxLength = 32767;
            txtBrand.Multiline = false;
            txtBrand.Name = "txtBrand";
            txtBrand.PasswordChar = '\0';
            txtBrand.ScrollBars = ScrollBars.None;
            txtBrand.SelectedText = "";
            txtBrand.SelectionLength = 0;
            txtBrand.SelectionStart = 0;
            txtBrand.Size = new Size(548, 40);
            txtBrand.TabIndex = 25;
            txtBrand.TabStop = false;
            txtBrand.UseSystemPasswordChar = false;
            // 
            // dtpAcquisition
            // 
            dtpAcquisition.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dtpAcquisition.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            dtpAcquisition.Location = new Point(839, 205);
            dtpAcquisition.MinimumSize = new Size(0, 30);
            dtpAcquisition.Name = "dtpAcquisition";
            dtpAcquisition.Size = new Size(272, 30);
            dtpAcquisition.TabIndex = 26;
            // 
            // labelEdit3
            // 
            labelEdit3.AutoSize = true;
            labelEdit3.BackColor = Color.Transparent;
            labelEdit3.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEdit3.ForeColor = Color.DimGray;
            labelEdit3.Location = new Point(631, 80);
            labelEdit3.Name = "labelEdit3";
            labelEdit3.Size = new Size(202, 24);
            labelEdit3.TabIndex = 27;
            labelEdit3.Text = "Tipo de Equipamento:";
            // 
            // cboConservation
            // 
            cboConservation.DrawMode = DrawMode.OwnerDrawFixed;
            cboConservation.FlatStyle = FlatStyle.Flat;
            cboConservation.Font = new Font("Segoe UI", 12F);
            cboConservation.FormattingEnabled = true;
            cboConservation.ItemHeight = 30;
            cboConservation.Location = new Point(839, 135);
            cboConservation.Name = "cboConservation";
            cboConservation.Size = new Size(272, 36);
            cboConservation.TabIndex = 28;
            // 
            // labelEdit4
            // 
            labelEdit4.AutoSize = true;
            labelEdit4.BackColor = Color.Transparent;
            labelEdit4.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEdit4.ForeColor = Color.DimGray;
            labelEdit4.Location = new Point(613, 141);
            labelEdit4.Name = "labelEdit4";
            labelEdit4.Size = new Size(220, 24);
            labelEdit4.TabIndex = 29;
            labelEdit4.Text = "Estado de Conservação:";
            // 
            // txtSerialNumber
            // 
            txtSerialNumber.BackColor = Color.White;
            txtSerialNumber.BaseColor = Color.White;
            txtSerialNumber.BorderColorA = Color.FromArgb(64, 158, 255);
            txtSerialNumber.BorderColorB = Color.FromArgb(220, 223, 230);
            txtSerialNumber.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtSerialNumber.ForeColor = Color.FromArgb(48, 49, 51);
            txtSerialNumber.Hint = "Número de Série";
            txtSerialNumber.Location = new Point(43, 264);
            txtSerialNumber.MaxLength = 32767;
            txtSerialNumber.Multiline = false;
            txtSerialNumber.Name = "txtSerialNumber";
            txtSerialNumber.PasswordChar = '\0';
            txtSerialNumber.ScrollBars = ScrollBars.None;
            txtSerialNumber.SelectedText = "";
            txtSerialNumber.SelectionLength = 0;
            txtSerialNumber.SelectionStart = 0;
            txtSerialNumber.Size = new Size(548, 40);
            txtSerialNumber.TabIndex = 30;
            txtSerialNumber.TabStop = false;
            txtSerialNumber.UseSystemPasswordChar = false;
            // 
            // labelEdit5
            // 
            labelEdit5.AutoSize = true;
            labelEdit5.BackColor = Color.Transparent;
            labelEdit5.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEdit5.ForeColor = Color.DimGray;
            labelEdit5.Location = new Point(659, 208);
            labelEdit5.Name = "labelEdit5";
            labelEdit5.Size = new Size(174, 24);
            labelEdit5.TabIndex = 31;
            labelEdit5.Text = "Data de Aquisição:";
            // 
            // txtNotes
            // 
            txtNotes.BackColor = Color.White;
            txtNotes.BaseColor = Color.White;
            txtNotes.BorderColorA = Color.FromArgb(64, 158, 255);
            txtNotes.BorderColorB = Color.FromArgb(220, 223, 230);
            txtNotes.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNotes.ForeColor = Color.FromArgb(48, 49, 51);
            txtNotes.Hint = "";
            txtNotes.Location = new Point(613, 350);
            txtNotes.MaxLength = 32767;
            txtNotes.Multiline = true;
            txtNotes.Name = "txtNotes";
            txtNotes.PasswordChar = '\0';
            txtNotes.ScrollBars = ScrollBars.None;
            txtNotes.SelectedText = "";
            txtNotes.SelectionLength = 0;
            txtNotes.SelectionStart = 0;
            txtNotes.Size = new Size(498, 215);
            txtNotes.TabIndex = 32;
            txtNotes.TabStop = false;
            txtNotes.UseSystemPasswordChar = false;
            // 
            // labelEdit6
            // 
            labelEdit6.AutoSize = true;
            labelEdit6.BackColor = Color.Transparent;
            labelEdit6.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEdit6.ForeColor = Color.DimGray;
            labelEdit6.Location = new Point(622, 321);
            labelEdit6.Name = "labelEdit6";
            labelEdit6.Size = new Size(130, 24);
            labelEdit6.TabIndex = 33;
            labelEdit6.Text = "Observações:";
            // 
            // chkIsAvailable
            // 
            chkIsAvailable.AutoSize = true;
            chkIsAvailable.CheckedColor = Color.FromArgb(64, 158, 255);
            chkIsAvailable.DisabledColor = Color.FromArgb(196, 198, 202);
            chkIsAvailable.DisabledStringColor = Color.FromArgb(186, 187, 189);
            chkIsAvailable.Enable = true;
            chkIsAvailable.EnabledCheckedColor = Color.FromArgb(64, 158, 255);
            chkIsAvailable.EnabledStringColor = Color.FromArgb(153, 153, 153);
            chkIsAvailable.EnabledUncheckedColor = Color.FromArgb(156, 158, 161);
            chkIsAvailable.Font = new Font("Segoe UI", 12F);
            chkIsAvailable.ForeColor = Color.DimGray;
            chkIsAvailable.Location = new Point(784, 657);
            chkIsAvailable.Name = "chkIsAvailable";
            chkIsAvailable.Size = new Size(129, 20);
            chkIsAvailable.TabIndex = 34;
            chkIsAvailable.Text = "Disponível";
            chkIsAvailable.UseVisualStyleBackColor = true;
            // 
            // btnPostAd
            // 
            btnPostAd.BackColor = Color.Transparent;
            btnPostAd.BorderColor = Color.SaddleBrown;
            btnPostAd.EnteredBorderColor = Color.SaddleBrown;
            btnPostAd.EnteredColor = Color.Chocolate;
            btnPostAd.Font = new Font("Lato", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnPostAd.Image = null;
            btnPostAd.ImageAlign = ContentAlignment.MiddleLeft;
            btnPostAd.InactiveColor = Color.DarkOrange;
            btnPostAd.Location = new Point(920, 648);
            btnPostAd.Name = "btnPostAd";
            btnPostAd.PressedBorderColor = Color.SaddleBrown;
            btnPostAd.PressedColor = Color.Chocolate;
            btnPostAd.Size = new Size(191, 37);
            btnPostAd.TabIndex = 35;
            btnPostAd.Text = "Anunciar";
            btnPostAd.TextAlignment = StringAlignment.Center;
            btnPostAd.Click += btnPostAd_Click;
            // 
            // CreateAdForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BorderColor = Color.Transparent;
            ClientSize = new Size(1152, 720);
            Controls.Add(btnPostAd);
            Controls.Add(chkIsAvailable);
            Controls.Add(labelEdit6);
            Controls.Add(txtNotes);
            Controls.Add(labelEdit5);
            Controls.Add(txtSerialNumber);
            Controls.Add(labelEdit4);
            Controls.Add(cboConservation);
            Controls.Add(labelEdit3);
            Controls.Add(dtpAcquisition);
            Controls.Add(txtBrand);
            Controls.Add(txtModel);
            Controls.Add(cboType);
            Controls.Add(labelEdit2);
            Controls.Add(numericUpDownDailyRate);
            Controls.Add(labelEdit1);
            Controls.Add(txtDescription);
            Controls.Add(txtName);
            HeaderColor = Color.Gray;
            MaximizeBox = false;
            Name = "CreateAdForm";
            Text = "TocaAi - Criar Anúncio";
            ((System.ComponentModel.ISupportInitialize)numericUpDownDailyRate).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.HopeTextBox txtName;
        private ReaLTaiizor.Controls.HopeTextBox txtDescription;
        private ReaLTaiizor.Controls.LabelEdit labelEdit1;
        private NumericUpDown numericUpDownDailyRate;
        private ReaLTaiizor.Controls.LabelEdit labelEdit2;
        private ReaLTaiizor.Controls.HopeComboBox cboType;
        private ReaLTaiizor.Controls.HopeTextBox txtModel;
        private ReaLTaiizor.Controls.HopeTextBox txtBrand;
        private ReaLTaiizor.Controls.PoisonDateTime dtpAcquisition;
        private ReaLTaiizor.Controls.LabelEdit labelEdit3;
        private ReaLTaiizor.Controls.HopeComboBox cboConservation;
        private ReaLTaiizor.Controls.LabelEdit labelEdit4;
        private ReaLTaiizor.Controls.HopeTextBox txtSerialNumber;
        private ReaLTaiizor.Controls.LabelEdit labelEdit5;
        private ReaLTaiizor.Controls.HopeTextBox txtNotes;
        private ReaLTaiizor.Controls.LabelEdit labelEdit6;
        private ReaLTaiizor.Controls.HopeCheckBox chkIsAvailable;
        private ReaLTaiizor.Controls.Button btnPostAd;
    }
}