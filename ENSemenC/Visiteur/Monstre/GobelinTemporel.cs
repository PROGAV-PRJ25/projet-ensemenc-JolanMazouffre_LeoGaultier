public class GobelinTemporel : Monstre
{
    public GobelinTemporel(Terrain terrinOccupe) : base("Gobelin Temporel", terrinOccupe, new BulbeExplosif(1), new CoeurDeGobelin(1))
    {

    }

    public override string[] Sprite()
    {
        return [
            "                   ",
            "                   ",
            "                   ",
            "                   ",
            "                   ",
            "                   ",
            "                   ",
            "      █████████    ",
            "     ██ █  █  ███  ",
            "    ██          █  ",
            "    █████████████  ",
            "        ███        ",
            "      █████████    ",
            "     ██ ███   █    ",
            "        ███        ",
            "        ███        ",
            "        ███        ",
            "       █████       ",
            "      ██████       ",
            "      █     █      ",
            "      █     █      ",
            "      █     █      ",
            "      ▄▄▄   ▄▄▄    "
        ];
    }
    public override void Action()
    {
        Console.Clear();
        if (terrainOccupe.plante != null)
        {
            terrainOccupe.plante.temps -= 2;
            Console.WriteLine("Le gobelin temporel manipule le temps et fait rajeunir la plante de 2 semaines !");
            if (terrainOccupe.plante.temps < 0)
            {
                Console.WriteLine($"la {terrainOccupe.plante?.nom} à été tué par le gobelin temporel car elle n'avait pas plus de 2 semaines !");
                terrainOccupe.plante = null;
            }
        }
        Console.ReadKey();
    }


}