namespace TocaAi.App.Pages
{
    partial class MainForm
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
            tabPageMain = new ReaLTaiizor.Controls.AirTabPage();
            tpEquipment = new TabPage();
            flowLayoutPanel1 = new FlowLayoutPanel();
            tpMyAds = new TabPage();
            btnCreateAd = new ReaLTaiizor.Controls.Button();
            tpProfile = new TabPage();
            gpBoxAddress = new ReaLTaiizor.Controls.HopeGroupBox();
            lblComplement = new ReaLTaiizor.Controls.LabelEdit();
            lblState = new ReaLTaiizor.Controls.LabelEdit();
            lblNumber = new ReaLTaiizor.Controls.LabelEdit();
            btnEditAddress = new ReaLTaiizor.Controls.Button();
            lblPostalCode = new ReaLTaiizor.Controls.LabelEdit();
            lblCity = new ReaLTaiizor.Controls.LabelEdit();
            lblNeighborhood = new ReaLTaiizor.Controls.LabelEdit();
            lblStreet = new ReaLTaiizor.Controls.LabelEdit();
            gpBoxPersonalInfo = new ReaLTaiizor.Controls.HopeGroupBox();
            btnEditPersonalInfo = new ReaLTaiizor.Controls.Button();
            lblPhone = new ReaLTaiizor.Controls.LabelEdit();
            lblDocument = new ReaLTaiizor.Controls.LabelEdit();
            lblEmail = new ReaLTaiizor.Controls.LabelEdit();
            pbProfilePicture = new ReaLTaiizor.Controls.HopePictureBox();
            lblName = new ReaLTaiizor.Controls.LabelEdit();
            tabPageMain.SuspendLayout();
            tpEquipment.SuspendLayout();
            tpMyAds.SuspendLayout();
            tpProfile.SuspendLayout();
            gpBoxAddress.SuspendLayout();
            gpBoxPersonalInfo.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)pbProfilePicture).BeginInit();
            SuspendLayout();
            // 
            // tabPageMain
            // 
            tabPageMain.Alignment = TabAlignment.Left;
            tabPageMain.BaseColor = Color.WhiteSmoke;
            tabPageMain.Controls.Add(tpEquipment);
            tabPageMain.Controls.Add(tpMyAds);
            tabPageMain.Controls.Add(tpProfile);
            tabPageMain.Dock = DockStyle.Fill;
            tabPageMain.DrawMode = TabDrawMode.OwnerDrawFixed;
            tabPageMain.ItemSize = new Size(30, 170);
            tabPageMain.Location = new Point(2, 36);
            tabPageMain.Multiline = true;
            tabPageMain.Name = "tabPageMain";
            tabPageMain.NormalTextColor = Color.DimGray;
            tabPageMain.SelectedIndex = 0;
            tabPageMain.SelectedTabBackColor = Color.White;
            tabPageMain.SelectedTextColor = Color.Black;
            tabPageMain.ShowOuterBorders = false;
            tabPageMain.Size = new Size(1148, 682);
            tabPageMain.SizeMode = TabSizeMode.Fixed;
            tabPageMain.SquareColor = Color.DarkOrange;
            tabPageMain.TabCursor = Cursors.Hand;
            tabPageMain.TabIndex = 0;
            // 
            // tpEquipment
            // 
            tpEquipment.BackColor = Color.White;
            tpEquipment.Controls.Add(flowLayoutPanel1);
            tpEquipment.Location = new Point(174, 4);
            tpEquipment.Name = "tpEquipment";
            tpEquipment.Padding = new Padding(3);
            tpEquipment.Size = new Size(970, 674);
            tpEquipment.TabIndex = 0;
            tpEquipment.Text = "Equipamentos";
            // 
            // flowLayoutPanel1
            // 
            flowLayoutPanel1.AutoScroll = true;
            flowLayoutPanel1.Dock = DockStyle.Fill;
            flowLayoutPanel1.FlowDirection = FlowDirection.TopDown;
            flowLayoutPanel1.Location = new Point(3, 3);
            flowLayoutPanel1.Name = "flowLayoutPanel1";
            flowLayoutPanel1.Size = new Size(964, 668);
            flowLayoutPanel1.TabIndex = 0;
            // 
            // tpMyAds
            // 
            tpMyAds.BackColor = Color.White;
            tpMyAds.Controls.Add(btnCreateAd);
            tpMyAds.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            tpMyAds.Location = new Point(174, 4);
            tpMyAds.Name = "tpMyAds";
            tpMyAds.Size = new Size(970, 674);
            tpMyAds.TabIndex = 3;
            tpMyAds.Text = "Meus Anúncios";
            // 
            // btnCreateAd
            // 
            btnCreateAd.BackColor = Color.Transparent;
            btnCreateAd.BorderColor = Color.SaddleBrown;
            btnCreateAd.EnteredBorderColor = Color.SaddleBrown;
            btnCreateAd.EnteredColor = Color.Chocolate;
            btnCreateAd.Font = new Font("Lato", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnCreateAd.Image = null;
            btnCreateAd.ImageAlign = ContentAlignment.MiddleLeft;
            btnCreateAd.InactiveColor = Color.DarkOrange;
            btnCreateAd.Location = new Point(43, 33);
            btnCreateAd.Name = "btnCreateAd";
            btnCreateAd.PressedBorderColor = Color.SaddleBrown;
            btnCreateAd.PressedColor = Color.Chocolate;
            btnCreateAd.Size = new Size(274, 56);
            btnCreateAd.TabIndex = 0;
            btnCreateAd.Text = "Criar Novo Anúncio";
            btnCreateAd.TextAlignment = StringAlignment.Center;
            btnCreateAd.Click += btnCreateAd_Click;
            // 
            // tpProfile
            // 
            tpProfile.BackColor = Color.White;
            tpProfile.Controls.Add(gpBoxAddress);
            tpProfile.Controls.Add(gpBoxPersonalInfo);
            tpProfile.Location = new Point(174, 4);
            tpProfile.Name = "tpProfile";
            tpProfile.Padding = new Padding(3);
            tpProfile.Size = new Size(970, 674);
            tpProfile.TabIndex = 1;
            tpProfile.Text = "Perfil";
            // 
            // gpBoxAddress
            // 
            gpBoxAddress.BorderColor = Color.FromArgb(220, 223, 230);
            gpBoxAddress.Controls.Add(lblComplement);
            gpBoxAddress.Controls.Add(lblState);
            gpBoxAddress.Controls.Add(lblNumber);
            gpBoxAddress.Controls.Add(btnEditAddress);
            gpBoxAddress.Controls.Add(lblPostalCode);
            gpBoxAddress.Controls.Add(lblCity);
            gpBoxAddress.Controls.Add(lblNeighborhood);
            gpBoxAddress.Controls.Add(lblStreet);
            gpBoxAddress.Font = new Font("Segoe UI", 12F);
            gpBoxAddress.ForeColor = Color.FromArgb(48, 49, 51);
            gpBoxAddress.LineColor = Color.FromArgb(220, 223, 230);
            gpBoxAddress.Location = new Point(51, 361);
            gpBoxAddress.Name = "gpBoxAddress";
            gpBoxAddress.ShowText = false;
            gpBoxAddress.Size = new Size(878, 288);
            gpBoxAddress.TabIndex = 6;
            gpBoxAddress.TabStop = false;
            gpBoxAddress.Text = "hopeGroupBox1";
            gpBoxAddress.ThemeColor = Color.White;
            // 
            // lblComplement
            // 
            lblComplement.AutoSize = true;
            lblComplement.BackColor = Color.Transparent;
            lblComplement.Font = new Font("Lato", 12F);
            lblComplement.ForeColor = Color.Black;
            lblComplement.Location = new Point(25, 173);
            lblComplement.Name = "lblComplement";
            lblComplement.Size = new Size(138, 24);
            lblComplement.TabIndex = 8;
            lblComplement.Text = "Complemento:";
            // 
            // lblState
            // 
            lblState.AutoSize = true;
            lblState.BackColor = Color.Transparent;
            lblState.Font = new Font("Lato", 12F);
            lblState.ForeColor = Color.Black;
            lblState.Location = new Point(492, 71);
            lblState.Name = "lblState";
            lblState.Size = new Size(75, 24);
            lblState.TabIndex = 7;
            lblState.Text = "Estado:";
            // 
            // lblNumber
            // 
            lblNumber.AutoSize = true;
            lblNumber.BackColor = Color.Transparent;
            lblNumber.Font = new Font("Lato", 12F);
            lblNumber.ForeColor = Color.Black;
            lblNumber.Location = new Point(25, 71);
            lblNumber.Name = "lblNumber";
            lblNumber.Size = new Size(86, 24);
            lblNumber.TabIndex = 6;
            lblNumber.Text = "Número:";
            // 
            // btnEditAddress
            // 
            btnEditAddress.BackColor = Color.Transparent;
            btnEditAddress.BorderColor = Color.SaddleBrown;
            btnEditAddress.EnteredBorderColor = Color.SaddleBrown;
            btnEditAddress.EnteredColor = Color.Chocolate;
            btnEditAddress.Font = new Font("Lato", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditAddress.Image = null;
            btnEditAddress.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditAddress.InactiveColor = Color.DarkOrange;
            btnEditAddress.Location = new Point(25, 227);
            btnEditAddress.Name = "btnEditAddress";
            btnEditAddress.PressedBorderColor = Color.SaddleBrown;
            btnEditAddress.PressedColor = Color.Chocolate;
            btnEditAddress.Size = new Size(182, 45);
            btnEditAddress.TabIndex = 5;
            btnEditAddress.Text = "Editar Informações";
            btnEditAddress.TextAlignment = StringAlignment.Center;
            // 
            // lblPostalCode
            // 
            lblPostalCode.AutoSize = true;
            lblPostalCode.BackColor = Color.Transparent;
            lblPostalCode.Font = new Font("Lato", 12F);
            lblPostalCode.ForeColor = Color.Black;
            lblPostalCode.Location = new Point(492, 123);
            lblPostalCode.Name = "lblPostalCode";
            lblPostalCode.Size = new Size(52, 24);
            lblPostalCode.TabIndex = 4;
            lblPostalCode.Text = "CEP:";
            // 
            // lblCity
            // 
            lblCity.AutoSize = true;
            lblCity.BackColor = Color.Transparent;
            lblCity.Font = new Font("Lato", 12F);
            lblCity.ForeColor = Color.Black;
            lblCity.Location = new Point(492, 21);
            lblCity.Name = "lblCity";
            lblCity.Size = new Size(76, 24);
            lblCity.TabIndex = 3;
            lblCity.Text = "Cidade:";
            // 
            // lblNeighborhood
            // 
            lblNeighborhood.AutoSize = true;
            lblNeighborhood.BackColor = Color.Transparent;
            lblNeighborhood.Font = new Font("Lato", 12F);
            lblNeighborhood.ForeColor = Color.Black;
            lblNeighborhood.Location = new Point(25, 123);
            lblNeighborhood.Name = "lblNeighborhood";
            lblNeighborhood.Size = new Size(68, 24);
            lblNeighborhood.TabIndex = 2;
            lblNeighborhood.Text = "Bairro:";
            // 
            // lblStreet
            // 
            lblStreet.AutoSize = true;
            lblStreet.BackColor = Color.Transparent;
            lblStreet.Font = new Font("Lato", 12F);
            lblStreet.ForeColor = Color.Black;
            lblStreet.Location = new Point(25, 21);
            lblStreet.Name = "lblStreet";
            lblStreet.Size = new Size(49, 24);
            lblStreet.TabIndex = 0;
            lblStreet.Text = "Rua:";
            // 
            // gpBoxPersonalInfo
            // 
            gpBoxPersonalInfo.BorderColor = Color.FromArgb(220, 223, 230);
            gpBoxPersonalInfo.Controls.Add(btnEditPersonalInfo);
            gpBoxPersonalInfo.Controls.Add(lblPhone);
            gpBoxPersonalInfo.Controls.Add(lblDocument);
            gpBoxPersonalInfo.Controls.Add(lblEmail);
            gpBoxPersonalInfo.Controls.Add(pbProfilePicture);
            gpBoxPersonalInfo.Controls.Add(lblName);
            gpBoxPersonalInfo.Font = new Font("Segoe UI", 12F);
            gpBoxPersonalInfo.ForeColor = Color.FromArgb(48, 49, 51);
            gpBoxPersonalInfo.LineColor = Color.FromArgb(220, 223, 230);
            gpBoxPersonalInfo.Location = new Point(51, 53);
            gpBoxPersonalInfo.Name = "gpBoxPersonalInfo";
            gpBoxPersonalInfo.ShowText = false;
            gpBoxPersonalInfo.Size = new Size(878, 288);
            gpBoxPersonalInfo.TabIndex = 0;
            gpBoxPersonalInfo.TabStop = false;
            gpBoxPersonalInfo.Text = "hopeGroupBox1";
            gpBoxPersonalInfo.ThemeColor = Color.White;
            // 
            // btnEditPersonalInfo
            // 
            btnEditPersonalInfo.BackColor = Color.Transparent;
            btnEditPersonalInfo.BorderColor = Color.SaddleBrown;
            btnEditPersonalInfo.EnteredBorderColor = Color.SaddleBrown;
            btnEditPersonalInfo.EnteredColor = Color.Chocolate;
            btnEditPersonalInfo.Font = new Font("Lato", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnEditPersonalInfo.Image = null;
            btnEditPersonalInfo.ImageAlign = ContentAlignment.MiddleLeft;
            btnEditPersonalInfo.InactiveColor = Color.DarkOrange;
            btnEditPersonalInfo.Location = new Point(25, 227);
            btnEditPersonalInfo.Name = "btnEditPersonalInfo";
            btnEditPersonalInfo.PressedBorderColor = Color.SaddleBrown;
            btnEditPersonalInfo.PressedColor = Color.Chocolate;
            btnEditPersonalInfo.Size = new Size(182, 45);
            btnEditPersonalInfo.TabIndex = 5;
            btnEditPersonalInfo.Text = "Editar Informações";
            btnEditPersonalInfo.TextAlignment = StringAlignment.Center;
            // 
            // lblPhone
            // 
            lblPhone.AutoSize = true;
            lblPhone.BackColor = Color.Transparent;
            lblPhone.Font = new Font("Lato", 12F);
            lblPhone.ForeColor = Color.Black;
            lblPhone.Location = new Point(230, 181);
            lblPhone.Name = "lblPhone";
            lblPhone.Size = new Size(92, 24);
            lblPhone.TabIndex = 4;
            lblPhone.Text = "Telefone:";
            // 
            // lblDocument
            // 
            lblDocument.AutoSize = true;
            lblDocument.BackColor = Color.Transparent;
            lblDocument.Font = new Font("Lato", 12F);
            lblDocument.ForeColor = Color.Black;
            lblDocument.Location = new Point(230, 128);
            lblDocument.Name = "lblDocument";
            lblDocument.Size = new Size(51, 24);
            lblDocument.TabIndex = 3;
            lblDocument.Text = "CPF:";
            // 
            // lblEmail
            // 
            lblEmail.AutoSize = true;
            lblEmail.BackColor = Color.Transparent;
            lblEmail.Font = new Font("Lato", 12F);
            lblEmail.ForeColor = Color.Black;
            lblEmail.Location = new Point(230, 73);
            lblEmail.Name = "lblEmail";
            lblEmail.Size = new Size(63, 24);
            lblEmail.TabIndex = 2;
            lblEmail.Text = "Email:";
            // 
            // pbProfilePicture
            // 
            pbProfilePicture.BackColor = Color.FromArgb(192, 196, 204);
            pbProfilePicture.Location = new Point(25, 23);
            pbProfilePicture.Name = "pbProfilePicture";
            pbProfilePicture.PixelOffsetType = System.Drawing.Drawing2D.PixelOffsetMode.HighQuality;
            pbProfilePicture.Size = new Size(182, 182);
            pbProfilePicture.SmoothingType = System.Drawing.Drawing2D.SmoothingMode.HighQuality;
            pbProfilePicture.TabIndex = 1;
            pbProfilePicture.TabStop = false;
            pbProfilePicture.TextRenderingType = System.Drawing.Text.TextRenderingHint.ClearTypeGridFit;
            // 
            // lblName
            // 
            lblName.AutoSize = true;
            lblName.BackColor = Color.Transparent;
            lblName.Font = new Font("Lato", 12F);
            lblName.ForeColor = Color.Black;
            lblName.Location = new Point(230, 23);
            lblName.Name = "lblName";
            lblName.Size = new Size(158, 24);
            lblName.TabIndex = 0;
            lblName.Text = "Nome Completo:";
            // 
            // MainForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BorderColor = Color.Transparent;
            ClientSize = new Size(1152, 720);
            Controls.Add(tabPageMain);
            HeaderColor = Color.Gray;
            MaximizeBox = false;
            Name = "MainForm";
            Text = "TocaAi";
            Load += MainForm_Load;
            tabPageMain.ResumeLayout(false);
            tpEquipment.ResumeLayout(false);
            tpMyAds.ResumeLayout(false);
            tpProfile.ResumeLayout(false);
            gpBoxAddress.ResumeLayout(false);
            gpBoxAddress.PerformLayout();
            gpBoxPersonalInfo.ResumeLayout(false);
            gpBoxPersonalInfo.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)pbProfilePicture).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private ReaLTaiizor.Controls.AirTabPage tabPageMain;
        private TabPage tpEquipment;
        private TabPage tpProfile;
        private ReaLTaiizor.Controls.HopeGroupBox gpBoxPersonalInfo;
        private ReaLTaiizor.Controls.LabelEdit lblName;
        private ReaLTaiizor.Controls.HopePictureBox pbProfilePicture;
        private ReaLTaiizor.Controls.LabelEdit lblPhone;
        private ReaLTaiizor.Controls.LabelEdit lblDocument;
        private ReaLTaiizor.Controls.LabelEdit lblEmail;
        private ReaLTaiizor.Controls.Button btnEditPersonalInfo;
        private ReaLTaiizor.Controls.HopeGroupBox gpBoxAddress;
        private ReaLTaiizor.Controls.Button btnEditAddress;
        private ReaLTaiizor.Controls.LabelEdit lblPostalCode;
        private ReaLTaiizor.Controls.LabelEdit lblCity;
        private ReaLTaiizor.Controls.LabelEdit lblNeighborhood;
        private ReaLTaiizor.Controls.LabelEdit lblStreet;
        private ReaLTaiizor.Controls.LabelEdit lblComplement;
        private ReaLTaiizor.Controls.LabelEdit lblState;
        private ReaLTaiizor.Controls.LabelEdit lblNumber;
        private FlowLayoutPanel flowLayoutPanel1;
        private TabPage tpMyAds;
        private ReaLTaiizor.Controls.Button btnCreateAd;
    }
}