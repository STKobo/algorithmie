namespace PoupeeRusseNsP
{
    public class PoupeeRusse
    {
        public PoupeeRusse(string couleur, PoupeeRusse fille)
        {
            Couleur = couleur; 
            Fille = fille; 
        }
    }
    public string Couleur (get; set;)
    public PoupeeRusse Fille {get ; set }
}