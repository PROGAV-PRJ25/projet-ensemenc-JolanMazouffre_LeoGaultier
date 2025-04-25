public abstract class Ressource
{
    public string nom;
    public double prix;
    public Ressource(string nom, double prix)
    {
        this.nom = nom;
        this.prix = prix;
    }
    public abstract void Utiliser();
    public abstract void Effet();
    
}