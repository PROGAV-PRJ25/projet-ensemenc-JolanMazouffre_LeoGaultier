public class Jeu
{
    public Potager potager;
    public Jeu()
    {
        potager = new Potager(4, 100);
        potager.terrains[0].Planter("Verdichouffe");
    }
    public void PasserSemaine()
    {
        foreach (Terrain terrain in potager.terrains)
        {
            terrain.plante?.CalculeCroissance();
            terrain.plante?.Boire();
            potager.CheckMorts();
        }
        potager.DeclencheVisite();
    }
}