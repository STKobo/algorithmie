using PoupeeRusseNsP; 

var poupee = new PoupeeRusse("Rouge",
                new PoupeeRusse("Bleu",
                    new PoupeeRusse("Vert",
                        new PoupeeRusse("Verte",
                            new PoupeeRusse("Jaune", null))));

//Contenu du programme 
ShowAllPoupees(poupee);

void ShowAllPoupees(PoupeeRusse poupeeParam)
{
    Console.Writeline(poupeeParam.Couleur);
    while(poupeeParam.Fille != null)
    {
        Console.Writeline(poupeeParam.Fille.Couleur);
        poupeeParam = poupeeParam.Fille; 
    }
}