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
    public override void ModeReel(Joueur joueur)
    {
        MenuMarchand(joueur);
    }
    public int ChoixQuantite(Ressource ressource, Joueur joueur, int max)
    {
        int n = 0;
        bool dansMenu = true;
        while (dansMenu)
        {
            Console.Clear();
            Console.WriteLine($"Combien de {ressource.nom} voulez vous ? Pressez supprimer pour annuler");
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

    public void MenuMarchand(Joueur joueur)
    {
        bool dansMenu = true;
        int action = 0;
        while (dansMenu)
        {
            Console.Clear();
            Console.WriteLine($"Un marchand rend visite à votre potager\tAppuyer sur la touche supprimer pour sortir du magasin\n Appuyer sur flèche haut pour vendre des item");
            foreach (Ressource ressource in magasin)
            {
                Console.WriteLine(ressource);
            }
            Console.WriteLine(magasin[action]);
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
                case ConsoleKey.UpArrow:
                    MenuVendre(joueur);
                    break;
                case ConsoleKey.Backspace:
                    dansMenu = false;
                    break;

            }
        }
    }
    public void MenuVendre(Joueur joueur)
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
            Console.Clear();
            Console.WriteLine($"Vous être en train de vendre des items. \t Appuyer sur supprimer pour revenir au menu d'achat");
            foreach (KeyValuePair<string, Ressource> ressource in joueur.inventaire)
            {
                Console.WriteLine($"{ressource.Value.nom} gain : {ressource.Value.prixVente}");
            }
            Console.WriteLine(keyInventaire[action]);
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
                    break;
                case ConsoleKey.Backspace:
                    dansMenu = false;
                    break;

            }
        }
    }

}

