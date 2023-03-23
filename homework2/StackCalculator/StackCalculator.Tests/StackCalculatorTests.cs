namespace StackCalculator.Tests;

using NUnit.Framework;

[TestFixture]
public class StackCalculatorTests
{
    private static TestCaseData[] Stacks()
    {
        return new TestCaseData[]
        {
            new TestCaseData(new StackArray()),
            new TestCaseData(new StackList()),
        };
    }

    [Test]
    [TestCaseSource(nameof(Stacks))]
    public void CalculateCorrectPostfixExpression(IStack stack)
    {
        (bool isPrefixExpressionCorrect, float result) = StackCalculator.Calculate("12 3 - 4 + 2 / 5 *", stack);
        Assert.IsTrue(isPrefixExpressionCorrect);
        Assert.AreEqual(32.5f, result);
    }

    [Test]
    [TestCaseSource(nameof(Stacks))]
    public void CalculateIncorrectPostfixExpression(IStack stack)
    {
        (bool isPrefixExpressionCorrect, float result) = StackCalculator.Calculate("7 8 + -", stack);
        Assert.IsFalse(isPrefixExpressionCorrect);
        Assert.AreEqual(0, result);
    }
    
    [Test]
    [TestCaseSource(nameof(Stacks))]
    public void CalculatePostfixExpressionWithDivisionByZero(IStack stack)
    {
        (bool isPrefixExpressionCorrect, float result) = StackCalculator.Calculate("19 0 /", stack);
        Assert.IsFalse(isPrefixExpressionCorrect);
        Assert.AreEqual(0, result);
    }
}