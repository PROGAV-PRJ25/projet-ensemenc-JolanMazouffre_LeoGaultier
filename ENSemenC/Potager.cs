public class Potager
{
    public int place;
    public List<Terrain> terrains;
    public enum Meteo { pluvieux, soleil }
    public Meteo meteo;
    public int chanceVisite;
    public List<Ressource> magasinPotager;
    public Potager(int place, int chanceVisite, List<Ressource> magasinPotager)
    {
        this.place = place;
        this.magasinPotager = magasinPotager;
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
    public List<int> RecupeTerrainLibre()
    {
        List<int> retour = [];
        for (int i = 0; i < terrains.Count; i++)
        {
            if (terrains[i].plante == null)
            {
                retour.Add(i);
            }
        }
        return retour;
    }
    public List<int> RecupeTerrainOccupe()
    {
        List<int> retour = [];
        for (int i = 0; i < terrains.Count; i++)
        {
            if (terrains[i].plante != null)
            {
                retour.Add(i);
            }
        }
        return retour;
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