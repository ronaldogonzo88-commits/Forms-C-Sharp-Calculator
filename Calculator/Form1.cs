using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Calculator
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            btn0.Click += new EventHandler(this.btn0_Click);
            btn1.Click += new EventHandler(this.btn1_Click);
            btn2.Click += new EventHandler(this.btn2_Click);
            btn3.Click += new EventHandler(this.btn3_Click);
            btn4.Click += new EventHandler(this.btn4_Click);
            btn5.Click += new EventHandler(this.btn5_Click);
            btn6.Click += new EventHandler(this.btn6_Click);
            btn7.Click += new EventHandler(this.btn7_Click);
            btn8.Click += new EventHandler(this.btn8_Click);
            btn9.Click += new EventHandler(this.btn9_Click);
            btnComma.Click += new EventHandler(this.btnComma_Click);
            btnAdd.Click += new EventHandler(this.btnAdd_Click);
            btnSubtract.Click += new EventHandler(this.btnSubtract_Click);
            btnMultiply.Click += new EventHandler(this.btnMultiply_Click);
            btnDivide.Click += new EventHandler(this.btnDivide_Click);
            btnOpenBrackets.Click += new EventHandler(this.btnOpenBrackets_Click);
            btnCloseBracket.Click += new EventHandler(this.btnCloseBracket_Click);
            btnEqualTo.Click += new EventHandler(this.btnEqualTo_Click);
            btnClearAll.Click += new EventHandler(this.btnClearAll_Click);
            btnClearSingle.Click += new EventHandler(this.btnClearSingle_Click);
            btnSqureRoot.Click += new EventHandler(this.btnSqureRoot_Click);
            btnCubeRoot.Click += new EventHandler(this.btnCubeRoot_Click);
            btnSin.Click += new EventHandler(this.btnSin_Click);
            btnCos.Click += new EventHandler(this.btnCos_Click);
            btnTan.Click += new EventHandler(this.btnTan_Click);
        }

        private void btn7_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "7";
        }

        private void btnClearSingle_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Length > 0)
            {
                textBox.Text = textBox.Text.Substring(0, textBox.Text.Length - 1);
            }
        }

        private void btnAdd_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "+";
        }

        private void btnSubtract_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "-";
        }

        private void btnMultiply_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "*";
        }

        private void btnDivide_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "/";
        }

        private void btn8_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "8";
        }

        private void btn9_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "9";
        }

        private void btn4_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "4";
        }

        private void btn5_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "5";
        }

        private void btn6_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "6";
        }

        private void btn3_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "3";
        }

        private void btn2_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "2";
        }

        private void btn1_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "1";
        }

        private void btn0_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "0";
        }

        private void btnEqualTo_Click(object sender, EventArgs e)
        {
            if (textBox.Text.Contains("^"))
            {
                int pos = textBox.Text.IndexOf("^");
                double b = double.Parse(textBox.Text.Substring(0, pos));
                double p = double.Parse(textBox.Text.Substring(pos + 1));
                textBox.Text = "" + Math.Pow(b, p);
            }
            else if (textBox.Text != "")
            { 
                textBox.Text = Calc(textBox.Text);
            }
        }
        private string Calc(string text)
        {
            try
            {
                object result = new System.Data.DataTable().Compute(text, null);
                string answer = result.ToString();
                if (answer == "Inifinity" || answer == "-inifinity" || answer == "NaN")
                {
                    return "Error";
                }
                return answer;
            }
            catch
            {
                return "Error";
            }
        }

        private void btnOpenBrackets_Click(object sender, EventArgs e)
        {
            if (textBox.Text != "")
            {
                string last = textBox.Text.Substring(textBox.Text.Length -1);
                if ("0123456789.)".Contains(last))
                {
                    textBox.Text = textBox.Text + "*";
                }
            }
            textBox.Text = textBox.Text + "(";
        }

        private void btnCloseBracket_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + ")";
        }

        private void btnClearSingle_Click_1(object sender, EventArgs e)
        {

        }

        private void btnComma_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + ".";
        }

        private void btnClearAll_Click(object sender, EventArgs e)
        {
            textBox.Text = "";
        }

        private void btnSqureRoot_Click(object sender, EventArgs e)
        {
            string answer = Calc(textBox.Text);
            if (answer != "Error" && double.Parse(answer) >= 0)
            {
                textBox.Text = "" + Math.Sqrt(double.Parse(answer));
            }
            else
            {
                textBox.Text = "Error";
            }
        }

        private void btnCubeRoot_Click(object sender, EventArgs e)
        {
            string answer = Calc(textBox.Text);
            if (answer != "Error")
            {
                textBox.Text = "" + Math.Cbrt(double.Parse(answer));
            }
            else
            {
                textBox.Text = "Error";
            }
        }

        private void btnSin_Click(object sender, EventArgs e)
        {
            string answer = Calc(textBox.Text);
            if (answer != "Error")
            {
                textBox.Text = "" + Math.Round(Math.Sin(double.Parse(answer) * Math.PI / 180), 8);
            }
            else
            {
                textBox.Text = "Error";
            }
        }

        private void btnCos_Click(object sender, EventArgs e)
        {
            string answer = Calc(textBox.Text);
            if (answer != "Error")
            {
                textBox.Text = "" + Math.Round(Math.Cos(double.Parse(answer) * Math.PI / 180), 8);
            }
            else
            {
                textBox.Text = "Error";
            }
        }

        private void btnTan_Click(object sender, EventArgs e)
        {
            string answer = Calc(textBox.Text);
            if (answer != "Error")
            {
                textBox.Text = "" + Math.Round(Math.Tan(double.Parse(answer) * Math.PI / 180), 8);
            }
            else
            {
                textBox.Text = "Error";
            }
        }

        private void btnPower_Click(object sender, EventArgs e)
        {
            textBox.Text = textBox.Text + "^";
        }
    }
}
