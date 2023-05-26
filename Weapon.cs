using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_5._1
{
    public class Weapon : GameItem
    {
        protected string color { get; set; }
        public Weapon(string name, int level, int score, string color) : base(name, level, score)
        {
            this.color = color;
        }
        public void ItemColor() { if (level > 5) { color = "yellow";Console.WriteLine("this Item is legendary "); } }
    }
}