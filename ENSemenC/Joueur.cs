public class Joueur
{
    protected double argent;
    public Dictionary<string, Ressource> inventaire;
    public List<Potager> potagers;

    public Joueur()
    {
        this.argent = 0;
        potagers = [new Potager(4, 30)];
        inventaire = new Dictionary<string, Ressource> { { "Eau", new Eau(4) } };
    }

    public void Ajouter(Ressource ressource)
    {
        inventaire.Add(ressource.nom, ressource);
    }
    public void Arroser(Plantes plante)
    {
        inventaire["Eau"].quantite -= 1;
        plante.Arroser(30);
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