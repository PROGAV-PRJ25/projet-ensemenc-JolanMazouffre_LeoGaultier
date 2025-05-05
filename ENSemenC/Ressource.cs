public abstract class Ressource
{
    public string ?nom;
    public double prixVente;
    public double prixAchat;
    public Ressource(string nom, double prixAchat)
    {
        this.nom = nom;
        this.prixAchat = prixAchat;
        this.prixVente = prixAchat*0.8;
    }
    public abstract void Utiliser();
    public abstract void Effet();
}