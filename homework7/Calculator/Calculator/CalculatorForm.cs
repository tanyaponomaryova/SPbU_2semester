namespace Calculator
{
    public partial class CalculatorForm : Form
    {
        private CalculatorLogic calculatorLogic = new();

        public CalculatorForm()
        {
            InitializeComponent();

            expressionOnTopTextBox.DataBindings.Add(new Binding("Text", calculatorLogic, "ExpressionOnTop", false, DataSourceUpdateMode.OnPropertyChanged));
            displayTextBox.DataBindings.Add(new Binding("Text", calculatorLogic, "DisplayNumber", false, DataSourceUpdateMode.OnPropertyChanged));
        }

        public void NumberOrOperationButton_Click(object? sender, EventArgs e)
        {
            var senderButton = sender as Button;
            calculatorLogic.AddSymbol(senderButton!.Text[0]);
        }

        public void ClearButton_Click(object? sender, EventArgs e)
        {
            calculatorLogic.Clear();
        }

        private void ChangeSignButton_Click(object sender, EventArgs e)
        {
            calculatorLogic.ChangeSign();
        }

        private void SquareButton_Click(object sender, EventArgs e)
        {
            calculatorLogic.Square();
        }

        private void ReciprocalButton_Click(object sender, EventArgs e)
        {
            calculatorLogic.Reciprocal();
        }

        private void EqualButton_Click(object sender, EventArgs e)
        {
            calculatorLogic.EqualitySign();
        }
    }
}