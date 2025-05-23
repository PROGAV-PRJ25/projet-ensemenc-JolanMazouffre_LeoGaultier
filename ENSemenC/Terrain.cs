using System.Diagnostics.CodeAnalysis;

public class Terrain
{

    public string[] attribut;
    public string type;
    public int eauBase;
    public int lumiereBase;
    public Plantes? plante;
    public Annimal? animalApprivoiser;
    public Terrain(string[] attribut, string type, int eau, int lumiere)
    {
        this.attribut = attribut;
        this.type = type;
        eauBase = eau;
        lumiereBase = lumiere;
        animalApprivoiser = null;

    }
    public void Planter(string nom)
    {
        switch (nom)
        {
            case "Verdichouffe":
                plante = new Verdichouffe(eauBase, lumiereBase);
                break;
            case "Arbre a Bois":
                plante = new ArbreBois(eauBase, lumiereBase);
                break;

        }
    }
    public override string ToString()
    {
        return (plante == null) ? $"{type}" : $"{type}/{plante.nom}";
    }
}