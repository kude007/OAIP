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
            history_text.Text = "ќжидание ввода...";


            switch (Operator)
            {
                case "+":
                    result = Operand + double.Parse(Output_text.Text);
                    history_text.Text = result.ToString();
                    break;
                case "-":
                    result = Operand + double.Parse(Output_text.Text);
                    history_text.Text = result.ToString();
                    break;

            }
        }
    }
}
