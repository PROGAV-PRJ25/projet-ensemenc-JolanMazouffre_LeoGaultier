using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

public class Jeu
{
    public Joueur joueur;
    public int semaine;
    public Potager potagerPrincipale;
    public Jeu()
    {
        joueur = new Joueur();
        semaine = 1;
        potagerPrincipale = joueur.potagers[0];
    }
    public void Jouer()
    {
        while (true)
        {
            PasserSemaine();
        }
    }
    public void PasserSemaine()
    {
        MenuClassique();
        foreach (Potager potager in joueur.potagers)
        {
            SemainePotager(potager);
            DeclencheVisite(potager);

        }
        semaine++;
    }
    public void SemainePotager(Potager potager)
    {
        foreach (Terrain terrain in potager.terrains)
        {
            terrain.plante?.CalculeCroissance();
            terrain.plante?.Boire();
            potager.CheckMorts();
        }
    }
    public void MenuArroser()
    {

        bool dansMenu = true;
        int plante = 0;
        if (potagerPrincipale.RecupeTerrainOccupe().Count > 0)
        {
            while (dansMenu)
            {
                Console.Clear();
                Console.WriteLine($"semaine {semaine}: {potagerPrincipale}");
                foreach (Terrain terrain in potagerPrincipale.terrains)
                {
                    Console.WriteLine(terrain.plante);
                }
                Console.WriteLine("Arroser Plante");
                Console.WriteLine($"{potagerPrincipale.RecupeTerrainOccupe()[plante]}");
                ConsoleKeyInfo input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.RightArrow:

                        if (plante + 1 >= potagerPrincipale.RecupeTerrainOccupe().Count)
                        {
                            plante = 0;
                        }
                        else
                        {
                            plante += 1;
                        }
                        break;

                    case ConsoleKey.LeftArrow:
                        if (plante - 1 < 0)
                        {
                            plante = potagerPrincipale.RecupeTerrainOccupe().Count - 1;
                        }
                        else
                        {
                            plante -= 1;
                        }
                        break;
                    case ConsoleKey.Enter:
                        dansMenu = false;
                        if (joueur.inventaire["Eau"].quantite > 0)
                        {
                            joueur.Arroser(potagerPrincipale.RecupeTerrainOccupe()[plante]);
                        }
                        else
                        {
                            Console.Clear();
                            Console.WriteLine("Vous n'avez pas d'eau !!!");
                            Console.ReadKey();
                        }
                        break;
                    case ConsoleKey.Backspace:
                        dansMenu = false;
                        break;
                }
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Vous n'avez aucune plante vous ne pouvez donc pas en arroser !!!");
            Console.ReadKey();
        }
    }
    public void MenuRecolter()
    {

        bool dansMenu = true;
        int plante = 0;
        if (potagerPrincipale.RecupeTerrainOccupe().Count > 0)
        {
            while (dansMenu)
            {
                Console.Clear();
                Console.WriteLine($"semaine {semaine}: {potagerPrincipale}");
                foreach (Terrain terrain in potagerPrincipale.terrains)
                {
                    Console.WriteLine(terrain.plante);
                }
                Console.WriteLine("Recolter");
                Console.WriteLine($"{potagerPrincipale.RecupeTerrainOccupe()[plante]}");
                ConsoleKeyInfo input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.RightArrow:

                        if (plante + 1 >= potagerPrincipale.RecupeTerrainOccupe().Count)
                        {
                            plante = 0;
                        }
                        else
                        {
                            plante += 1;
                        }
                        break;

                    case ConsoleKey.LeftArrow:
                        if (plante - 1 < 0)
                        {
                            plante = potagerPrincipale.RecupeTerrainOccupe().Count - 1;
                        }
                        else
                        {
                            plante -= 1;
                        }
                        break;
                    case ConsoleKey.Enter:
                        dansMenu = false;
                        joueur.Recolter(potagerPrincipale.RecupeTerrainOccupe()[plante]);
                        break;
                    case ConsoleKey.Backspace:
                        dansMenu = false;
                        break;
                }
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Vous n'avez aucune plante vous ne pouvez donc pas en arroser !!!");
            Console.ReadKey();
        }
    }
    public void MenuPlanter()
    {

        bool dansMenu = true;
        int plante = 0;
        if (potagerPrincipale.RecupeTerrainLibre().Count > 0)
        {
            while (dansMenu)
            {
                Console.Clear();
                Console.WriteLine($"semaine {semaine}: {potagerPrincipale}");
                foreach (Terrain terrain in potagerPrincipale.terrains)
                {
                    Console.WriteLine(terrain.plante);
                }
                Console.WriteLine("Planter");
                Console.WriteLine($"{potagerPrincipale.RecupeTerrainLibre()[plante]}");
                ConsoleKeyInfo input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.RightArrow:

                        if (plante + 1 >= potagerPrincipale.RecupeTerrainLibre().Count)
                        {
                            plante = 0;
                        }
                        else
                        {
                            plante += 1;
                        }
                        break;

                    case ConsoleKey.LeftArrow:
                        if (plante - 1 < 0)
                        {
                            plante = potagerPrincipale.RecupeTerrainLibre().Count - 1;
                        }
                        else
                        {
                            plante -= 1;
                        }
                        break;
                    case ConsoleKey.Enter:
                        Graine? graineChoisie = MenuGraine(potagerPrincipale.RecupeTerrainLibre()[plante]);
                        if (graineChoisie != null)
                        {
                            dansMenu = false;
                            graineChoisie.quantite -= 1;
                            joueur.Planter(potagerPrincipale.RecupeTerrainLibre()[plante], graineChoisie.nomPlante);
                        }
                        break;
                    case ConsoleKey.Backspace:
                        dansMenu = false;
                        break;
                }
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Vous ne possédez aucun terrain libre. Impossible de planter !!!");
            Console.ReadKey();
        }
    }
    public Graine? MenuGraine(Terrain terrainChoisie)
    {
        List<Graine> grainesDispo = [];
        foreach (KeyValuePair<string, Ressource> item in joueur.inventaire)
        {
            item.Value.ActionGraine(grainesDispo);
        }
        bool dansMenu = true;
        int graine = 0;
        while (dansMenu)
        {
            Console.Clear();
            Console.WriteLine($"semaine {semaine}: {potagerPrincipale}");
            foreach (Terrain terrain in potagerPrincipale.terrains)
            {
                Console.WriteLine(terrain.plante);
            }
            Console.WriteLine("Planter");
            Console.WriteLine(terrainChoisie);
            Console.WriteLine($"{grainesDispo[graine]}");
            ConsoleKeyInfo input = Console.ReadKey();
            switch (input.Key)
            {
                case ConsoleKey.RightArrow:

                    if (graine + 1 >= grainesDispo.Count)
                    {
                        graine = 0;
                    }
                    else
                    {
                        graine += 1;
                    }
                    break;

                case ConsoleKey.LeftArrow:
                    if (graine - 1 < 0)
                    {
                        graine = grainesDispo.Count - 1;
                    }
                    else
                    {
                        graine -= 1;
                    }
                    break;
                case ConsoleKey.Enter:
                    if (grainesDispo[graine].quantite > 0)
                        return grainesDispo[graine];
                    else
                    {
                        Console.Clear();
                        Console.WriteLine($"Vous n'avez plus de {grainesDispo[graine].nom}");
                        Console.ReadKey();
                    }
                    break;
                case ConsoleKey.Backspace:
                    return null;
            }
        }
        return null;
    }
    public void MenuClassique()
    {
        bool dansMenu = true;
        int action = 0;
        while (dansMenu)
        {
            Console.Clear();
            string[] actionPossible = ["Passer Semaine", "Arroser Plante", "Planter", "Info Joueur", "Recolter"];
            Console.WriteLine($"semaine {semaine}: {potagerPrincipale}");
            foreach (Terrain terrain in potagerPrincipale.terrains)
            {
                Console.WriteLine(terrain.plante);
            }
            Console.WriteLine(actionPossible[action]);
            ConsoleKeyInfo input = Console.ReadKey();
            switch (input.Key)
            {
                case ConsoleKey.RightArrow:

                    if (action + 1 >= actionPossible.Length)
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
                        action = actionPossible.Length - 1;
                    }
                    else
                    {
                        action -= 1;
                    }
                    break;
                case ConsoleKey.Enter:
                    switch (actionPossible[action])
                    {
                        case "Passer Semaine":
                            dansMenu = false;
                            break;
                        case "Arroser Plante":
                            MenuArroser();
                            break;
                        case "Planter":
                            MenuPlanter();
                            break;
                        case "Recolter":
                            MenuRecolter();
                            break;
                        case "Info Joueur":
                            Console.Clear();
                            Console.WriteLine(joueur.ToString());
                            Console.ReadKey();
                            break;
                    }
                    break;
            }

        }
    }
    public Annimal AnnimalAleatoire(Terrain terrain)
    {
        return new SlimeLumiere(terrain);
    }
    public Monstre MonstreAleatoire(Terrain terrain)
    {
        return new GobelinTemporel(terrain);
    }
    public Visiteur VisiteurAleatoire(Potager potager)
    {
        Terrain terrain = potager.TerrainNonVideAleatoire();
        Random rng = new Random();
        int choice = rng.Next(0, 4);
        if (choice <= 1)
        {
            return AnnimalAleatoire(terrain);
        }
        if (choice == 2)
        {
            return MonstreAleatoire(terrain);
        }
        else
        {
            return new Marchand(terrain, potager.magasinPotager);
        }
    }
    public void DeclencheVisite(Potager potager)
    {
        if (potager.CheckVisitePossible())
        {
            Random rng = new Random();
            if (rng.Next(0, 101) < potager.chanceVisite)
            {
                Visiteur visiteur = VisiteurAleatoire(potager);
                visiteur.ModeReel(joueur);
            }
        }

    }
    public void TestBloque()//Si le joueur joue mal, il peux se retrouver à un moment ou il devient incapable d'agire. Il lui sera dans ce cas obligé d'acheté une Verdichouffe plus chère, parfois à crédit !!!
    {
        bool bloque = true;
        foreach (Potager potager in joueur.potagers)
        {
            foreach (Terrain terrain in potager.terrains)
            {
                if (terrain.plante != null)
                    bloque = false;
            }
        }
        List<Graine> grainesDispo = [];
        foreach (KeyValuePair<string, Ressource> item in joueur.inventaire)
        {
            item.Value.ActionGraine(grainesDispo);
        }
        foreach (Graine graine in grainesDispo)
        {
            if (graine.quantite > 0)
            {
                bloque = false;
            }
        }
        if (bloque)
        {
            Console.Clear();
            Console.WriteLine("Il semblerait que vous avez pris des mauvaise décision vous êtes désormais bloqué ! \n",
                              "Ni plante, ni graine, aucun marchand ne sera attiré par votre potager !\n",
                              "Pour vous sauvez, voici une Graine de Verdichouffe à 50 gold au lieu de 35 :");
            Console.ReadKey();
            joueur.argent -= 50;
            joueur.Ajouter(new GraineVerdichouffe(1));
        }
    }
}
