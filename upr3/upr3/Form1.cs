namespace upr3
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {


        }

        private void button1_Click(object sender, EventArgs e)
        {
            double stranaA = double.Parse(textBox1.Text);
            double stranaB = double.Parse(textBox2.Text);
            double stranaC = double.Parse(textBox3.Text);

            if (radioButton3.Checked)
            {
                double resultP = stranaA + stranaB + stranaC;
                label4.Text = "P= " + resultP;
                double resultS = (stranaA * stranaB) / 2;
                label5.Text = "S= " + resultS;
            }
            if (radioButton2.Checked)
            {
                double resultP = 2 * (stranaA + stranaB);
                label4.Text = "P= " + resultP;
                double resultS = stranaA * stranaB;
                label5.Text = "S= " + resultS;
            }
            if (radioButton1.Checked)
            {
                double resultP = 4 * stranaA;
                label4.Text = "P= " + resultP;
                double resultS = stranaA * stranaA;
                label5.Text = "S= " + resultS;
            }
           
        }
    }
}
