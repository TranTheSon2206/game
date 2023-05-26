using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _26_5._1
{
    public class Consumale : GameItem
    {
        protected int ManaGain { get; set; }
        public Consumale(string name, int level, int score, int ManaGain) : base(name, level, score)
        {
            this.ManaGain = ManaGain;
        }
        public void manaGain() { Console.WriteLine("This item gain mana"); }

        public override string ToString()
        {
            return base.ToString() +"ManaGain: "+ManaGain;
        }
    }
}
