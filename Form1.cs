namespace Bank
{
    public partial class Form1 : Form
    {
        
        Account account = new Account();
        Currency[] currencies = new Currency[3];
        
        
        public Form1()
        {
            currencies[0] = new Currency("RUB", 1.0);
            currencies[1] = new Currency("SGD", 52.98);
            currencies[2] = new Currency("SEK", 81.80);
            InitializeComponent();
            label5.Text = account.Print().ToString();
            comboBox1.SelectedIndex = 0;
            comboBox1.DropDownStyle = ComboBoxStyle.DropDownList;
            comboBox2.SelectedIndex = 0;
            comboBox2.DropDownStyle = ComboBoxStyle.DropDownList;
        }
        private void button2_Click(object sender, EventArgs e)
        {
            double sum = double.Parse(textBox2.Text);
            string s = comboBox2.Text;
            switch (s)
            {
                case "RUB":
                    account.Credit(currencies[0].ConvertToRUB(sum));
                    break;
                case "SGD":
                    account.Credit(currencies[1].ConvertToSGD(sum));
                    break;
                case "SEK":
                    account.Credit(currencies[2].ConvertToSEK(sum));
                    break;
            } 
            label5.Text = account.Print().ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double sum = double.Parse(textBox2.Text);
            string s = comboBox2.Text;
            switch (s)
            {
                case "RUB":
                    account.Withdraw(currencies[0].ConvertToRUB(sum));
                    break;
                case "SGD":
                    account.Withdraw(currencies[1].ConvertToSGD(sum));
                    break;
                case "SEK":
                    account.Withdraw(currencies[2].ConvertToSEK(sum));
                    break;
            }
            label5.Text= account.Print().ToString();
        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string s = comboBox1.Text;
            switch (s)
            {
                case "SGD":
                    label5.Text = currencies[1].ConvertToSGD(account.Print()).ToString();
                    break;
                case "SEK":
                    label5.Text = currencies[2].ConvertToSEK(account.Print()).ToString();
                    break;
                case "RUB":
                    label5.Text = currencies[0].ConvertToRUB(account.Print()).ToString();
                    break;
            }
        }
    }
    
}
