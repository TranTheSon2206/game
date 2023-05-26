using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_5._1
{
    public class Armor : GameItem
    {
        protected string material { get; set; }
        public Armor(string name, int level, int score, string material) : base(name, level, score)
        {
            this.material = material;
        }
        public void Defence() { if (level >5) { Console.WriteLine("Defend all weapon!"); } else { Console.WriteLine("this Item defend from iron weapon! "); } }

        public override string ToString()
        {
            return base.ToString() + "Material: " + material;
        }
    }
}
