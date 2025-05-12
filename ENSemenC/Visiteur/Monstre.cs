public abstract class Monstre : Visiteur
{
    public Monstre(string nom, Terrain terrainOccupe) : base(nom, terrainOccupe)
    {

    }
    public override void ModeReel(Joueur joueur)
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