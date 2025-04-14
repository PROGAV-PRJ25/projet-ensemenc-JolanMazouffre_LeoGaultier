using System.Diagnostics.CodeAnalysis;

public class Terrain
{
    public string[] attribut;
    public string type;
    public Plantes? plante;
    public Terrain(int attribut,string type){
        this.attribut=attribut;
        this.type=type;

    }
    public override string ToString(){
        return (plante) ? $"{type}/{plante}":$"{type}/vide";
    }
}