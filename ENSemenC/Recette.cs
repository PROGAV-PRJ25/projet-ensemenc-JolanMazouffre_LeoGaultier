using System.Reflection.Metadata;
//L'affichage qui concerne les recettes ce fera de façons rudimentaire...
public abstract class Recette
{
    public List<Ressource> ingredients;
    public Ressource resultat;
    public Recette(List<Ressource> ingredients, Ressource resultat)
    {
        this.ingredients = ingredients;
        this.resultat = resultat;
    }

    public void Craft(Joueur joueur)
    {
        bool craftable = true;
        string alertImpossible = "Vous n'avez pas assez de ressources pour fabriquer cet objet :\n";
        foreach (Ressource ingredient in ingredients)
        {
            bool joueurPossede = false;
            foreach (KeyValuePair<string, Ressource> ressource in joueur.inventaire)
            {

                if (ressource.Value.nom == ingredient.nom)
                {
                    joueurPossede = true;
                    if (ressource.Value.quantite < ingredient.quantite)
                    {
                        craftable = false;
                        alertImpossible += $"Il vous manque {ingredient.quantite - ressource.Value.quantite} {ingredient.nom}\n";
                    }
                }
            }
            if (!joueurPossede)
            {
                craftable = false;
                alertImpossible += $"Vous ne savez même pas ce qu'est {ingredient.nom}\n";
            }
        }
        if (craftable)
        {
            foreach (Ressource ingredient in ingredients)
            {
                joueur.inventaire[ingredient.nom].quantite -= ingredient.quantite;
            }
            joueur.Ajouter(resultat);
            Console.Clear();
            Console.WriteLine($"Vous avez fabriqué {resultat.nom} !\n");
            Console.ReadKey();
        }
        else
        {
            Console.Clear();
            Console.WriteLine(alertImpossible);
            Console.ReadKey();
        }


    }
}