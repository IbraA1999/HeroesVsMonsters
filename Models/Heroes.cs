using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters.Models
{
    public class Heroes : Personnages
    {

        // Champs




        public Heroes(string name, string type) : base(name, type)
        {
            CreationPersonnage();
            // this.PV = 150;

        } 


        public override void Looting(Personnages victime)
        {
            Cuir += victime.Cuir;
            Or += victime.Or;
        }

      /*  public virtual void Repos()
        {

             Modificateur(End);
        } */


        public override void PersonnagesCaracteristiques()
        {
            Console.WriteLine($"Caractéristiques de l'héros {Name}");
            Console.WriteLine($"*****FORCE => {Force}");
            Console.WriteLine($"*ENDURANCE => {End}");
            Console.WriteLine($"********PV => {PV}");
        }

    }
}
