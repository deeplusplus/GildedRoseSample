using System;

namespace GildedRoseKata;

public interface IMagicBox
{
    public Item GetItem();
    public String GetStringForDay(int day);
}