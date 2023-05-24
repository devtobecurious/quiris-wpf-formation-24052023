using CarteMaraudeurSW.Core.Models;

Wookiee wookiee = new Wookiee();
Wookiee wookiee2 = new();
var wookie3 = new Wookiee();
Wookiee test = wookiee;

test.Avatar = "avatar-01.png";

Console.WriteLine(wookiee == test);

Console.WriteLine(test.Avatar);
Console.WriteLine(wookiee.Avatar);


MotoJet jet = new();
FauconMilenium faucon = new();

List<Wookiee> list = new()
{
    new(),
    new()
};

IMoyenDeplacement deplacement = new HumeurMoyenDeplacement().Create(Humeur.EnColere);
wookiee.Avancer(deplacement);
// wookiee.Avancer(faucon);
