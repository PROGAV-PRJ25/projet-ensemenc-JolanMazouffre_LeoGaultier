public class Joueur
{
    protected double argent;
    public Dictionary<Ressource, int> inventaire;
    public Joueur(double argent)
    {
        this.argent = argent;
        this.inventaire = new Dictionary<Ressource, int>();
    }
    public Joueur()
    {
        this.argent = 0;
        this.inventaire = new Dictionary<Ressource, int>();
    }
    public void Utiliser(Ressource ressource)
    {
        ressource.Utiliser();
    }
    /*
    public void Consommer(Ressource ressource)
    {
        if(!inventaire.ContainsKey(ressource))
        {
            Console.WriteLine("Pas bien");
        }
        else if(inventaire[ressource] == 1)
        {
            inventaire.Remove(ressource);
        }
        else
        {
            inventaire[ressource]--;
        }
    }
    public void Ajouter(Ressource ressource)
    {
        if(!inventaire.ContainsKey(ressource))
        {
            inventaire.Add(ressource,1);
        }
        else
        {
            inventaire[ressource]++;
        }
    }
    public void Ajouter(Ressource ressource, int nb)
    {
        if(!inventaire.ContainsKey(ressource))
        {
            inventaire.Add(ressource,nb);
        }
        else
        {
            inventaire[ressource]=+ nb;
        }
    }
    */
    public override string ToString()
    {
        string message = $"Argent: {argent} ";
        foreach (KeyValuePair<Ressource, int> rss in inventaire)
        {
            message += $"Nom ressource: {rss.Key}, amount: {rss.Value}";
        }
        return message;
    }
}