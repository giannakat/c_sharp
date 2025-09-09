namespace SimpleCalculator
{
    public partial class Calculator : Form
    {

        string currentInput = ""; //number
        double result = 0; 
        string operation = "";
        bool operationPending = false;
        bool justEvaluated = false;



        public Calculator()
        {
            InitializeComponent();
        }

        private void buttonDel(object sender, EventArgs e)
        {
            if (currentInput.Length > 0)
            {
                currentInput = currentInput.Substring(0, 
                    currentInput.Length - 1);
                textBox1.Text = currentInput;
            }
            else
            {
                textBox1.Text = "0";
            }
        }

        private void buttonModulo_Click(object sender, EventArgs e)
        {
            
            if(operationPending && currentInput == "")
            {
                operation = "%";
                return;
            }

            if (operationPending)
            {
                Evaluate();
            }

            if(currentInput == "")
            {
                return;
            }

            Button button = (Button)sender;
            operation = "%";
            result = double.Parse(currentInput);
            currentInput = "";
            operationPending = true;
        }

        private void buttonDivide_Click(object sender, EventArgs e)
        {
            if (operationPending && currentInput == "")
            {
                operation = "/";
                return;
            }

            if (operationPending)
            {
                Evaluate();
            }

            if (currentInput == "")
            {
                return;
            }


            Button button = (Button)sender;
            operation = "/";
            result = double.Parse(currentInput);
            currentInput = "";
            operationPending = true;
        }

        private void buttonMultiply_Click(object sender, EventArgs e)
        {
            if (operationPending && currentInput == "")
            {
                operation = "*";
                return;
            }

            if (operationPending)
            {
                Evaluate();
            }

            if (currentInput == "")
            {
                return;
            }


            Button button = (Button)sender;
            operation = "*";
            result = double.Parse(currentInput);
            currentInput = "";
            operationPending = true;
        }

        private void buttonMinus_Click(object sender, EventArgs e)
        {
            if (operationPending && currentInput == "")
            {
                operation = "-";
                return;
            }

            if (operationPending)
            {
                Evaluate();
            }

            if (currentInput == "")
            {
                return;
            }


            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(currentInput);
            currentInput = "";
            operationPending = true;
        }

        private void buttonPlus_Click(object sender, EventArgs e)
        {
            if (operationPending && currentInput == "")
            {
                operation = "+";
                return;
            }

            if (operationPending)
            {
                Evaluate();
            }

            if (currentInput == "")
            {
                return;
            }


            Button button = (Button)sender;
            operation = button.Text;
            result = double.Parse(currentInput);
            currentInput = "";
            operationPending = true;
        }

        private void buttonEquals_Click(object sender, EventArgs e)
        {

            if (operationPending && !string.IsNullOrEmpty(currentInput)) {
                Evaluate();
            }
            else if(!operationPending && !string.IsNullOrEmpty(currentInput))
            {
                textBox1.Text = currentInput;
            }
            else
            {
                textBox1.Text = "Error";   
            }

            
        }


        private void buttonDot_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            if (!currentInput.Contains("."))
            {
                if(currentInput == "")
                {
                    currentInput = "0";
                }
                currentInput += button.Text;
                textBox1.Text = currentInput;
            }
        }

        private void buttonAC_Click(object sender, EventArgs e)
        {
            textBox1.Text = "";
            operation = "";
            result = 0;
            currentInput = "";
            operationPending = false;
        }

        private void Evaluate()
        {
            if (operationPending)
            {
                double secondNumber = double.Parse(currentInput);

                switch(operation)
                {
                    case "+":
                        result += secondNumber;
                        break;
                    case "-":
                        result -= secondNumber;
                        break;
                    case "*":
                        result *= secondNumber;
                        break;
                    case "/":
                        if(secondNumber != 0)
                        {
                            result /= secondNumber;
                        }
                        else
                        {
                            textBox1.Text = "Error";
                            currentInput = "";
                            operation = "";
                            result = 0;
                            operationPending = false;
                            return;
                        }
                        break;
                    case "%":
                        result %= secondNumber;
                        break;
                }

                textBox1.Text = result.ToString("0.##");
                currentInput = result.ToString("0.##");
                operationPending = false;
                justEvaluated = true;
            }
        }

        private void NumberButton_Click(object sender, EventArgs e)
        {
            Button button = (Button)sender;

            if (justEvaluated)
            {
                currentInput = "";
                textBox1.Text = "";      
                justEvaluated = false;   
            }

            currentInput += button.Text;
            textBox1.Text = currentInput;
        }

    }
}
