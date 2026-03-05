using System;
using System.Collections.Generic;
using System.ComponentModel;

namespace GildedRoseKata;

public class Program
{
    public static void Main(string[] args)
    {
        Console.WriteLine("OMGHAI!");

        IList<IMagicBox> magicBoxes = new List<IMagicBox>
        {
            new StandardMagicBox(new Item {Name = "+5 Dexterity Vest", SellIn = 10, Quality = 20}),
            new LegacyMagicBox(new Item {Name = "Aged Brie", SellIn = 2, Quality = 0}),
            new StandardMagicBox(new Item {Name = "Elixir of the Mongoose", SellIn = 5, Quality = 7}),
            new LegendaryMagicBox(new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = 0, Quality = 80}),
            new LegendaryMagicBox(new Item {Name = "Sulfuras, Hand of Ragnaros", SellIn = -1, Quality = 80}),
            new LegacyMagicBox(new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 15,
                Quality = 20
            }),
            new LegacyMagicBox(new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 10,
                Quality = 49
            }),
            new LegacyMagicBox(new Item
            {
                Name = "Backstage passes to a TAFKAL80ETC concert",
                SellIn = 5,
                Quality = 49
            }),
            // this conjured item does not work properly yet
            new LegacyMagicBox(new Item {Name = "Conjured Mana Cake", SellIn = 3, Quality = 6})
        };

        int days = 2;
        if (args.Length > 0)
        {
            days = int.Parse(args[0]) + 1;
        }

        for (var day = 0; day < days; day++)
        {
            Console.WriteLine("-------- day " + day + " --------");
            Console.WriteLine("name, sellIn, quality");
            for (var magicBoxIndex = 0; magicBoxIndex < magicBoxes.Count; magicBoxIndex++)
            {
                Console.WriteLine(magicBoxes[magicBoxIndex].GetStringForDay(day));
                if(magicBoxIndex == 0 || magicBoxIndex == 2 || magicBoxIndex == 3 || magicBoxIndex == 4)
                    continue;
                magicBoxes[magicBoxIndex] = new LegacyMagicBox(GildedRose.UpdateQuality(magicBoxes[magicBoxIndex].GetItem()));
            }
            Console.WriteLine("");
        }
    }
}