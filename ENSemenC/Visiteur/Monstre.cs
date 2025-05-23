public abstract class Monstre : Visiteur
{
    public Ressource faiblesse;
    public Ressource loot;
    public Monstre(string nom, Terrain terrainOccupe, Ressource faiblesse, Ressource loot) : base(nom, terrainOccupe)
    {
        this.faiblesse = faiblesse;
        this.loot = loot;
    }
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
    public void Tuer(Joueur joueur)
    {
        if (TestRessource(faiblesse, joueur))
        {
            joueur.Ajouter(loot);
            joueur.inventaire[faiblesse.nom].quantite -= 1;
            Console.Clear();
            Console.WriteLine($"Le gobelin est mort vous avez obtenue  : {loot.nom} !\n");
            Console.ReadKey();
        }
        else
        {
            Console.Clear();
            Console.WriteLine($"Pour tuer le {nom} il vous faut {faiblesse.nom} ! ");
            Console.WriteLine(" MAIS VOUS N'EN AVEZ PAS !!!\n");
            Console.ReadKey();
            Action();
        }
    }
    public override void ModeReel(Joueur joueur, Affichage affichage)
    {
        int action = 0;
        List<string> actionPossible = new List<string> { "Laisser faire", "Tuer" };
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
            Console.WriteLine($"Vous laissez faire le {nom}");
            Action();
        }
        else
        {
            Tuer(joueur);
        }
    }
}