using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace HeroesVsMonsters.Models
{
    public class Loups : Monsters 
    {


        // propriété 

        public  override int Cuir { get; set; }




        public Loups(string name, string type) : base(name, type)
        {
            
        }


        public override void CuirPosseder()
        {
            Random rdnCuir = new Random();
            int NumberCuir = rdnCuir.Next(1, 5);
            Cuir = NumberCuir;
            // Console.WriteLine($"Le loup à : {Cuir} de cuir ");
        }

        public override void PersonnagesCaracteristiques()
        {
            Console.WriteLine($"Caractéristiques du {Name}");
            Console.WriteLine($"*****FORCE => {Force}");
            Console.WriteLine($"*ENDURANCE => {End}");
            Console.WriteLine($"********PV => {PV}");
            Console.WriteLine($"******Cuir => {Cuir}");
        }
    }
}
