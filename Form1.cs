namespace hesap_makinesi
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void n0_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "0";
            }
            else
            {
                textBox1.Text = textBox1.Text + "0";
            }
        }

        private void n1_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "1";
            }
            else
            {
                textBox1.Text = textBox1.Text + "1";
            }
        }

        private void n2_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "2";
            }
            else
            {
                textBox1.Text = textBox1.Text + "2";
            }
        }

        private void n3_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "3";
            }
            else
            {
                textBox1.Text = textBox1.Text + "3";
            }
        }

        private void n4_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "4";
            }
            else
            {
                textBox1.Text = textBox1.Text + "4";
            }
        }

        private void n5_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "5";
            }
            else
            {
                textBox1.Text = textBox1.Text + "5";
            }
        }

        private void n6_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "6";
            }
            else
            {
                textBox1.Text = textBox1.Text + "6";
            }
        }

        private void n7_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "7";
            }
            else
            {
                textBox1.Text = textBox1.Text + "7";
            }
        }

        private void n8_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "8";
            }
            else
            {
                textBox1.Text = textBox1.Text + "8";
            }
        }

        private void n9_Click(object sender, EventArgs e)
        {
            if (textBox1.Text == "0" && textBox1.Text != null)
            {
                textBox1.Text = "9";
            }
            else
            {
                textBox1.Text = textBox1.Text + "9";
            }
        }

        private double FirstNumber;
        private double BackupNumber;
        private string Operation;

        private void bad_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "+";
        }

        private void bsub_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "-";
        }

        private void bmult_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "*";
        }

        private void bdiv_Click(object sender, EventArgs e)
        {
            textBox2.Text = textBox1.Text;
            FirstNumber = Convert.ToDouble(textBox1.Text);
            textBox1.Text = "0";
            Operation = "/";
        }

        private void ndot_Click(object sender, EventArgs e)
        {
            if (!textBox1.Text.Contains("."))
            {
                textBox1.Text += ".";
            }
        }

        private void bequal_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(Operation))
            {
                MessageBox.Show("Select an operation first");
                return;
            }

            double SecondNumber;
            double Result;

            SecondNumber = Convert.ToDouble(textBox1.Text);
            BackupNumber = FirstNumber;
            textBox2.Text = FirstNumber + Operation + Convert.ToString(SecondNumber);

            if (Operation == "+")
            {
                Result = FirstNumber + SecondNumber;
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            else if (Operation == "-")
            {
                Result = FirstNumber - SecondNumber;
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            else if (Operation == "*")
            {
                Result = FirstNumber * SecondNumber;
                textBox1.Text = Convert.ToString(Result);
                FirstNumber = Result;
            }
            else if (Operation == "/")
            {
                if (SecondNumber == 0)
                {
                    MessageBox.Show("Cannot divide by zero.");
                }
                else
                {
                    Result = FirstNumber / SecondNumber;
                    textBox1.Text = Convert.ToString(Result);
                    FirstNumber = Result;
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            textBox2.Text = "0";
            textBox1.Text = "0";
        }

        private void ndot_Click_1(object sender, EventArgs e)
        {
            textBox1.Text = textBox1.Text + ",";
        }

        private void button1_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Serhet Gökdemir\nMathematical Engineering @ yildiz");
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void bprc_Click(object sender, EventArgs e)
        {
            double prc = Convert.ToDouble(textBox1.Text) / 100;
            textBox1.Text = Convert.ToString(prc);
        }

        private void bce_Click(object sender, EventArgs e)
        {
            textBox1.Text = Convert.ToString(BackupNumber);
        }

        private void bsq_Click(object sender, EventArgs e)
        {
            double x = Convert.ToDouble(textBox1.Text);
            double sq = x * x;
            textBox1.Text = Convert.ToString(sq);
        }

        private void brev_Click(object sender, EventArgs e)
        {
            double brev = 1 / Convert.ToDouble(textBox1.Text);
            textBox1.Text = Convert.ToString(brev);
        }
    }
}
