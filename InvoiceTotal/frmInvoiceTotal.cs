namespace InvoiceTotal
{
    public partial class frmInvoiceTotal : Form
    {
        public frmInvoiceTotal()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            decimal invoiceSubtotal = Convert.ToDecimal(txtSubtotal.Text);
            decimal discountPercent = 0m;

            if (invoiceSubtotal >= 500)
                discountPercent = .2m;
            else if (invoiceSubtotal >= 250)
                discountPercent = .15m;
            else if (invoiceSubtotal >= 100)
                discountPercent = .1m;

            decimal discountAmount = invoiceSubtotal * discountPercent;
            decimal total = invoiceSubtotal - discountAmount;

            txtDiscountPercent.Text = discountPercent.ToString("p1");
            txtDiscountAmount.Text = discountAmount.ToString("c");
            txtTotal.Text = total.ToString("c");

            txtSubtotal.Focus();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
