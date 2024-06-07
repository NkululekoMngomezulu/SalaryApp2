namespace SalaryApp
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        /// <summary>
        /// Button event handler
        /// 
        /// 1.Parse Rate and Hours
        /// 2.Calculate overtime
        /// 3.Calculate Regular Pay
        /// 4.Total
        /// 5.Display
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button1_Click(object sender, EventArgs e)
        {
            double hourlyRate = 0;       // hourly rate
            int hours = 0;               // hours worked
            double overtimePay = 0;      // overtime pay
            double regularPay = 0;       // regular pay 
            double totalPay = 0;          // total pay
            int tempHours = 0;            // temp hour storage

            // Parse values
            if (int.TryParse(txtHours.Text, out hours))
            {
                // Parse hourly rate
                if (double.TryParse(txtRate.Text, out hourlyRate))
                {
                    tempHours = hours;

                    // Overtime Salary
                    if (tempHours > 40)
                    {
                        overtimePay = (1.5 * hourlyRate) * (tempHours - 40);
                        tempHours = 40;
                    }

                    // Regular Pay
                    regularPay = tempHours * hourlyRate;

                    // Total Pay
                    totalPay = overtimePay + regularPay;

                    // Now Display
                    txtHoursWorked.Text = hours.ToString();
                    txtRate.Text = hourlyRate.ToString("C02");
                    txtRegularPay.Text = regularPay.ToString("C02");
                    txtOvertime.Text = overtimePay.ToString("C02");
                    txtTotalPay.Text = totalPay.ToString("C02");

                    // Clear inputs
                    txtHours.Text = "";
                    txtRate.Text = "";

                    txtHours.Focus();

                }
            }
            else
            {
                MessageBox.Show("Invalid hours entered");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
