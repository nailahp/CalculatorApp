namespace Calculator
{
    public partial class Calculator : Form
    {
        private double temp = 0;       // Menyimpan angka pertama
        private string operasi = "";   // Menyimpan jenis operasi yang dipilih
        private string stringDisplay = ""; // Menyimpan angka yang ditampilkan
        private bool iscalculatorOn = true;
        public Calculator()
        {
            InitializeComponent();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            stringDisplay += "1";
            textBoxDisplay.Text = stringDisplay;
        }

        private void button13_Click(object sender, EventArgs e)
        {
            stringDisplay += "6";
            textBoxDisplay.Text = stringDisplay;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            stringDisplay += "7";
            textBoxDisplay.Text = stringDisplay;
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            stringDisplay += "4";
            textBoxDisplay.Text = stringDisplay;
        }

        private void button8_Click(object sender, EventArgs e)
        {
            stringDisplay += "8";
            textBoxDisplay.Text = stringDisplay;
        }

        private void button5_Click(object sender, EventArgs e)
        {
            stringDisplay += "5";
            textBoxDisplay.Text = stringDisplay;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            stringDisplay += "2";
            textBoxDisplay.Text = stringDisplay;
        }

        private void button0_Click(object sender, EventArgs e)
        {
            stringDisplay += "0";
            textBoxDisplay.Text = stringDisplay;
        }

        private void button9_Click(object sender, EventArgs e)
        {
            stringDisplay += "9";
            textBoxDisplay.Text = stringDisplay;
        }

        private void button3_Click_1(object sender, EventArgs e)
        {
            stringDisplay += "3";
            textBoxDisplay.Text = stringDisplay;
        }

        private void Calculator_Load(object sender, EventArgs e)
        {

        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text != "")
            {
                temp = Convert.ToDouble(textBoxDisplay.Text); // Simpan angka yang ditampilkan
                operasi = "+"; // Menyimpan bahwa operasi yang dipilih adalah penjumlahan
                stringDisplay = ""; // Reset tampilan agar angka baru bisa dimasukkan
                textBoxDisplay.Text = ""; // Kosongkan TextBox
            }
        }
        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text != "")
            {
                temp = Convert.ToDouble(textBoxDisplay.Text);
                operasi = "-";
                stringDisplay = "";
                textBoxDisplay.Text = "";
            }
        }

        private void buttonTimes_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text != "")
            {
                temp = Convert.ToDouble(textBoxDisplay.Text);
                operasi = "*";
                stringDisplay = "";
                textBoxDisplay.Text = "";
            }
        }

        private void buttonDivided_Click(object sender, EventArgs e)
        {
            if (textBoxDisplay.Text != "")
            {
                temp = Convert.ToDouble(textBoxDisplay.Text);
                operasi = "/";
                stringDisplay = "";
                textBoxDisplay.Text = "";
            }
        }

        private void buttonEqual_Click(object sender, EventArgs e)
        {
            double hasil = 0.0;

            if (operasi == "+")
            {
                hasil = temp + Convert.ToDouble(textBoxDisplay.Text);
                stringDisplay = hasil.ToString();
                textBoxDisplay.Text = stringDisplay;
            }
            else if (operasi == "-")
            {
                hasil = temp - Convert.ToDouble(textBoxDisplay.Text);
                stringDisplay = hasil.ToString();
                textBoxDisplay.Text = stringDisplay;
            }
            else if (operasi == "*")
            {
                hasil = temp * Convert.ToDouble(textBoxDisplay.Text);
                stringDisplay = hasil.ToString();
                textBoxDisplay.Text = stringDisplay;
            }
            else if (operasi == "/")
            {
                double angkaKedua = Convert.ToDouble(textBoxDisplay.Text);
                if (angkaKedua != 0)
                {
                    hasil = temp / angkaKedua;
                    stringDisplay = hasil.ToString();
                    textBoxDisplay.Text = stringDisplay;
                }
                else
                {
                    textBoxDisplay.Text = "Error";
                }
            }
        }

        private void buttonOnOff_Click(object sender, EventArgs e)
        {
            iscalculatorOn = !iscalculatorOn;
            if (iscalculatorOn)
            {
                textBoxDisplay.Text = "Kalkulator ON";
                textBoxDisplay.Enabled = true;
            }
            else
            {
                textBoxDisplay.Text = "Kalkulator OFF";
                textBoxDisplay.Enabled = false;
                textBoxDisplay.Clear();
                operasi = "";
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            operasi = "";
            temp = 0;
            stringDisplay = "";
            textBoxDisplay.Text = stringDisplay;
        }

        private void buttonDel_Click(object sender, EventArgs e)
        {
            stringDisplay = stringDisplay.Substring(0, stringDisplay.Length - 1);
            textBoxDisplay.Text = stringDisplay;
        }

        private void buttonPlusMinus_Click(object sender, EventArgs e)
        {
            if (double.TryParse(textBoxDisplay.Text, out double currentvalue))
            {
                textBoxDisplay.Text = (-currentvalue).ToString();
            }
        }

        private void buttonDecimal_Click(object sender, EventArgs e)
        {
            stringDisplay = textBoxDisplay.Text;
            if (!stringDisplay.Contains("."))
            {
                stringDisplay += ".";
            }
            textBoxDisplay.Text = stringDisplay;
        }
    }
}
