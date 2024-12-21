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
        String option;
        int result;

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button16_Click(object sender, EventArgs e)
        {
            num2 = int.Parse(textDisplay.Text);

            if (option.Equals("+"))
                result = num1 + num2;

            if (option.Equals("-"))
                result = num1 - num2;

            if (option.Equals("*"))
                result = num1 * num2;

            if (option.Equals("/"))
                result = num1 / num2;

            textDisplay.Text = result + "";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + "1";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + "2";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + "3";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + "6";
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + "7";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + "9";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textDisplay.Text = textDisplay.Text + "0";
        }

        private void btnPlus_Click(object sender, EventArgs e)
        {
            option = "+";
            num1 = int.Parse(textDisplay.Text);

            textDisplay.Clear();
        }

        private void btnMin_Click(object sender, EventArgs e)
        {
            option = "-";
            num1 = int.Parse(textDisplay.Text);

            textDisplay.Clear();
        }

        private void btnMul_Click(object sender, EventArgs e)
        {
            option = "*";
            num1 = int.Parse(textDisplay.Text);

            textDisplay.Clear();
        }

        private void btnDiv_Click(object sender, EventArgs e)
        {
            option = "/";
            num1 = int.Parse(textDisplay.Text);

            textDisplay.Clear();
        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            textDisplay.Clear();
            result = (0);
            num1 = (0);
            num2 = (0);
        }
    }
}
