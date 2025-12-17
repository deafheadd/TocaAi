using ReaLTaiizor.Forms;

namespace TocaAi.App.Pages
{
    public partial class RentalDetailsForm : LostForm
    {
        public DateTime SelectedReturnDate { get; private set; }
        public PaymentMethod SelectedPaymentMethod { get; private set; }

        public RentalDetailsForm()
        {
            InitializeComponent();

            cboPaymentMethod.DataSource = Enum.GetValues(typeof(PaymentMethod));

            // data mínima de devolução
            dtpReturnDate.MinDate = DateTime.Now.AddDays(1);
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            DateTime selectedDate = dtpReturnDate.Value;

            // calculo quantos dias para exibir
            int totalDays = (selectedDate.Date - DateTime.Now.Date).Days;

            if (totalDays <= 0)
                totalDays = 1;

            DialogResult confirm = MessageBox.Show(
                $"Resumo do Aluguel:\n\n" +
                $"Data de devolução: {selectedDate.ToShortDateString()}\n" +
                $"Duração total: {totalDays} dia(s)\n" +
                $"Pagamento: {cboPaymentMethod.SelectedItem}\n\n" +
                $"Deseja confirmar?",
                "Confirmar Dados",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirm == DialogResult.Yes)
            {
                SelectedReturnDate = selectedDate;
                SelectedPaymentMethod = (PaymentMethod)cboPaymentMethod.SelectedItem;

                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }
    }
}
