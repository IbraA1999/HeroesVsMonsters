using HeroesVsMonsters.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeroesVsMonsters.Interfaces
{
    public interface IJeux
    {
        void PersonnagesCaracteristiques();

        void DecrireFrappe(Personnages Defenseur, Personnages Attaquant, int Degat);

        void DecrireMort(Personnages gagnant);

        void DecrireLoot(Personnages victime);
    }
}
