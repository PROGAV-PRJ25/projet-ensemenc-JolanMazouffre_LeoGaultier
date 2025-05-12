public class Verdichouffe : Plantes
{
    public Verdichouffe(int soif, int lumiere) : base("Verdichouffe", false, new int[] { 2, 4 }, 9, 5, soif, 50, lumiere, 30, new string[] { "humide", "doux" }, new BulbeVerdichouffe(1), null)
    {

    }
}