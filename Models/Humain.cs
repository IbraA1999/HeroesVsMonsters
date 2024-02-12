using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters.Models
{
    class Humain : Heroes 
    {
        public override int Force { get { return base.Force + 1; } }

        public override  int End  { get { return base.End + 1;}}


        public Humain(string name, string type) : base(name, type)
        {
           
        }


 

    }
}

