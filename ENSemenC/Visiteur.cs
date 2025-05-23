public abstract class Visiteur
{

    public string nom;
    public Terrain terrainOccupe;
    public Visiteur(string nom, Terrain terrainOccupe)
    {
        this.nom = nom;
        this.terrainOccupe = terrainOccupe;
    }
    public abstract void Action();
    public abstract void ModeReel(Joueur joueur, Affichage affichage);
    public virtual string[] Sprite()
    {
        return [];
    }

}