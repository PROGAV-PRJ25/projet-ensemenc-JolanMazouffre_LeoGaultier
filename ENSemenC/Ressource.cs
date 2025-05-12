
using System.Security.Cryptography.X509Certificates;

public abstract class Ressource
{
    public string nom;
    public int prixVente;
    public int prixAchat;
    public int quantite;
    public Ressource(string nom, int prixAchat, int quantite)
    {
        this.nom = nom;
        this.prixAchat = prixAchat;
        prixVente = prixAchat / 2;
        this.quantite = quantite;
    }
    public virtual void ActionGraine(List<Graine> listGraine) { }
    public override string ToString()
    {
        return $"{nom}  prix : {prixAchat}";
    }


}