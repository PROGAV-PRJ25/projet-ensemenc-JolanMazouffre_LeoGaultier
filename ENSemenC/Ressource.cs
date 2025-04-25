public abstract class Ressource
{
    public string ?nom;
    public double prixVente;
    public double prixAchat;
    public Ressource()
    {
    }
    public abstract void Utiliser();
    public abstract void Effet();
}