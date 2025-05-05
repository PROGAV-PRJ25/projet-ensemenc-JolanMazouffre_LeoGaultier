public class GobelinTemporel : Monstre
{
    public GobelinTemporel(Terrain terrinOccupe) : base("Gobelin Temporel", terrinOccupe)
    {

    }
    public override void Action()
    {
        if (terrainOccupe.plante != null)
        {
            terrainOccupe.plante.temps -= 2;
            if (terrainOccupe.plante.temps < 0)
            {
                Console.WriteLine($"la {terrainOccupe.plante?.nom} à été tué par le gobelin temporel!");
                terrainOccupe.plante = null;
            }
        }
    }

}