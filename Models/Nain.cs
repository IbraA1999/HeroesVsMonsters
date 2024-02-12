using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters.Models
{
    public  class Nain : Heroes 
    {
        public override int End { get { return base.End + 2; } }



        public Nain(string name, string type) : base(name, type)
        {

        }
    }
}
