using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Trpo_2_laba
{
    public class Water
    {
        public string Name { get; set; }
        public double Volume { get; set; }

        public int Price { get; set; }
        public Water(string name, double vol, int pr)
        {
            Name = name;
            Volume = vol;
            Price = pr;
        }



    }
}
