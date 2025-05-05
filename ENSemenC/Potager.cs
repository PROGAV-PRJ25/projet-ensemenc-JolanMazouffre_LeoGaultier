public class Potager
{
    public int place;
    public List<Terrain> terrains;
    public enum Meteo { pluvieux, soleil }
    public Meteo meteo;
    public int chanceVisite;
    public Potager(int place, int chanceVisite)
    {
        this.place = place;
        terrains = [];
        for (int i = 1; i <= place; i++)
        {
            terrains.Add(CreeTerrain());
        }
        this.chanceVisite = chanceVisite;

    }
    public Terrain CreeTerrain()
    {
        Random rng = new Random();
        int tirage = rng.Next(1, 5);
        if (tirage == 1)
        {
            return new TerrainDesert();
        }
        if (tirage == 2)
        {
            return new TerrainForet();
        }
        if (tirage == 3)
        {
            return new TerrainPlaine();
        }
        else
        {
            return new TerrainGlace();
        }

    }
    public Terrain TerrainNonVideAleatoire()
    {
        Random rng = new Random();
        int alea;
        do
        {
            alea = rng.Next(0, place);
        }
        while (terrains[alea].plante == null);
        return terrains[alea];
    }
    public Annimal AnnimalAleatoire(Terrain terrain)
    {
        return new SlimeLumiere(terrain);
    }
    public Monstre MonstreAleatoire(Terrain terrain)
    {
        return new GobelinTemporel(terrain);
    }
    public Visiteur VisiteurAleatoire(Terrain terrain)
    {
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
            return new Marchand(terrain);
        }
    }
    public bool CheckVisitePossible()
    {
        foreach (Terrain terrain in terrains)
        {
            if (terrain.plante != null)
            {
                return true;
            }
        }
        return false;
    }
    public void DeclencheVisite()
    {
        if (CheckVisitePossible())
        {
            Random rng = new Random();
            if (rng.Next(0, 101) < chanceVisite)
            {
                Terrain terrain = TerrainNonVideAleatoire();
                Visiteur visiteur = VisiteurAleatoire(terrain);
                visiteur.ModeReel();
            }
        }

    }
    public void CheckMorts()
    {
        foreach (Terrain terrain in terrains)
        {
            if (terrain.plante != null)
            {
                if (terrain.plante.CalculeMort())
                {
                    Console.WriteLine($"La {terrain.plante.nom} est morte par négligence...");
                    terrain.plante = null;
                }
            }
        }
    }
    public override string ToString()
    {
        string retour = "";
        foreach (Terrain terrain in terrains)
        {
            retour += terrain.ToString() + "\t";
        }
        return retour;
    }

}