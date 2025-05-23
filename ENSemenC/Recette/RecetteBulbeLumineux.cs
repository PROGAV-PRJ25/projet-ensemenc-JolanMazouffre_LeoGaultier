public class RecetteBulbeLumineux : Recette
{
    public RecetteBulbeLumineux() : base(new List<Ressource> { new BulbeExplosif(1), new Abajour(1) }, new BulbeLumineux(1))
    {
    }

}