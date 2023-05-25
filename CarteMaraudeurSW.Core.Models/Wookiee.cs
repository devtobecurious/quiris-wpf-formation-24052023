namespace CarteMaraudeurSW.Core.Models
{
    /// <summary>
    /// Class Wookiee
    /// </summary>
    public class Wookiee
    {
        public void Avancer(IMoyenDeplacement moyenDeplacement)
        {
            //
            moyenDeplacement.SeDeplacer();
            //
        }

        public int Id { get; set; }

        public string Libelle { get; set; } = "";

        public string Avatar { get; set; }
    }
}
