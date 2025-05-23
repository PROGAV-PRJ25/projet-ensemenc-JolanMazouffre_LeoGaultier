using System.Runtime.CompilerServices;

public abstract class Annimal : Visiteur
{
    Ressource passion;
    Ressource faiblesse;
    string description;
    public Annimal(string nom, Terrain terrainOccupe, Ressource passion, Ressource faiblesse, string description) : base(nom, terrainOccupe)
    {
        this.passion = passion;
        this.faiblesse = faiblesse;
        this.description = description;
    }
    public abstract void Aide();
    public bool TestRessource(Ressource ressource, Joueur joueur)
    {
        bool estDansInventaire = false;
        foreach (KeyValuePair<string, Ressource> ressourceInventaire in joueur.inventaire)
        {
            if (ressourceInventaire.Value.nom == ressource.nom)
            {
                if (ressourceInventaire.Value.quantite > 0)
                {
                    estDansInventaire = true;
                }
            }
        }
        return estDansInventaire;
    }
    public void Apprivoiser(Joueur joueur)
    {
        if (TestRessource(passion, joueur))
        {

            Console.Clear();
            Console.WriteLine($"Vous avez apprivoiser le {nom}\n");
            Console.WriteLine($"Il vous aidera désormais en {description}!\n");
            terrainOccupe.animalApprivoiser = this;
            joueur.inventaire[passion.nom].quantite -= 1;
            Console.ReadKey();
        }
        else
        {
            Console.Clear();
            Console.WriteLine($"Vous tentez de chasser le {nom} mais cela ne fonctionne pas !\n");
            Console.WriteLine($"Pour fair fuir le {nom} il vous faut {faiblesse.nom} ! ");
            Console.WriteLine(" MAIS VOUS N'EN AVEZ PAS !!!\n");
            Console.ReadKey();
            Action();
        }
    }
    public void Chasser(Joueur joueur)
    {
        if (TestRessource(faiblesse, joueur))
        {

            Console.Clear();
            Console.WriteLine($"Vous avez fait fuir le {nom}\n"); //Il est important de noter que faire fuir un animal ne consomme pas de ressource
            Console.ReadKey();
        }
        else
        {
            Console.Clear();
            Console.WriteLine($"Vous tentez de chasser le {nom} mais cela ne fonctionne pas !\n");
            Console.WriteLine($"Pour fair fuir le {nom} il vous faut {faiblesse.nom} ! ");
            Console.WriteLine(" MAIS VOUS N'EN AVEZ PAS !!!\n");
            Console.ReadKey();
            Action();
        }
    }
    public override void ModeReel(Joueur joueur, Affichage affichage)
    {
        int action = 0;
        List<string> actionPossible = new List<string> { "Laisser faire", "Chasser", "Apprivoiser" };
        ConsoleKeyInfo input;
        do
        {
            affichage.AffichageAnimalMonstre(this, terrainOccupe, actionPossible, action);
            input = Console.ReadKey(true);
            switch (input.Key)
            {
                case ConsoleKey.RightArrow:
                    if (action + 1 >= actionPossible.Count)
                    {
                        action = 0;
                    }
                    else
                    {
                        action += 1;
                    }
                    break;
                case ConsoleKey.LeftArrow:
                    if (action - 1 < 0)
                    {
                        action = actionPossible.Count - 1;
                    }
                    else
                    {
                        action -= 1;
                    }
                    break;
                case ConsoleKey.Enter:
                    break;
            }
        }
        while (input.Key != ConsoleKey.Enter);
        if (action == 0)
        {
            Console.Clear();
            Console.WriteLine($"Vous laissez faire le {nom}...");
            Console.ReadKey();
            Action();
            return;
        }
        else if (action == 1)
        {
            Chasser(joueur);
            return;
        }
        else
        {
            Apprivoiser(joueur);
            return;
        }

    }

}