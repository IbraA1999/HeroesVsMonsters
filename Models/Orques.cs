using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters.Models
{
    public class Orques : Monsters
    {


        public override int Force { get { return base.Force + 1; } }

        public override int Or { get; set; }


       




        public Orques(string name, string type) : base(name, type)
        {
            
        }

        public override void TrousseauOr()
        {
            Random rdnOr = new Random();
            int NumberOr = rdnOr.Next(1, 7);
            Or = NumberOr;
            // Console.WriteLine($"L'or de L'orque est de {Or} ");
        }


        public override void PersonnagesCaracteristiques()
        {
            Console.WriteLine($"Caractéristiques du {Name}");
            Console.WriteLine($"*****FORCE => {Force}");
            Console.WriteLine($"*ENDURANCE => {End}");
            Console.WriteLine($"********PV => {PV}");
            Console.WriteLine($"******Cuir => {Or}");
        }

    }
}
