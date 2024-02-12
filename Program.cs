using HeroesVsMonsters.Interfaces;
using HeroesVsMonsters.Models;
using System.Runtime.InteropServices;
using System.Xml.Linq;










Console.WriteLine("Entrez le nom de votre personnages");
string NomPersonnages = Console.ReadLine();
Console.WriteLine("Entrez le type de votre personnages : 'Nain' ou 'Humain' ");
string TypePersonnages = Console.ReadLine();
bool Verification = true;
Humain H1 = null;
Nain N1 = null;
int NumberTour = 0;
Random RdnHasard = new Random();


while (Verification)
{
    if (TypePersonnages == "Humain" || TypePersonnages == "Nain")
    {
        Console.WriteLine("-------------------------------");
        Console.WriteLine("Votre personage est valider");
        Console.WriteLine("-------------------------------");
        Verification = false;
    }
    else
    {
        Console.WriteLine("Le type que vous avez choisis est invalide choissisez entre : Nain et Humain sans oublier la majuscule au début");
        Console.WriteLine("Entrez le type de votre personnages : 'Nain' ou 'Humain' ");
        TypePersonnages = Console.ReadLine();
    }
}

switch (TypePersonnages)
{
    case "Humain":
        H1 = new Humain(NomPersonnages, TypePersonnages);
        break;
    case "Nain":
        N1 = new Nain(NomPersonnages, TypePersonnages);
        break;

    default:
        break;
}




if (TypePersonnages == "Humain")
{
    do
    {
       
        int Hasard = RdnHasard.Next(1, 4);

        switch (Hasard)
        {

            case 1:
                Console.WriteLine("L'héros rencontre un Orques  le combat commence");
                Orques O1 = new Orques("Orques", "Monsters");
                H1.Frappe(O1);
                break;
            case 2:
                Console.WriteLine("L'héros rencontre un Loupsle combat commence");
                Loups L1 = new Loups("Loups", "Monsters");
                H1.Frappe(L1);
                break;
            case 3:
                Console.WriteLine("L'héros rencontre un Dragonnet le combat commence");
                Dragonnets D1 = new Dragonnets("Dragonnet", "Monsters");
                H1.Frappe(D1);
                break;
            default:
                break;
        }

        NumberTour += 1;
    } while (H1.PV < 0);
}
else
{
    do
    {
       
        int Hasard = RdnHasard.Next(1, 4);
        

        switch (Hasard)
        {

            case 1:
                Console.WriteLine("L'héros rencontre un Orques  le combat commence");
                Orques O1 = new Orques("Orques", "Monsters");
                N1.Frappe(O1);
                break;
            case 2:
                Console.WriteLine("L'héros rencontre un Loupsle combat commence");
                Loups L1 = new Loups("Loups", "Monsters");
                N1.Frappe(L1);
                break;
            case 3:
                Console.WriteLine("L'héros rencontre un Dragonnet le combat commence");
                Dragonnets D1 = new Dragonnets("Dragonnet", "Monsters");
                N1.Frappe(D1);
                break;
            default:
                break;
        }
         NumberTour += 1;

    } while (N1.PV < 0);
} 




