namespace My_calculaa


{
    public partial class Form1 : Form
    {
        public string Operator = "";
        public double Operand = 0;
        public double result = 0;
        public bool PressedButton = false;

        public Form1()
        {
            InitializeComponent();
        }

        private void Multi_num(object sender, EventArgs e)
        {
            Button Btn = (Button)sender;

            if (Output_text.Text == "0" || PressedButton)
            {
                Output_text.Text = "";
                Output_text.Text = Output_text.Text + Btn.Text;
                PressedButton = false;
            }
            else
            {
                Output_text.Text += Btn.Text;
            }
        }

        private void Easy_operation(object sender, EventArgs e)
        {
            Button Btn = (Button)sender;

            Operator = Btn.Text;
            Operand = double.Parse(Output_text.Text);
            PressedButton = true;

            history_text.Text = Operand + " " + Operator;
        }

        private void Ravno(object sender, EventArgs e)
        {
            history_text.Text = "Ожидание ввода...";


            switch (Operator)
            {
                case "+":
                    result = Operand + double.Parse(Output_text.Text);
                    history_text.Text = Operand + " + " + double.Parse(Output_text.Text) + " = ";
                    Output_text.Text = result.ToString();
                    break;
                case "-":
                    result = Operand - double.Parse(Output_text.Text);
                    history_text.Text = Operand + " - " + double.Parse(Output_text.Text) + " = ";
                    Output_text.Text = result.ToString();
                    break;
                case "*":
                    result = Operand * double.Parse(Output_text.Text);
                    history_text.Text = Operand + " * " + double.Parse(Output_text.Text) + " = ";
                    Output_text.Text = result.ToString();
                    break;
                case "÷":
                    result = Operand / double.Parse(Output_text.Text);
                    history_text.Text = Operand + " ÷ " + double.Parse(Output_text.Text) + " = ";
                    Output_text.Text = result.ToString();
                    break;

            }
        }

        private void SqrtOperation(object sender, EventArgs e)
        {
            Operand = double.Parse(Output_text.Text);
            if (Operand < 0)
            {
                Output_text.Text = "Ошибка";
                return;
            }

            result = Math.Sqrt(Operand);
            history_text.Text = "√ " + Operand + " = ";
            Output_text.Text = result.ToString();

            PressedButton = true;

        }

        private void DegreeOperation(object sender, EventArgs e)
        {
            Operand = double.Parse(Output_text.Text);
            result = Math.Pow(Operand, 2);
            history_text.Text = Operand + "² = ";
            Output_text.Text = result.ToString();
        }

        private void UnarnMinOperation(object sender, EventArgs e)
        {
            Operand = double.Parse(Output_text.Text);
            result = Operand * (-1);
            Output_text.Text = result.ToString();
        }

        private void TochkaOperation(object sender, EventArgs e)
        {
            if (!Output_text.Text.Contains(","))
            {
                if (Output_text.Text == "0")
                {
                    Output_text.Text = "0";
                }
                else
                {
                    Output_text.Text += ",";
                }
            }
        }

        private void DrobOperation(object sender, EventArgs e)
        {
            Operand = double.Parse(Output_text.Text);
            result = 1 / Operand;
            history_text.Text = "1/" + Operand + " = ";
            Output_text.Text = result.ToString();
        }

        private void BackSpaceOperation(object sender, EventArgs e)
        {
            if (Output_text.Text.Length > 0)
            {
                Output_text.Text = Output_text.Text.Remove(Output_text.Text.Length - 1);
            }

        }

        private void ClearAllOperation(object sender, EventArgs e)
        {
            Output_text.Text = Output_text.Text.Remove(Output_text.Text.Length - Output_text.Text.Length);
            history_text.Text = history_text.Text.Remove(history_text.Text.Length - history_text.Text.Length);
        }

        private void ClearOperandOperation(object sender, EventArgs e)
        {
            Output_text.Text = Output_text.Text.Remove(Output_text.Text.Length - Output_text.Text.Length);
        }

        private void ProcentOperation(object sender, EventArgs e)
        {

        }
    }
}
