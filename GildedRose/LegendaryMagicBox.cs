using System;
using System.Runtime.InteropServices;

namespace GildedRoseKata;

public class LegendaryMagicBox : IMagicBox
{
    private readonly String _name;
    private readonly int _initialQuality;
    private readonly int _initialSellIn;
    public LegendaryMagicBox(Item item)
    {
        _name = item.Name;
        _initialQuality = item.Quality;
        _initialSellIn = item.SellIn;
    }

    public Item GetItem()
    {
        return new Item() { Name = _name, Quality = _initialQuality, SellIn = _initialSellIn};
    }

    public string GetStringForDay(int day)
    {
       return $"{_name}, {_initialSellIn}, {_initialQuality}";
    }
}