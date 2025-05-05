public abstract class Annimal : Visiteur
{
    public Annimal(string nom, Terrain terrainOccupe) : base(nom, terrainOccupe)
    {

    }
    public override void ModeReel()
    {
        Console.WriteLine($"un {nom} visite votre potage !");
        ConsoleKeyInfo input;
        do
        {
            input = Console.ReadKey(true);
        }
        while (input.Key != ConsoleKey.Enter);
        Action();
    }

}