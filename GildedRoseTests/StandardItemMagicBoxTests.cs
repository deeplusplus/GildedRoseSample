using GildedRoseKata;
using NUnit.Framework;

namespace GildedRoseTests;

public class StandardItemMagicBoxTests
{
    [TestCase(0, 10, 5)]
    [TestCase(1, 9, 4)]
    [TestCase(2, 8, 3)]
    public void QualityDegradesByOneBeforeAndOnSellIn(int day, int expectedSellIn, int expectedQuality)
    {
        Item testItem = new Item(){ Name = "Aged Mead", Quality = 5, SellIn = 10};
        IMagicBox standardMagicBox = new StandardMagicBox(testItem);
        
        Assert.That(standardMagicBox.GetStringForDay(day), Is.EqualTo($"{testItem.Name}, {expectedSellIn}, {expectedQuality}"));
    }

    [TestCase(0, 3, 10)]
    [TestCase(1, 2, 9)]
    [TestCase(2, 1, 8)]
    [TestCase(3, 0, 7)]
    [TestCase(4, -1, 5)]
    [TestCase(5, -2, 3)]
    public void QualityDegradesByTwoAfterSellIn(int day, int expectedSellIn, int expectedQuality)
    {
        Item testItem = new Item(){ Name = "Aged Mead", Quality = 10, SellIn = 3};
        IMagicBox standardMagicBox = new StandardMagicBox(testItem);
        
        Assert.That(standardMagicBox.GetStringForDay(day), Is.EqualTo($"{testItem.Name}, {expectedSellIn}, {expectedQuality}"));
    }

    [TestCase(0, 1, 3)]
    [TestCase(1, 0, 2)]
    [TestCase(2, -1, 0)]
    [TestCase(3, -2, 0)]
    [TestCase(4, -3, 0)]
    public void QualityNeverDegradesLowerThanZero(int day, int expectedSellIn, int expectedQuality)
    {
        Item testItem = new Item(){ Name = "Aged Mead", Quality = 3, SellIn = 1};
        IMagicBox standardMagicBox = new StandardMagicBox(testItem);
        
        Assert.That(standardMagicBox.GetStringForDay(day), Is.EqualTo($"{testItem.Name}, {expectedSellIn}, {expectedQuality}"));
    }
}