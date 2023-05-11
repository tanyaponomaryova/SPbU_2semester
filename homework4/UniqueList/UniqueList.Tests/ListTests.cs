namespace UniqueList.Tests;

using NUnit.Framework;

[TestFixture]
public class Tests
{
    public OrdinaryList list;

    [SetUp]
    public void Initialize()
    {
        list = new OrdinaryList();
    }

    [Test]
    public void AddByPositionTest()
    {
        Assert.IsTrue(list.Size == 0);
        list.AddByPosition(34, 0);
        Assert.IsTrue(list.Size == 1);
        list.AddByPosition(15, 0);
        Assert.IsTrue(list.Size == 2);
        list.AddByPosition(20, 0);
        Assert.IsTrue(list.Size == 3);
    }

    [Test]
    public void PositionOfTest()
    {
        list.AddByPosition(13, 0);
        list.AddByPosition(76, 1);
        list.AddByPosition(4, 2);
        Assert.IsTrue(list.PositionOf(13) == 0 && list.PositionOf(76) == 1 && list.PositionOf(4) == 2);
    }

    [Test]
    public void ContainsTest()
    {
        list.AddByPosition(9, 0);
        Assert.IsTrue(list.Contains(9));
        Assert.IsFalse(list.Contains(10));
    }

    [Test]
    public void RemoveByValueTest()
    {
        Assert.IsFalse(list.Contains(5));
        list.AddByPosition(5, 0);
        Assert.IsTrue(list.Contains(5));
        list.RemoveByValue(5);
        Assert.IsFalse(list.Contains(5));
        Assert.IsTrue(list.Size == 0);
    }

    [Test]
    public void RemoveByPositionTest()
    {
        for (var i = 0; i < 10; i++) list.AddByPosition(i, i);

        list.RemoveByPosition(6);
        Assert.IsFalse(list.Contains(6));
        list.RemoveByPosition(7);
        Assert.IsFalse(list.Contains(8));
        list.RemoveByPosition(0);
        Assert.IsFalse(list.Contains(0));
        Assert.IsTrue(list.Size == 7);
    }

    [Test]
    public void ChangeValueByPositionTest()
    {
        for (var i = 0; i < 10; i++) list.AddByPosition(i, i);

        Assert.IsTrue(list.Contains(9));
        list.ChangeValueByPosition(50, 9);
        Assert.IsFalse(list.Contains(9));
        Assert.IsTrue(list.PositionOf(50) == 9);
    }

    [Test]
    public void AddByInvalidPositionTest()
    {
        Assert.Throws<InvalidPositionException>(() => list.AddByPosition(90, 1));
        Assert.Throws<InvalidPositionException>(() => list.AddByPosition(90, -1));
    }

    [Test]
    public void RemoveByInvalidPositionTest()
    {
        Assert.Throws<InvalidPositionException>(() => list.RemoveByPosition(1));
        Assert.Throws<InvalidPositionException>(() => list.RemoveByPosition(-1));
        list.AddByPosition(12, 0);
        Assert.DoesNotThrow(() => list.RemoveByPosition(0));
    }

    [Test]
    public void ChangeValueByInvalidPositionTest()
    {
        Assert.Throws<InvalidPositionException>(() => list.ChangeValueByPosition(34, 1));
        Assert.Throws<InvalidPositionException>(() => list.ChangeValueByPosition(34, -1));
        list.AddByPosition(16, 0);
        Assert.DoesNotThrow(() => list.ChangeValueByPosition(34, 0));
    }

    [Test]
    public void RemoveNonExistingValueTest()
    {
        Assert.Throws<RemovingNonExistingValueException>(() => list.RemoveByValue(15));
        list.AddByPosition(15, 0);
        Assert.DoesNotThrow(() => list.RemoveByValue(15));
    }
}