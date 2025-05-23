public class SlimeLumiere : Annimal
{
    public SlimeLumiere(Terrain terrainOccupe) : base("Slime de Lumière", terrainOccupe, new BulbeLumineux(1), new Abajour(0), "produisant de la lumière pour le bien être de votre plante !") { }
    public override string[] Sprite()
    {
        return new string[] { // Niveau abyssal en UNICODE ART !
            "                   ",
            "                   ",
            "                   ",
            "                   ",
            "                   ",
            "                   ",
            "                   ",
            "       ████        ",
            "      █████████    ",
            "   ████        ███ ",
            "  ██           ███ ",
            " ██             ██ ",
            "██     ██    ██  ██",
            "█      ██    ██  ██",
            "█                ██",
            "█                ██",
            "█                ██",
            "█                ██",
            " █              ██ ",
            " █             ██  ",
            "   ███       ██    ",
            "       █████       "

        };
    }
    public override void Action()
    {
        Console.Clear();
        if (terrainOccupe.plante != null)
        {
            terrainOccupe.plante.Lumiere -= 20;
            Console.WriteLine("Le slime de lumière absorde la lumière de la plante pour se nourrir !");
            Console.WriteLine($"La plante pert 20 de lumière !");
        }
        Console.ReadKey();
    }
    public override void Aide()
    {
        if (terrainOccupe.plante != null)
            terrainOccupe.plante.Lumiere += 5;
    }




}