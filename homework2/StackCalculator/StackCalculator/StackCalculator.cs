namespace StackCalculator;

using System;

/// <summary>
///     Class to make computing using stack.
/// </summary>
public static class StackCalculator
{
    /// <summary>
    ///     Calculates expression in postfix form.
    /// </summary>
    /// <param name="postfixExpression">input expression in postfix form.</param>
    /// <param name="stack"><see cref="IStack" /> implementation on which calculations are performed.</param>
    /// <returns>true and result of calculations if method completed the work correctly, else false and 0 as a result.</returns>
    public static (bool isPrefixExpressionCorrect, float result) Calculate(string postfixExpression, IStack stack)
    {
        stack.Clear();
        var arrayOfNumbersAndOperators = postfixExpression.Split();
        foreach (var current in arrayOfNumbersAndOperators)
        {
            if (float.TryParse(current, out var number))
            {
                stack.Push(number);
                continue;
            }

            switch (current)
            {
                case "+":
                case "-":
                case "*":
                case "/":
                    if (stack.IsEmpty())
                    {
                        return (false, 0);
                    }
                    var top = stack.Pop();
                    if (stack.IsEmpty() || (current == "/" && Math.Abs(top) < 1e-9))
                    {
                        return (false, 0);
                    }
                    stack.Push(top);
                    PerformOperation(current, stack);
                    break;
                default:
                    stack.Clear();
                    return (false, 0);
            }
        }

        var result = stack.Pop();
        if (stack.IsEmpty())
        {
            return (true, result);
        }
        stack.Clear();
        return (false, 0);
    }

    private static void PerformOperation(string operation, IStack stack)
    {
        var secondOperand = stack.Pop();
        var firstOperand = stack.Pop();
        switch (operation)
        {
            case "+":
                stack.Push(firstOperand + secondOperand);
                break;
            case "-":
                stack.Push(firstOperand - secondOperand);
                break;
            case "*":
                stack.Push(firstOperand * secondOperand);
                break;
            case "/":
                stack.Push(firstOperand / secondOperand);
                break;
        }
    }
}