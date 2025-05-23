using System.Diagnostics;
using System.Security.Cryptography.X509Certificates;

public class Jeu
{
    public Affichage affichage;
    public Joueur joueur;
    public int semaine;
    public Potager potagerPrincipale; // cette variable porte ce nom car il etait initalement prévu de faire un jeu avec plusieurs potager, mais les contraintes de temps nous ont obligé à ne pas le faire

    public Jeu()
    {
        affichage = new Affichage(this);
        joueur = new Joueur();
        semaine = 1;
        potagerPrincipale = joueur.potagers[0];
    }
    public void Jouer()
    {
        Console.WriteLine("Pour une experience optimale veuillez aggrandir votre fenetre de console au maximum !!!");
        Console.WriteLine("Appuyer sur une touche pour continuer");
        Console.ReadKey();
        affichage.AffichierTitre();
        affichage.AfficherIntro();
        affichage.AfficherExplication();
        while (true)
        {
            PasserSemaine();
        }
    }
    public void PasserSemaine()
    {
        MenuClassique();
        TestBloque();
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

            terrain.animalApprivoiser?.Aide();
            terrain.plante?.CalculeCroissance();
            terrain.plante?.Boire();
            potager.CheckMorts();
        }
    }
    public void MenuCraft()
    {
        bool dansMenu = true;
        int recette = 0;
        List<string> actionPossible = ["Abajour", "Bulbe Lumineux", "Bulbe Explosif"];
        while (dansMenu)
        {
            affichage.AfficherPotager(actionPossible, recette);
            ConsoleKeyInfo input = Console.ReadKey();
            switch (input.Key)
            {
                case ConsoleKey.RightArrow:

                    if (recette + 1 >= actionPossible.Count)
                    {
                        recette = 0;
                    }
                    else
                    {
                        recette += 1;
                    }
                    break;

                case ConsoleKey.LeftArrow:
                    if (recette - 1 < 0)
                    {
                        recette = actionPossible.Count - 1;
                    }
                    else
                    {
                        recette -= 1;
                    }
                    break;
                case ConsoleKey.Enter:
                    switch (actionPossible[recette])
                    {
                        case "Abajour":
                            new RecetteAbajour().Craft(joueur);
                            break;
                        case "Bulbe Explosif":
                            new RecetteBulbeExplosif().Craft(joueur);
                            break;
                        case "Bulbe Lumineux":
                            new RecetteBulbeLumineux().Craft(joueur);
                            break;
                    }
                    break;
                case ConsoleKey.Backspace:
                    dansMenu = false;
                    break;
            }
        }
    }
    public void MenuArroser()
    {

        bool dansMenu = true;
        int plante = 0;
        List<int> possibiliter = potagerPrincipale.RecupeTerrainOccupe();
        if (potagerPrincipale.RecupeTerrainOccupe().Count > 0)
        {
            while (dansMenu)
            {
                affichage.ChoixPotager(possibiliter[plante]);
                ConsoleKeyInfo input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.RightArrow:

                        if (plante + 1 >= possibiliter.Count)
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
                            plante = possibiliter.Count - 1;
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
                            joueur.Arroser(potagerPrincipale.terrains[possibiliter[plante]]);
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
        List<int> possibiliter = potagerPrincipale.RecupeTerrainOccupe();
        if (potagerPrincipale.RecupeTerrainOccupe().Count > 0)
        {
            while (dansMenu)
            {
                affichage.ChoixTerrain(possibiliter[plante]);
                ConsoleKeyInfo input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.RightArrow:

                        if (plante + 1 >= possibiliter.Count)
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
                            plante = possibiliter.Count - 1;
                        }
                        else
                        {
                            plante -= 1;
                        }
                        break;
                    case ConsoleKey.Enter:
                        dansMenu = false;
                        joueur.Recolter(potagerPrincipale.terrains[possibiliter[plante]]);
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
        List<int> possibiliter = potagerPrincipale.RecupeTerrainLibre();
        if (potagerPrincipale.RecupeTerrainLibre().Count > 0)
        {
            while (dansMenu)
            {
                affichage.ChoixTerrain(possibiliter[plante]);
                ConsoleKeyInfo input = Console.ReadKey();
                switch (input.Key)
                {
                    case ConsoleKey.RightArrow:

                        if (plante + 1 >= possibiliter.Count)
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
                            plante = possibiliter.Count - 1;
                        }
                        else
                        {
                            plante -= 1;
                        }
                        break;
                    case ConsoleKey.Enter:
                        Graine? graineChoisie = MenuGraine(potagerPrincipale.terrains[possibiliter[plante]]);
                        if (graineChoisie != null)
                        {
                            dansMenu = false;
                            graineChoisie.quantite -= 1;
                            joueur.Planter(potagerPrincipale.terrains[possibiliter[plante]], graineChoisie.nomPlante);
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
        List<string> nomGrainesDispo = [];
        foreach (KeyValuePair<string, Ressource> item in joueur.inventaire)
        {
            item.Value.ActionGraine(grainesDispo);
        }
        foreach (Graine graineDispo in grainesDispo)
        {
            nomGrainesDispo.Add(graineDispo.nom);
        }
        bool dansMenu = true;
        int graine = 0;
        while (dansMenu)
        {
            affichage.AfficherPotager(nomGrainesDispo, graine);
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
            List<string> actionPossible = ["Passer Semaine", "Arroser Plante", "Planter", "Recolter", "Crafter", "Info Joueur", "info Potager"];
            affichage.AfficherPotager(actionPossible, action);
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
                        case "info Potager":
                            affichage.InfoPotager(potagerPrincipale);
                            break;
                        case "Crafter":
                            MenuCraft();
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
                visiteur.ModeReel(joueur, affichage);
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
            affichage.Bloque();
            joueur.argent -= 50;
            joueur.Ajouter(new GraineVerdichouffe(1));
        }
    }
}
