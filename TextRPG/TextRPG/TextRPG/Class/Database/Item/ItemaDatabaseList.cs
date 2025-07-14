using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TextRPG.Class.Data;


namespace TextRPG.Class.Database.Item
{
    internal class ItemDatabaseList 
    {
        public static List<DefaultItem.Weapon> Weapons { get; } = new ()
        {
            new DefaultItem.Weapon("w1", "Wooden Sword", 0, 5, 10, "Wooden Sword"),
            new DefaultItem.Weapon("w2", "Iron Sword", 0, 10, 20, "Iron Sword"),
            new DefaultItem.Weapon("w3", "Steel Sword", 0, 15, 30, "Steel Sword"),
           
            
        };
        public static List<DefaultItem.Armor> Armors { get; } = new()
        {
            
            new DefaultItem.Armor("a1", "Mage Robe", 20, 0, 50, "Mage Robe"),
            new DefaultItem.Armor("a2", "Leather Armor", 5, 0, 10, "Leather Armor"),
            new DefaultItem.Armor("a3", "Iron Armor", 10, 0, 20, "Iron Armor"),
            new DefaultItem.Armor("a4", "Steel Armor", 15, 0, 30, "Steel Armor"),
        };

        public static DefaultItem? GetWeaponById(string weaponId)
        {
            return Weapons.Find(item => item.Id == weaponId);
        }
        public static DefaultItem? GetArmorById(string armorId)
        {
            return Armors.Find(item => item.Id == armorId);
        }
        

    }
}
