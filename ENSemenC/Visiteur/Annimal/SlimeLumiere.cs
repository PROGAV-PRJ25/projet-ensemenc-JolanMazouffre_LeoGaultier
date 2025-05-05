public class SlimeLumiere : Annimal
{
    public SlimeLumiere(Terrain terrainOccupe) : base("Slime de Lumière", terrainOccupe) { }
    public override void Action()
    {
        Console.WriteLine(terrainOccupe);
        if (terrainOccupe.plante != null)
        {
            terrainOccupe.plante.Lumiere -= 20;
            Console.WriteLine("ATTAQUE !");
        }
        Console.WriteLine("Lumière");
    }



}