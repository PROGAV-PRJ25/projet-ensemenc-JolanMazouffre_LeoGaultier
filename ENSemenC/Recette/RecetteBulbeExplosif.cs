public class RecetteBulbeExplosif : Recette
{
    public RecetteBulbeExplosif() : base(new List<Ressource> { new BulbeVerdichouffe(4) }, new BulbeExplosif(1))
    {
    }
}