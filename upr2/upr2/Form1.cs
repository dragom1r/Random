namespace upr2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
           string num= textBox1.Text;
            if (num=="0")
            {
                label2.Text = "����";
            }
            else if (num == "1")
            {
                label2.Text = "����";
            }
            else if (num == "2")
            {
                label2.Text = "���";
            }
            else if (num == "3")
            {
                label2.Text = "���";
            }
            else if (num == "4")
            {
                label2.Text = "������";
            }
            else if (num == "5")
            {
                label2.Text = "���";
            }
            else if (num == "6")
            {
                label2.Text = "����";
            }
            else if (num == "7")
            {
                label2.Text = "�����";
            }
            else if (num == "8")
            {
                label2.Text = "����";
            }
            else if (num == "9")
            {
                label2.Text = "�����";
            }
            else
            {
                MessageBox.Show("Error!");
            }

        }
    }
}
