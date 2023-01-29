using System.Data.SqlClient;

namespace TipCalculator
{
    public partial class TipCalculator : Form
    {
        SqlConnection DBconnection = new SqlConnection(Properties.Settings.Default.con);
        public TipCalculator()
        {
            InitializeComponent();
        }

        private void btnHistory_Click(object sender, EventArgs e)
        {
            this.Hide();
            History history = new History();
            history.Show();
        }

        private void btnExit_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void TextBoxBill_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void TextBoxPerson_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
        }

        private void TextBoxTipPersent_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            int currentValue = 0;
            if (Int32.TryParse(TextBoxTipPersent.Text + e.KeyChar, out currentValue))
            {
                if (currentValue >= 101)
                {
                    e.Handled = true;
                }
            }

            // only allow one decimal point
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            TextBoxBill.Text = "0";
            TextBoxTipPersent.Text = "0";
            TextBoxPerson.Text = "1";
            labelBill.Text = "0";
            labelPerPersonTip.Text = "0";
            labelTotalBills.Text = "0";
            labelTotalTip.Text = "0";
            labelTotalPerson.Text = "0";
        }

        private void btnCalculate_Click(object sender, EventArgs e)
        {
            if (TextBoxBill.Text == "")
            {
                MessageBox.Show("Enter the Bill");
                TextBoxBill.Focus();
            }
            else if(TextBoxPerson.Text == "")
            {
                MessageBox.Show("Enter the Number of Person");
                TextBoxPerson.Focus();
            }
            else if (TextBoxTipPersent.Text == "")
            {
                MessageBox.Show("Enter the Tip Persentage");
                TextBoxTipPersent.Focus();
            }
            else
            {
                string time = DateTime.Now.ToString();
                double Bill = Convert.ToDouble(TextBoxBill.Text);
                double TipPersentage = Convert.ToDouble(TextBoxTipPersent.Text);
                int TotalPerson = Convert.ToInt32(TextBoxPerson.Text);
                double TotalTip, TotalBill, PerPersonTip;

                TotalTip = (TipPersentage / 100) * Bill;
                TotalBill = TotalTip + Bill;
                PerPersonTip = TotalBill / Convert.ToDouble(TotalPerson);

                labelBill.Text = Bill.ToString()+" $";
                labelPerPersonTip.Text = PerPersonTip.ToString("N2") + " $";
                labelTotalBills.Text = TotalBill.ToString() + " $";
                labelTotalTip.Text = TotalTip.ToString() + " $";
                labelTotalPerson.Text = TotalPerson.ToString() + " $";

                string HistorySaveQuery = "INSERT INTO tip_calculator_history " +
                    "(bill, tip_persentage, total_tip, total_bill, total_person, tip_per_person, bill_time) " +
                    "VALUES (" + Bill + ", " + TipPersentage + ", " + TotalTip + ", " + TotalBill + ", " + TotalPerson + ", " + PerPersonTip + ", '" + time + "')";
                DBconnection.Open();
                SqlCommand command = new SqlCommand(HistorySaveQuery, DBconnection);
                command.ExecuteNonQuery();
                DBconnection.Close();
            }            
        }
    }
}