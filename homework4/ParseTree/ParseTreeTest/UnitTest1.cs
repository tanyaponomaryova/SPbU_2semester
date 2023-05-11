namespace ParseTreeTest;

public class Tests
{
    [TestCase("(+ 1 (* 4 5))", 21)]
    [TestCase("(+ -12 (/ 9 3))", -9)]
    [TestCase("(/ 20 (* 2 (+ 8 2)))", 1)]
    [TestCase("(* 3 (* 4 5))", 60)]
    public void ValidExpressionShouldReturnExpectedResult(string expression, float expectedResult)
    {
        var parseTree = new ParseTree.ParseTree(expression);
        var resultOfCalculation = parseTree.Calculate();
        Assert.True(Math.Abs(expectedResult - resultOfCalculation) < 1e-9);
    }

    [TestCase("(/ 3 ( - 4 4))")]
    [TestCase("(/ 2 0)")]
    public void DivisionByZeroShouldThrowDivideByZeroException(string expression)
    {
        var parseTree = new ParseTree.ParseTree(expression);
        Assert.Throws<DivideByZeroException>(() => parseTree.Calculate());
    }

    [TestCase("(/ 3 (- 4.6 4))")]
    [TestCase("(/ $$ (- 4.6 4))")]
    public void InvalidSymbolsInExpressionShouldThrowArgumentException(string expression)
    {
        Assert.Throws<ArgumentException>(() => new ParseTree.ParseTree(expression));
    }

    [TestCase("(+ 3 (- 4))")]
    [TestCase("(*)")]
    [TestCase("")]
    public void NotFullExpressionShouldThrowArgumentException(string expression)
    {
        Assert.Throws<ArgumentException>(() => new ParseTree.ParseTree(expression));
    }

    [TestCase("(+ 2 (* 5 4) 5)")]
    [TestCase("(+ 2 (* 5 4) * 9)")]
    public void ExpressionContainsExcessiveTokensShouldThrowArgumentException(string expression)
    {
        Assert.Throws<ArgumentException>(() => new ParseTree.ParseTree(expression));
    }
}