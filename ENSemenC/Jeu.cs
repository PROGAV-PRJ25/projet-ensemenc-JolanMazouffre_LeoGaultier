using System.Diagnostics;

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
            potager.DeclencheVisite();

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
                            Thread.Sleep(3000);
                        }
                        break;
                    case ConsoleKey.Delete:
                        dansMenu = false;
                        break;
                }
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Vous n'avez aucune plante vous ne pouvez donc pas en arroser !!!");
            Thread.Sleep(2000);
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
                        dansMenu = false;
                        joueur.Planter(potagerPrincipale.RecupeTerrainLibre()[plante], "Verdichouffe");
                        break;
                    case ConsoleKey.Delete:
                        dansMenu = false;
                        break;
                }
            }
        }
        else
        {
            Console.Clear();
            Console.WriteLine("Vous ne possédez aucun terrain libre. Impossible de planter !!!");
            Thread.Sleep(2000);
        }
    }
    public void MenuClassique()
    {
        bool dansMenu = true;
        int action = 0;
        while (dansMenu)
        {
            Console.Clear();
            string[] actionPossible = ["Passer Semaine", "Aroser Plante", "Planter", "Info Joueur"];
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
                        case "Aroser Plante":
                            MenuArroser();
                            break;
                        case "Planter":
                            MenuPlanter();
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
}