public class Joueur
{
    public int argent;
    public Dictionary<string, Ressource> inventaire;
    public List<Potager> potagers;

    public Joueur()
    {
        this.argent = 200;
        potagers = [new Potager(4, 30, [new Eau(0), new GraineVerdichouffe(0)])];
        inventaire = new Dictionary<string, Ressource> { { "Eau", new Eau(4) } };
        Ajouter(new GraineVerdichouffe(3));
    }
    public bool DansInventaireTest(Ressource ressource)
    {
        foreach (KeyValuePair<string, Ressource> element in inventaire)
        {
            if (ressource.nom == element.Key)
            {
                return true;
            }
        }
        return false;
    }
    public void Ajouter(Ressource ressource)
    {
        if (DansInventaireTest(ressource))
        {
            inventaire[ressource.nom].quantite += ressource.quantite;
        }
        else
        {
            inventaire.Add(ressource.nom, ressource);
        }
    }
    public void Arroser(Terrain terrain)
    {
        inventaire["Eau"].quantite -= 1;
        terrain.plante?.Arroser(30);
    }
    public void Recolter(Terrain terrain)
    {
        if (terrain.plante != null)
        {
            if (terrain.plante.RecoltePret())
            {
                Ajouter(terrain.plante.fruit);
                terrain.plante = null;
            }
        }
    }
    public void Planter(Terrain terrain, string plante)
    {
        terrain.Planter(plante);
    }

    public override string ToString()
    {
        string message = $"Argent: {argent} ";
        foreach (KeyValuePair<string, Ressource> ressource in inventaire)
        {
            message += $"| {ressource.Key}, amount: {ressource.Value.quantite} ";
        }
        return message;
    }
}