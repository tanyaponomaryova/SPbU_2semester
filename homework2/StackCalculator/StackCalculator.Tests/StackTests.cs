namespace StackCalculator.Tests;

using NUnit.Framework;

[TestFixture]
public class StackTests
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
    public void StackShouldSupportPushAndPop(IStack stack)
    {
        for (int i = 0; i < 10; i++)
        {
            stack.Push(i);
        }

        for (int i = 9; i >= 0; i--)
        {
            Assert.AreEqual(i, stack.Pop());
        }
    }

    [Test]
    [TestCaseSource(nameof(Stacks))]
    public void StackShouldBeInitiallyEmptyAndNotEmptyAfterPush(IStack stack)
    {
        Assert.IsTrue(stack.IsEmpty());
        stack.Push(1);
        Assert.IsFalse(stack.IsEmpty());
    }

    [Test]
    [TestCaseSource(nameof(Stacks))]
    public void StackShouldThrowExceptionIfPopWhenEmpty(IStack stack)
    {
        Assert.Throws<InvalidOperationException>(() => stack.Pop());
    }
}