public class Marchand : Visiteur
{
    public Marchand(Terrain terrainOccupe) : base("marchand", terrainOccupe)
    {

    }
    public override void Action()
    {

    }
    public override void ModeReel()
    {
        Console.WriteLine($"un {nom} visite votre potager");
        ConsoleKeyInfo input;
        do
        {
            input = Console.ReadKey(true);
        }
        while (input.Key != ConsoleKey.Enter);

    }

}