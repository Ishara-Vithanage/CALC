namespace CALC
{
    public partial class calcMain : Form
    {
        private string input = "";
        private double firstNumber, secondNumber;
        private char operation;

        public calcMain()
        {
            InitializeComponent();
        }

        private void NumberClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            input += button.Text;
            textBoxDisplay.Text = input;
        }

        private void OperatorClick(object sender, EventArgs e)
        {
            Button button = (Button)sender;
            firstNumber = double.Parse(input);
            operation = button.Text[0];
            input = "";
        }

        private void EqualClick(object sender, EventArgs e)
        {
            secondNumber = double.Parse(input);
            double result = 0;

            switch (operation)
            {
                case '+': result = firstNumber + secondNumber; break;
                case '-': result = firstNumber - secondNumber; break;
                case 'x': result = firstNumber * secondNumber; break;
                case '%': result = firstNumber * secondNumber; break;
                case '/': result = secondNumber != 0 ? firstNumber / secondNumber : 0; break;
            }

            textBoxDisplay.Text = result.ToString();
            input = result.ToString();
        }

        private void ClearClick(object sender, EventArgs e)
        {
            input = "";
            firstNumber = secondNumber = 0;
            textBoxDisplay.Text = "";
        }
    }
}