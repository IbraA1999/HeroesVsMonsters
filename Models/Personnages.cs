using HeroesVsMonsters.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Security;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters.Models
{

    public class Personnages : IJeux
    {

        //Champs

        private int _PV;

        public string Name { get; set; }
        public virtual int End { get; private set; }
        public virtual int Force { get; private set; }
        public int PV {


            get { return _PV; }



            private set 
            {
                if (value < 0)
                {
                    _PV = 0;
                }
                else
                {
                    _PV = value;    
                }

            } 
        }

        public virtual int Cuir { get; set; }

        public virtual int Or { get; set; }
        public string Type { get; set; }


        // Constructeur
        public Personnages(string name, string type)
        {

            this.Name = name;
            this.Type = type;
        }

        // Méthode
        public virtual void CreationPersonnage()
        {
            Random rnd = new Random();
            List<int> DerForce = new List<int>();
            List<int> DerEndurance = new List<int>();

            for (int i = 0; i < 4; i++)
            {
                int Number = rnd.Next(1, 7);
                DerForce.Add(Number);

                Number = rnd.Next(1, 7);
                DerEndurance.Add(Number);

            }

            DerForce.Sort();
            DerForce.Remove(0);
            int SommeForce = DerForce.Sum();
            DerEndurance.Sort();
            DerEndurance.Remove(0);
            int SommeEndurance = DerEndurance.Sum();
             /* Console.WriteLine("Somme de Force : " + SommeForce);
              Console.WriteLine("***************** ");
              Console.WriteLine("Somme de l'endurance : " + SommeEndurance); */

            Force = SommeForce;
            End = SommeEndurance;
            Modificateur(End);



           /* Console.WriteLine("Somme de Force APRES : " + Force);
             Console.WriteLine("***************** ");
             Console.WriteLine("Somme de l'endurance  APRES : " + End); */
            PersonnagesCaracteristiques();
        }

        public void  Modificateur(int Endurance)
        {


            if (Endurance > 15)
            {
                 PV = Endurance + 2;
                // Console.WriteLine("Bonus +2 au pv grâce a l'endurance donc il a " + PV + " de PV");
            }
            else if (Endurance > 10)
            {
                 PV = Endurance + 1;
                // Console.WriteLine("Bonus +1 au pv grâce a l'endurance donc il a " + PV + " de PV");
            }
            else if (Endurance > 5)
            {
                 PV = Endurance;
                //  Console.WriteLine("+0 au pv grâce a l'endurance donc il a" + PV + " de PV");
            }
            else
            {
                 PV = Endurance - 2;
                // Console.WriteLine("Malus -2 au pv a cause de l'endurance" + PV + " de PV");
            }


        }

        public int Modificateur( int EtSi, int Degat)
        {

            if (EtSi > 15)
            {
                return Degat += 2;
                
                // Console.WriteLine($"Bonus +2 au Dégat grâce a la force ce qui fait {Degat} de dégat  ");
            }
            else if (EtSi > 10)
            {
                return Degat += 1;
                
                // Console.WriteLine($"Bonus +1 au Dégat grâce a la force ce qui fait {Degat} de dégat");
            }
            else if (EtSi > 5)
            {
                return Degat += 0;
                
                // Console.WriteLine($"+0 au Dégat grâce a la force ce qui fait {Degat} de dégat");
            }
            else
            {
                return Degat -= 2;
                //  Console.WriteLine($"Malus -2 au Dégat a cause de la force ce qui fait {Degat} de dégat");
            }

            
        }


        public void Frappe(Personnages P1)
        {
            Random Perso1 = new Random();
            int DegatPerso1 = Perso1.Next(1, 4);
            DegatPerso1 = Modificateur(Force, DegatPerso1);
            P1.PV -= DegatPerso1;
;

            DecrireFrappe(P1, this, DegatPerso1);


            if (P1.PV > 0)
            {
                Random Perso2 = new Random();
                int DegatPerso2 = Perso2.Next(1, 4);
                DegatPerso2 = Modificateur(P1.Force, DegatPerso2);
                this.PV -= DegatPerso2;


                DecrireFrappe(this, P1, DegatPerso2); ;
            }


            /* Random Perso2 = new Random();
            int DegatPerso2 = Perso2.Next(1, 4);
            DegatPerso2 = Modificateur(P1.Force, DegatPerso2);
            P1.PV -= DegatPerso2;


            DecrireFrappe(P1, DegatPerso2); */

            if ((this.PV > 0) && (P1.PV > 0))
            {
                this.Frappe(P1);
            }
            else if (P1.PV <= 0)
            {
                this.DecrireMort(P1);
            }
            else
            {
                P1.DecrireMort(this);
                Looting(P1);
                Repos();
                DecrireLoot(P1);
            }
  


        }


        public virtual void Repos()
        {

            Modificateur(End);
        }



        public virtual void Looting(Personnages victime)
        {

            DecrireLoot(victime);
        }

        public virtual void PersonnagesCaracteristiques()
        {
            /* Console.WriteLine($"Caractéristiques de {Name}");
            Console.WriteLine($"*****FORCE => {Force}");
            Console.WriteLine($"*ENDURANCE => {End}");
            Console.WriteLine($"********PV => {PV}"); */
        }


        public void DecrireFrappe(Personnages Defenseur, Personnages Attaquant, int Degat)
        {
            Console.WriteLine();
            Console.WriteLine($"{Attaquant.Name} à infliger {Degat} de dégàt il reste plus que {Defenseur.PV}PV à {Defenseur.Name} " );
            Console.WriteLine();
        }

        public void DecrireMort(Personnages gagnant)
        {
            Console.WriteLine($" *****-->{gagnant.Name} à tuer  {Name}<--****");
        }

        public void DecrireLoot(Personnages victime)
        {
            Console.WriteLine($"OHHH {Name} à trouver sur {victime.Name} : {victime.Or} d'or et {victime.Cuir} de cuir");
            Console.WriteLine($"L'héros à {Cuir} de Cuir et {Or} d'or ");
            Console.WriteLine("-----------------COMBAT TERMINER------------");
            Console.WriteLine($"Le Héros peut enfin se reposer et donc regagne tout ses points de vie : {PV}");
            
        }
    }
}
