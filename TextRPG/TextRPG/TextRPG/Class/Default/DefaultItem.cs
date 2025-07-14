using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TextRPG.Class.Data
{
    internal abstract class DefaultItem
    {
        public string Id { get; set; }
        public string Name { get; }
        public int PlusArmorPoint { get; }
        public int PlusStr { get; }
        public int Gold { get; }
        public string DropItem { get; }

        protected DefaultItem(string _id, string _name, int _plusArmorPoint, int _plusStr, int _gold, string _dropItem)
        {
            Id = _id;
            Name = _name;
            PlusArmorPoint = _plusArmorPoint;
            PlusStr = _plusStr;
            Gold = _gold;
            DropItem = _dropItem;
        }

        public class Weapon : DefaultItem
        {
            public Weapon(string _id, string _name, int _plusArmorPoint, int _plusStr, int _gold, string _dropItem)
                : base(_id, _name, _plusArmorPoint, _plusStr, _gold, _dropItem)
            {
            }
        }
        public class Armor : DefaultItem
        {
            public Armor(string _id, string _name, int _plusArmorPoint, int _plusStr, int _gold, string _dropItem)
                : base(_id, _name, _plusArmorPoint, _plusStr, _gold, _dropItem)
            {
            }
        }

    }
}
