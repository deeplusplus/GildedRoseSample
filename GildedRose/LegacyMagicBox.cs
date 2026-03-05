namespace GildedRoseKata;

public class LegacyMagicBox : IMagicBox
{
    private Item _item;

    public LegacyMagicBox(Item item)
    {
        _item = item;
    }

    public Item GetItem()
    {
        return new Item() { Name = _item.Name, Quality = _item.Quality, SellIn = _item.SellIn};
    }

    public string GetStringForDay(int day)
    {
        return $"{_item.Name}, {_item.SellIn}, {_item.Quality}";
    }
}