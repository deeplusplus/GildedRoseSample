using GildedRoseKata;
using NUnit.Framework;
using NUnit.Framework.Internal.Commands;

namespace GildedRoseTests;

public class LegendaryItemMagicBoxesTests
{
    [Test]
    public void LegendaryItemsQualityAndSellInNeverChange()
    {
        Item testItem = new Item(){ Name = "The One Ring", Quality = 80, SellIn = -1};

        IMagicBox legendaryMagicBox = new LegendaryMagicBox(testItem);

        Assert.That(legendaryMagicBox.GetStringForDay(0), Is.EqualTo($"{testItem.Name}, {testItem.SellIn}, {testItem.Quality}"));
    }
}