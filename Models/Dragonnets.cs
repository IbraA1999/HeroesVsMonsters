using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters.Models
{
    public class Dragonnets : Monsters
    {
        // Champs


        // Propriété 
        public override int End { get { return base.End + 1; } }

        public override int Cuir { get; set; }
        public override int Or { get; set; }




        public Dragonnets(string name, string type) : base(name, type)
        {
            TrousseauOr();
            CuirPosseder();
        }




        public override void TrousseauOr()
        {
            Random rdnOr = new Random();
            int NumberOr = rdnOr.Next(1, 7);
            Or = NumberOr;
            // Console.WriteLine($"L'or du Dragonnets est de {Or} ");
        }

        public override void CuirPosseder()
        {
            Random rdnCuir = new Random();
            int NumberCuir = rdnCuir.Next(1, 5);
            Cuir = NumberCuir;
            // Console.WriteLine($"Le Dragonnets à : {Cuir} de cuir ");
        }

        public override void PersonnagesCaracteristiques()
        {
            Console.WriteLine($"Caractéristiques du {Name}");
            Console.WriteLine($"*****FORCE => {Force}");
            Console.WriteLine($"*ENDURANCE => {End}");
            Console.WriteLine($"********PV => {PV}");
            Console.WriteLine($"******Cuir => {Cuir}");
            Console.WriteLine($"********OR => {Or}");
        }

    }
}
