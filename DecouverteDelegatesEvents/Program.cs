
using DecouverteDelegatesEvents;

Developpeur developpeur = new();

developpeur.MonCodeEstFini += Developpeur_MonCodeEstFini;
developpeur.MonCodeEstFini += Developpeur_MonCodeEstFini;
developpeur.MonCodeEstFini += Developpeur_MonCodeEstFini1;
// developpeur.MonCodeEstFini -= Developpeur_MonCodeEstFini1;
developpeur.MonCodeEstFini -= Developpeur_MonCodeEstFini;


developpeur.Ecrire();

void Developpeur_MonCodeEstFini1(Code code)
{
    
}

void Developpeur_MonCodeEstFini(Code code)
{
    
}

//Afficher afficheur = Console.WriteLine;

//Calculateur calculateur = new();

//calculateur.Calculer(afficheur);
//calculateur.Calculer(Console.WriteLine);

//calculateur.Calculer(mess =>
//{
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine(mess?.ToUpper());
//    Console.ForegroundColor = ConsoleColor.White;
//});


//void AfficherPlus(string? mess)
//{
//    Console.ForegroundColor = ConsoleColor.Red;
//    Console.WriteLine(mess?.ToUpper());
//    Console.ForegroundColor = ConsoleColor.White;
//}
//calculateur.Calculer(AfficherPlus);