namespace TocaAi.App.Pages
{
    partial class RentalDetailsForm
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
            dtpReturnDate = new ReaLTaiizor.Controls.PoisonDateTime();
            cboPaymentMethod = new ReaLTaiizor.Controls.HopeComboBox();
            btnConfirm = new ReaLTaiizor.Controls.Button();
            labelEdit2 = new ReaLTaiizor.Controls.LabelEdit();
            labelEdit1 = new ReaLTaiizor.Controls.LabelEdit();
            SuspendLayout();
            // 
            // dtpReturnDate
            // 
            dtpReturnDate.Font = new Font("Segoe UI", 14F, FontStyle.Regular, GraphicsUnit.Pixel);
            dtpReturnDate.FontSize = ReaLTaiizor.Extension.Poison.PoisonDateTimeSize.Medium;
            dtpReturnDate.Location = new Point(264, 132);
            dtpReturnDate.MinimumSize = new Size(0, 30);
            dtpReturnDate.Name = "dtpReturnDate";
            dtpReturnDate.Size = new Size(281, 30);
            dtpReturnDate.TabIndex = 0;
            // 
            // cboPaymentMethod
            // 
            cboPaymentMethod.DrawMode = DrawMode.OwnerDrawFixed;
            cboPaymentMethod.FlatStyle = FlatStyle.Flat;
            cboPaymentMethod.Font = new Font("Segoe UI", 12F);
            cboPaymentMethod.FormattingEnabled = true;
            cboPaymentMethod.ItemHeight = 30;
            cboPaymentMethod.Location = new Point(264, 81);
            cboPaymentMethod.Name = "cboPaymentMethod";
            cboPaymentMethod.Size = new Size(281, 36);
            cboPaymentMethod.TabIndex = 1;
            // 
            // btnConfirm
            // 
            btnConfirm.BackColor = Color.Transparent;
            btnConfirm.BorderColor = Color.SaddleBrown;
            btnConfirm.EnteredBorderColor = Color.SaddleBrown;
            btnConfirm.EnteredColor = Color.Chocolate;
            btnConfirm.Font = new Font("Lato", 12F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnConfirm.Image = null;
            btnConfirm.ImageAlign = ContentAlignment.MiddleLeft;
            btnConfirm.InactiveColor = Color.DarkOrange;
            btnConfirm.Location = new Point(196, 195);
            btnConfirm.Name = "btnConfirm";
            btnConfirm.PressedBorderColor = Color.SaddleBrown;
            btnConfirm.PressedColor = Color.Chocolate;
            btnConfirm.Size = new Size(205, 40);
            btnConfirm.TabIndex = 4;
            btnConfirm.Text = "Confirmar";
            btnConfirm.TextAlignment = StringAlignment.Center;
            btnConfirm.Click += btnConfirm_Click;
            // 
            // labelEdit2
            // 
            labelEdit2.AutoSize = true;
            labelEdit2.BackColor = Color.Transparent;
            labelEdit2.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEdit2.ForeColor = Color.DimGray;
            labelEdit2.Location = new Point(63, 135);
            labelEdit2.Name = "labelEdit2";
            labelEdit2.Size = new Size(183, 24);
            labelEdit2.TabIndex = 5;
            labelEdit2.Text = "Data de Devolução:";
            // 
            // labelEdit1
            // 
            labelEdit1.AutoSize = true;
            labelEdit1.BackColor = Color.Transparent;
            labelEdit1.Font = new Font("Lato", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelEdit1.ForeColor = Color.DimGray;
            labelEdit1.Location = new Point(31, 87);
            labelEdit1.Name = "labelEdit1";
            labelEdit1.Size = new Size(215, 24);
            labelEdit1.TabIndex = 6;
            labelEdit1.Text = "Método de Pagamento:";
            // 
            // RentalDetailsForm
            // 
            AutoScaleDimensions = new SizeF(11F, 28F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.WhiteSmoke;
            BorderColor = Color.Transparent;
            ClientSize = new Size(596, 270);
            Controls.Add(labelEdit1);
            Controls.Add(labelEdit2);
            Controls.Add(btnConfirm);
            Controls.Add(cboPaymentMethod);
            Controls.Add(dtpReturnDate);
            HeaderColor = Color.Gray;
            Name = "RentalDetailsForm";
            Text = "TocaAi - Detalhes do Aluguel";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ReaLTaiizor.Controls.PoisonDateTime dtpReturnDate;
        private ReaLTaiizor.Controls.HopeComboBox cboPaymentMethod;
        private ReaLTaiizor.Controls.Button btnConfirm;
        private ReaLTaiizor.Controls.LabelEdit labelEdit2;
        private ReaLTaiizor.Controls.LabelEdit labelEdit1;
    }
}