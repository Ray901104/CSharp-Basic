using System;
using System.Collections.Generic;

namespace CSharp
{
    enum ItemType
    {
        Weapon,
        Armor,
        Amulet,
        Ring
    }

    enum Rarity
    {
        Normal,
        Uncommon,
        Rare
    }
    
    class Item
    {
        public ItemType ItemType;
        public Rarity Rarity;
    }
    
    public class Lambda
    {
        static List<Item> items = new List<Item>();

        delegate Return MyFunc<T, Return>(T item);
        
        static Item FindItem(Func<Item, bool> itemSelector)
        {
            foreach (Item item in items)
            {
                if (itemSelector(item))
                    return item;
            }
            return null;
        }
        
        static void Main(string[] args)
        {
            items.Add(new Item(){ ItemType = ItemType.Weapon, Rarity = Rarity.Normal });
            items.Add(new Item(){ ItemType = ItemType.Armor, Rarity = Rarity.Uncommon });
            items.Add(new Item(){ ItemType = ItemType.Ring, Rarity = Rarity.Rare });
            
            // 익명 함수
            // Item item = FindItem(delegate (Item item1) { return item1.ItemType == ItemType.Weapon; });
            
            // delegate를 직접 선언하지 않아도, 이미 만들어진 애들이 존재한다.
            // 반환 타입이 있을 경우 Func
            // 반환 타입이 없을 경우 Action
            Func<Item, bool> selector = (Item item) => { return item.ItemType == ItemType.Weapon; };
            // 람다식 : 일회용 함수를 만드는데 사용하는 문법
            Item item1 = FindItem((Item item2) => { return item2.ItemType == ItemType.Weapon; });
        }
    }
}