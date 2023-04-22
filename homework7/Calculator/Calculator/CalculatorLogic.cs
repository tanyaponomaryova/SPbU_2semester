using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace Calculator
{
    public class CalculatorLogic : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public void OnPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        private string expressionOnTop = "";
        public string ExpressionOnTop
        {
            get
            {
                return expressionOnTop;
            }
            set
            {
                expressionOnTop = value;
                OnPropertyChanged();
            }
        }

        private string displayNumber = "0";
        public string DisplayNumber
        {
            get
            {
                return displayNumber;
            }
            set
            {
                displayNumber = value;
                OnPropertyChanged();
            }
        }

        private string tempCalculationValue = "";
        private char operationSign = ' ';
        private char decimalPoint = ',';
        private string errorMessage = "Error";

        private enum State
        {
            NumberTyping,
            NumberCopiedToDisplay,
            EqualitySign,
            AfterPoint,
            Error
        }
        State currentState = State.NumberTyping;

        public void Clear()
        {
            DisplayNumber = "0";
            ExpressionOnTop = "";
            tempCalculationValue = "";
            operationSign = ' ';
            currentState = State.NumberTyping;
        }

        public void PerformArithmeticOperationWithDisplayAndTempValue(char operation)
        {
            if (operationSign == ' ')
            {
                ExpressionOnTop = DisplayNumber + " " + operation.ToString();
                tempCalculationValue = DisplayNumber;
                operationSign = operation;
                currentState = State.NumberCopiedToDisplay;
            }
            else
            {
                try
                {
                    var result = PerformArithmeticOperationWithStrings(tempCalculationValue, DisplayNumber, operationSign);
                    ExpressionOnTop = result.ToString() + operation.ToString();
                    tempCalculationValue = result.ToString();
                    DisplayNumber = result.ToString();
                    operationSign = operation;
                    currentState = State.NumberCopiedToDisplay;

                }
                catch
                {
                    Clear();
                    currentState = State.Error;
                    DisplayNumber = errorMessage;
                }
            }
        }

        public void EqualitySignPressed()
        {
            if (operationSign == ' ')
            {
                ExpressionOnTop = DisplayNumber + " =";
                currentState = State.EqualitySign;
            }
            else
            {
                try
                {
                    var result = PerformArithmeticOperationWithStrings(tempCalculationValue, DisplayNumber, operationSign);
                    ExpressionOnTop = tempCalculationValue + " " + operationSign + " " + DisplayNumber + " =";
                    DisplayNumber = result.ToString();
                    tempCalculationValue = result.ToString();
                    operationSign = ' ';
                    currentState = State.EqualitySign;
                }
                catch
                {
                    Clear();
                    currentState = State.Error;
                    DisplayNumber = errorMessage;
                }
            }
        }

        public void AddSymbol(char symbol)
        {
            switch (currentState)
            {
                case State.NumberTyping:
                    if (char.IsDigit(symbol))
                    {
                        if (DisplayNumber == "0")
                        {
                            DisplayNumber = symbol.ToString();
                        }
                        else
                        {
                            DisplayNumber += symbol.ToString();
                        }
                    }
                    else if (IsOperationSign(symbol))
                    {
                        PerformArithmeticOperationWithDisplayAndTempValue(symbol);

                    }
                    else if (symbol == decimalPoint)
                    {
                        DisplayNumber += symbol.ToString();
                        currentState = State.AfterPoint;
                    }
                    else if (symbol == '=')
                    {
                        EqualitySignPressed();
                    }
                    break;

                case State.NumberCopiedToDisplay:
                    if (char.IsDigit(symbol))
                    {
                        DisplayNumber = symbol.ToString();
                        currentState = State.NumberTyping;
                    }
                    else if (symbol == decimalPoint)
                    {
                        DisplayNumber = "0" + decimalPoint;
                        currentState = State.NumberTyping;
                    }
                    else if (IsOperationSign(symbol))
                    {
                        ExpressionOnTop = ExpressionOnTop.Substring(0, ExpressionOnTop.Length - 1) + symbol.ToString();
                        operationSign = symbol;
                    }
                    else if (symbol == '=')
                    {
                        EqualitySignPressed();
                    }
                    break;

                case State.AfterPoint:
                    if (char.IsDigit(symbol))
                    {
                        DisplayNumber += symbol.ToString();
                    }
                    else if (IsOperationSign(symbol))
                    {
                        PerformArithmeticOperationWithDisplayAndTempValue(symbol);
                    }
                    else if (symbol == '=')
                    {
                        EqualitySignPressed();
                    }
                    break;

                case State.EqualitySign:
                    if (char.IsDigit(symbol))
                    {
                        Clear();
                        DisplayNumber = symbol.ToString();
                        currentState = State.NumberTyping;
                    }
                    else if (symbol == decimalPoint)
                    {
                        DisplayNumber += decimalPoint;
                        currentState = State.AfterPoint;
                    }
                    else if (IsOperationSign(symbol))
                    {
                        ExpressionOnTop = DisplayNumber + " " + symbol.ToString();
                        tempCalculationValue = DisplayNumber;
                        operationSign = symbol;
                        currentState = State.NumberCopiedToDisplay;
                    }
                    else if (symbol == '=')
                    {
                        EqualitySignPressed();
                    }
                    break;

                case State.Error:
                    if (char.IsDigit(symbol))
                    {
                        DisplayNumber = symbol.ToString();
                        currentState = State.NumberTyping;
                    }
                    else if (symbol == decimalPoint)
                    {
                        DisplayNumber = "0" + decimalPoint;
                        currentState = State.NumberTyping;
                    }
                    break;
            }
        }

        public void ChangeSign()
        {
            if (currentState != State.Error && DisplayNumber != "0")
            {
                if (DisplayNumber[0] == '-')
                {
                    DisplayNumber = DisplayNumber.Substring(1);
                }
                else
                {
                    DisplayNumber = "-" + DisplayNumber;
                }
            }
        }

        public void Square()
        {
            if (currentState != State.Error)
            {
                ExpressionOnTop += " sqr(" + DisplayNumber + ")";
                DisplayNumber = PerformArithmeticOperationWithStrings(DisplayNumber, DisplayNumber, '*').ToString();
            }
        }

        public void Reciprocal()
        {
            if (currentState != State.Error)
            {
                try
                {
                    ExpressionOnTop += " 1/" + DisplayNumber;
                    DisplayNumber = PerformArithmeticOperationWithStrings("1", DisplayNumber, '/').ToString();
                }
                catch
                {
                    Clear();
                    currentState = State.Error;
                    DisplayNumber = errorMessage;
                }
            }
        }

        private bool IsOperationSign(char symbol)
            => symbol == '+' || symbol == '*' || symbol == '/' || symbol == '-';

        private float PerformArithmeticOperationWithStrings(string firstNumberString, string secondNumberString, char operation)
        {
            float.TryParse(firstNumberString, out float firstNumber);
            float.TryParse(secondNumberString, out float secondNumber);

            switch (operation)
            {
                case '+':
                    return firstNumber + secondNumber;
                case '-':
                    return firstNumber - secondNumber;
                case '*':
                    return firstNumber * secondNumber;
                default: // '/'
                    if (Math.Abs(secondNumber) < 1e-9)
                    {
                        throw new DivideByZeroException();
                    }
                    return firstNumber / secondNumber;
            }
        }
    }
}
