using GildedRoseKata;
using NUnit.Framework;

namespace GildedRoseTests;

public class TestLegacyMagicBoxTests
{
    [Test]
    public void LegacyMagicBoxesTakesAnItemAndProvidesACopy()
    {
        Item testItem = new Item() { Name = "Legacy item", Quality = 5, SellIn = 10};
        IMagicBox legacyMagicBox = new LegacyMagicBox(testItem);

        Assert.That(legacyMagicBox.GetItem().Name, Is.EqualTo(testItem.Name));
        Assert.That(legacyMagicBox.GetItem().SellIn, Is.EqualTo(testItem.SellIn));
        Assert.That(legacyMagicBox.GetItem().Quality, Is.EqualTo(testItem.Quality));
    }

    [Test]
    public void LegacyMagicBoxesProvideConsoleReadyStringsByDay()
    {
        Item testItem = new Item() { Name = "Legacy item", Quality = 5, SellIn = 10};
        IMagicBox legacyMagicBox = new LegacyMagicBox(testItem);

        Assert.That(legacyMagicBox.GetStringForDay(0), Is.EqualTo($"{testItem.Name}, {testItem.SellIn}, {testItem.Quality}"));
    }
}