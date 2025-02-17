using System.Globalization;

namespace Calculadora
{
    public partial class CalcForm : Form
    {
        public CalcForm()
        {
            InitializeComponent();
        }

        private decimal firstNumber = 0.0m;
        private decimal secondNumber = 0.0m;
        private decimal result = 0.0m;
        private int operatorType = (int)MathOperation.None;
        private bool isNewOperation = true;

        public enum MathOperation
        {
            None = 0,
            Plus = 1,
            Minus = 2,
            Multiply = 3,
            Divide = 4,
            Percentage = 5
        }

        private void CalcForm_Load(object sender, EventArgs e)
        {

        }

        private void NumberButtonClick(object sender, EventArgs e)
        {
            if (isNewOperation)
            {
                DisplayText.Text = "";
                isNewOperation = false;
            }

            Button button = sender as Button;
            if (button != null)
            {
                DisplayText.Text += button.Text;
            }
        }

        private void dotButton_Click(object sender, EventArgs e)
        {
            if (!DisplayText.Text.Contains("."))
            {
                if (DisplayText.Text == "")
                {
                    DisplayText.Text = DisplayText.Text + "0";
                }
                DisplayText.Text = DisplayText.Text + ".";
            }

        }

        private void signButton_Click(object sender, EventArgs e)
        {
            if (!DisplayText.Text.Contains("-"))
            {
                DisplayText.Text = "-" + DisplayText.Text;
            }
            else
            {
                DisplayText.Text = DisplayText.Text.Trim('-');
            }
        }

        private void OperatorButtonClick(object sender, EventArgs e)
        {
            if (!decimal.TryParse(DisplayText.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out secondNumber))
            {
                return;
            }
            
            if (operatorType != (int)MathOperation.None)
            {
                PerformCalculation();
            }
            else
            {
                firstNumber = secondNumber;
            }

            Button button = sender as Button;
            switch (button?.Text)
            {
                case "+":
                    operatorType = (int)MathOperation.Plus;
                    break;
                case "-":
                    operatorType = (int)MathOperation.Minus;
                    break;
                case "X":
                    operatorType = (int)MathOperation.Multiply;
                    break;
                case "/":
                    operatorType = (int)MathOperation.Divide;
                    break;
                case "%":
                    operatorType = (int)MathOperation.Percentage;
                    break;
            }
            isNewOperation = true;
        }

        private void equalButton_Click(object sender, EventArgs e)
        {
            if (!decimal.TryParse(DisplayText.Text, NumberStyles.Any, CultureInfo.InvariantCulture, out secondNumber))
            {
                return;
            }

            PerformCalculation();
            operatorType = (int)MathOperation.None;
            isNewOperation = true;
        }

        private void PerformCalculation()
        {
            switch (operatorType)
            {
                case (int)MathOperation.Plus:
                    result = firstNumber + secondNumber;
                    break;
                case (int)MathOperation.Minus:
                    result = firstNumber - secondNumber;
                    break;
                case (int)MathOperation.Multiply:
                    result = firstNumber * secondNumber;
                    break;
                case (int)MathOperation.Divide:
                    if (secondNumber == 0)
                    {
                        DisplayText.Text = "Erro: Divisão por zero";
                        return;
                    }
                    result = firstNumber / secondNumber;
                    break;
                case (int)MathOperation.Percentage:
                    result = (firstNumber / secondNumber) * 100;
                    break;
            }
            DisplayText.Text = result.ToString(CultureInfo.InvariantCulture);
            firstNumber = result;
        }

        private void ceButton_Click(object sender, EventArgs e)
        {
            DisplayText.Text = "";
        }

        private void cButton_Click(object sender, EventArgs e)
        {
            DisplayText.Text = "";
            firstNumber = 0.0m;
            secondNumber = 0.0m;
            result = 0.0m;
            operatorType = (int)MathOperation.None;
        }
    }
}