/*Console.WriteLine("COMMENCEMET DU COMBAT");

Humain H1 = new Humain("DylanLeConquerant", "Heroes");
Dragonnets D1= new("Dragonnets", "Monsters");
Loups L1 = new("Loups", "Monstersdsdsds");


Console.WriteLine("---------------------------");
Console.WriteLine($" Le {L1.Name} =>  FORCE : {L1.Force} - ENDURANCE :  {L1.End} - PV : {L1.PV}  ET Cuir POSSEDER  {L1.Cuir}");
Console.WriteLine($" Le {D1.Name} =>  FORCE : {D1.Force} - ENDURANCE :  {D1.End} - PV : {D1.PV} - OR POSSEDER  {D1.Or}  ET Cuir POSSEDER  {D1.Cuir} ");
Console.WriteLine($" Le {H1.Name} =>  FORCE : {H1.Force} - ENDURANCE :  {H1.End} - PV : {H1.PV} - OR POSSEDER  {H1.Or}  ET Cuir POSSEDER  {H1.Cuir} ");


Console.WriteLine("**************************************");
Console.WriteLine("************COMBAT******************");
Console.WriteLine("**************************************");


H1.Frappe(D1); /*



/* Console.WriteLine($"FRAPPE DE {H1.Name}");
H1.Frappe(L1);
Console.WriteLine("FIN DE FRAPPE");
Console.WriteLine($"FRAPPE DE {L1.Name}");
L1.Frappe(H1);

Console.WriteLine("######################################");

Console.WriteLine($"FRAPPE DE {H1.Name}");
H1.Frappe(L1);
Console.WriteLine("FIN DE FRAPPE");
Console.WriteLine($"FRAPPE DE {L1.Name}");
L1.Frappe(H1);

Console.WriteLine("######################################");


Console.WriteLine($"FRAPPE DE {H1.Name}");
H1.Frappe(L1);
Console.WriteLine("FIN DE FRAPPE");
Console.WriteLine($"FRAPPE DE {L1.Name}");
L1.Frappe(H1);

Console.WriteLine("######################################");

Console.WriteLine($"FRAPPE DE {H1.Name}");
H1.Frappe(L1);
Console.WriteLine("FIN DE FRAPPE");
Console.WriteLine($"FRAPPE DE {L1.Name}");
L1.Frappe(H1);

Console.WriteLine("######################################");

Console.WriteLine($"FRAPPE DE {H1.Name}");
H1.Frappe(L1);
Console.WriteLine("FIN DE FRAPPE");
Console.WriteLine($"FRAPPE DE {L1.Name}");
L1.Frappe(H1);


Console.WriteLine("######################################");

Console.WriteLine($"FRAPPE DE {H1.Name}");
H1.Frappe(L1);
Console.WriteLine("FIN DE FRAPPE");
Console.WriteLine($"FRAPPE DE {L1.Name}");
L1.Frappe(H1);


Console.WriteLine("######################################");

Console.WriteLine($"FRAPPE DE {H1.Name}");
H1.Frappe(L1);
Console.WriteLine("FIN DE FRAPPE");
Console.WriteLine($"FRAPPE DE {L1.Name}");
L1.Frappe(H1);


Console.WriteLine("######################################");

Console.WriteLine($"FRAPPE DE {H1.Name}");
H1.Frappe(L1);
Console.WriteLine("FIN DE FRAPPE");
Console.WriteLine($"FRAPPE DE {L1.Name}");
L1.Frappe(H1);



Console.WriteLine("######################################");

Console.WriteLine($"FRAPPE DE {H1.Name}");
H1.Frappe(L1);
Console.WriteLine("FIN DE FRAPPE");
Console.WriteLine($"FRAPPE DE {L1.Name}");
L1.Frappe(H1);



Console.WriteLine("######################################");

Console.WriteLine($"FRAPPE DE {H1.Name}");
H1.Frappe(L1);
Console.WriteLine("FIN DE FRAPPE");
Console.WriteLine($"FRAPPE DE {L1.Name}");
L1.Frappe(H1);



Console.WriteLine("######################################");

Console.WriteLine($"FRAPPE DE {H1.Name}");
H1.Frappe(L1);
Console.WriteLine("FIN DE FRAPPE");
Console.WriteLine($"FRAPPE DE {L1.Name}");
L1.Frappe(H1);



Console.WriteLine("**************************************"); 


Console.WriteLine("-----------MAIS PAR LA SUITE ARRIVER DU DRAGONNET-----------");
Console.WriteLine($" Le {D1.Name} =>  FORCE : {D1.Force} - ENDURANCE :  {D1.End} - PV : {D1.PV} - OR POSSEDER  {D1.Or}  ET Cuir POSSEDER  {D1.Cuir} "); */





/* H1.Frappe();
H1.Frappe();
H1.Frappe();
H1.Frappe();
H1.Frappe();
H1.Frappe();
H1.Frappe();
H1.Frappe();
H1.Frappe();
H1.Frappe(); */

