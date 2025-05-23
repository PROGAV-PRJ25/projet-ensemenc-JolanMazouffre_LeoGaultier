using System.Reflection;

public class Marchand : Visiteur
{
    public List<Ressource> magasin;
    public Marchand(Terrain terrainOccupe, List<Ressource> magasin) : base("marchand", terrainOccupe)
    {
        this.magasin = magasin;
    }
    public override void Action()
    {

    }
    public override void ModeReel(Joueur joueur, Affichage affichage)
    {
        MenuMarchand(joueur, affichage);
    }
    public int ChoixQuantite(Ressource ressource, Joueur joueur, int max)
    {
        int n = 0;
        bool dansMenu = true;
        while (dansMenu)
        {
            Console.Clear();
            Console.WriteLine($"Choissiez la quantité de {ressource.nom} ! Pressez supprimer pour annuler");
            Console.WriteLine(n);
            ConsoleKeyInfo input = Console.ReadKey();
            switch (input.Key)
            {
                case ConsoleKey.RightArrow:
                    if (n + 1 <= max)
                        n += 1;
                    break;
                case ConsoleKey.LeftArrow:
                    if (n - 1 >= 0)
                        n -= 1;
                    break;
                case ConsoleKey.Enter:
                    return n;
                case ConsoleKey.Backspace:
                    dansMenu = false;
                    break;
            }
        }
        return 0;
    }
    public void MenuMarchand(Joueur joueur, Affichage affichage)
    {
        bool dansMenu = true;
        int action = 0;
        List<string> actionPossible = ["acheter", "vendre", "sortir"];
        while (dansMenu)
        {
            affichage.AffichageMarchand(actionPossible, action);
            ConsoleKeyInfo input = Console.ReadKey();
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
                    if (action == 0)
                        MenuAchat(joueur, affichage);
                    else if (action == 1)
                        MenuVendre(joueur, affichage);
                    else
                        dansMenu = false;
                    break;
                case ConsoleKey.Backspace:
                    dansMenu = false;
                    break;

            }
        }
    }
    public void MenuAchat(Joueur joueur, Affichage affichage)
    {
        bool dansMenu = true;
        int action = 0;
        List<string> stringMagasin = [];
        foreach (Ressource ressource in magasin)
        {
            stringMagasin.Add(ressource.ToString());
        }
        while (dansMenu)
        {
            affichage.AffichageMarchand(stringMagasin, action);
            ConsoleKeyInfo input = Console.ReadKey();
            switch (input.Key)
            {
                case ConsoleKey.RightArrow:

                    if (action + 1 >= magasin.Count)
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
                        action = magasin.Count - 1;
                    }
                    else
                    {
                        action -= 1;
                    }
                    break;
                case ConsoleKey.Enter:
                    int quantiteMax = joueur.argent / magasin[action].prixAchat;
                    int n = ChoixQuantite(magasin[action], joueur, quantiteMax);
                    magasin[action].quantite = n;
                    joueur.argent -= magasin[action].prixAchat * n;
                    joueur.Ajouter(magasin[action]);
                    break;
                case ConsoleKey.Backspace:
                    dansMenu = false;
                    break;

            }
        }
    }
    public void MenuVendre(Joueur joueur, Affichage affichage)
    {
        List<string> keyInventaire = [];
        foreach (KeyValuePair<string, Ressource> ressource in joueur.inventaire)
        {
            keyInventaire.Add(ressource.Key);
        }
        bool dansMenu = true;
        int action = 0;
        while (dansMenu)
        {
            affichage.AffichageMarchand(keyInventaire, action);
            ConsoleKeyInfo input = Console.ReadKey();
            switch (input.Key)
            {
                case ConsoleKey.RightArrow:

                    if (action + 1 >= keyInventaire.Count)
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
                        action = keyInventaire.Count - 1;
                    }
                    else
                    {
                        action -= 1;
                    }
                    break;
                case ConsoleKey.Enter:
                    int n = ChoixQuantite(joueur.inventaire[keyInventaire[action]], joueur, joueur.inventaire[keyInventaire[action]].quantite);
                    joueur.inventaire[keyInventaire[action]].quantite -= n;
                    joueur.argent += n * joueur.inventaire[keyInventaire[action]].prixVente;
                    Console.Clear();
                    Console.WriteLine($"Vous avez vendu {n} {keyInventaire[action]}");
                    Console.WriteLine($"Cela vous a rapporté {n * joueur.inventaire[keyInventaire[action]].prixVente} d'argent");
                    Console.ReadKey();
                    break;
                case ConsoleKey.Backspace:
                    dansMenu = false;
                    break;

            }
        }
    }

}

