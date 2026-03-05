using System;

namespace GildedRoseKata;

public class StandardMagicBox : IMagicBox
{
    private readonly String _name;
    private readonly int _initialSellIn;
    private readonly int _initialQuality;

    public StandardMagicBox(Item item)
    {
        _name = item.Name;
        _initialSellIn = item.SellIn;
        _initialQuality = item.Quality;
    }

    public Item GetItem()
    {
        return new Item() { Name = _name, Quality = _initialQuality, SellIn = _initialSellIn};
    }

    public string GetStringForDay(int day)
    {
        int qualityToday;

        if(day <= _initialSellIn)
            qualityToday = _initialQuality - day;
        else
            qualityToday = (-2 * day) + _initialQuality + _initialSellIn;

        return $"{_name}, {_initialSellIn - day}, {Math.Max(qualityToday, 0)}";
    }
}