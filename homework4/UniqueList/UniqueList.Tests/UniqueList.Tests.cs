namespace UniqueList.Tests;

using NUnit.Framework;

[TestFixture]
public class UniqueListTests
{
    private UniqueList list;

    [SetUp]
    public void Initialize()
    {
        list = new UniqueList();
    }

    [Test]
    public void AddDuplicateElementTest()
    {
        list.AddByPosition(12, 0);
        Assert.Throws<InvalidPositionException>(() => list.AddByPosition(57, 5));
        Assert.Throws<AddingExistingValueException>(() => list.AddByPosition(12, 0));
    }

    [Test]
    public void ChangeValueByPositionTest()
    {
        list.AddByPosition(13, 0);
        list.AddByPosition(49, 1);
        list.AddByPosition(1, 1);
        Assert.Throws<AddingExistingValueException>(() => list.ChangeValueByPosition(13, 1));
        Assert.DoesNotThrow(() => list.ChangeValueByPosition(16, 1));
    }
}