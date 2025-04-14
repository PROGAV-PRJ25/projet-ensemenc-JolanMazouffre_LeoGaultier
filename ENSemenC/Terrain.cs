using System.Diagnostics.CodeAnalysis;

public class Terrain
{
    public string[] attribut;
    public string type;
    public Plantes? plante;
    public Terrain(string[] attribut, string type)
    {
        this.attribut = attribut;
        this.type = type;

    }
    public override string ToString()
    {
        return (plante == null) ? $"{type}/vide" : $"{type}/{plante}";
    }
}