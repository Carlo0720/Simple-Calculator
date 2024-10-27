namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        string CalTotal;
        int num1;
        int num2;
        string option;
        int result;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btn_0_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = TxtDisplay.Text + btn_0.Text;
        }

        private void btn_1_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = TxtDisplay.Text + btn_1.Text;
        }


        private void btn_2_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = TxtDisplay.Text + btn_2.Text;
        }

        private void btn_3_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = TxtDisplay.Text + btn_3.Text;
        }

        private void btn_4_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = TxtDisplay.Text + btn_4.Text;
        }

        private void btn_5_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = TxtDisplay.Text + btn_5.Text;
        }

        private void btn_6_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = TxtDisplay.Text + btn_6.Text;
        }

        private void btn_7_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = TxtDisplay.Text + btn_7.Text;
        }

        private void btn_8_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = TxtDisplay.Text + btn_8.Text;
        }

        private void btn_9_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = TxtDisplay.Text + btn_9.Text;
        }

        private void clear_btn_Click(object sender, EventArgs e)
        {
            TxtDisplay.Text = null;
        }

        private void plus_btn_Click(object sender, EventArgs e)
        {
            option = "+";

            num1 = int.Parse(TxtDisplay.Text);

            TxtDisplay.Clear();
        }

        private void minus_btn_Click(object sender, EventArgs e)
        {
            option = "-";

            num1 = int.Parse(TxtDisplay.Text);

            TxtDisplay.Clear();
        }

        private void divide_btn_Click(object sender, EventArgs e)
        {
            option = "/";

            num1 = int.Parse(TxtDisplay.Text);

            TxtDisplay.Clear();
        }

        private void multiply_btn_Click(object sender, EventArgs e)
        {
            option = "*";

            num1 = int.Parse(TxtDisplay.Text);

            TxtDisplay.Clear();
        }

        private void equals_btn_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(TxtDisplay.Text);

            if (option == "+")
            {
                result = num1 + num2;
            }

            if (option == "-")
            {
                result = num1 - num2;
            }

            if (option == "*")
            {
                result = num1 * num2;
            }

            if (option == "/")
            {
                result = num1 / num2;
            }


            TxtDisplay.Text = result.ToString();
        }
    }


}