public abstract class Graine : Ressource
{
    public string nomPlante;
    public Graine(string nom, int prixAchat, int quantite, string nomPlante) : base(nom, prixAchat, quantite)
    {
        this.nomPlante = nomPlante;
    }

    public override void ActionGraine(List<Graine> listGraine)
    {
        listGraine.Add(this);
    }
}