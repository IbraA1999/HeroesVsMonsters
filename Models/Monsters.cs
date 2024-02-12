using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters.Models
{
    public class Monsters : Personnages
    {
        // Champs
        // private string _Name;

        // propriété

            


        //constructeur
        /*  public Monsters(int or, int cuir) { 

          }

          public Monsters(int Cuir)
          {

          }*/

        public Monsters(string name, string type) : base(name, type)
        {
            TrousseauOr();
            CuirPosseder();
            CreationPersonnage();
        } 


        //Méthode 


        public virtual void TrousseauOr()
        {
            
        }

         public virtual void CuirPosseder()
        {
            
        } 
    }
}
