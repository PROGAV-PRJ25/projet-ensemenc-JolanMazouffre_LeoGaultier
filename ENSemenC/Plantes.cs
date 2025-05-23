
using System.Security.Cryptography.X509Certificates;

public abstract class Plantes
{
    public string nom;
    public bool vivace;
    public double temps;
    public int[] tempsDeCroissance;
    protected int tempsMax;
    protected int vitesseBoire; //Les plantes vont boires l'eau à une certaine vitesse
    protected int eau;
    protected int eauMin;
    protected int lumiere;
    protected int lumiereMin;
    protected string[] attributPref;
    protected bool malade;
    public Ressource fruit;

    public int Eau
    {
        get
        {
            return eau;
        }
        set
        {
            if (value < 100)
            {
                eau = value;
            }
            else
                eau = 100;
        }
    }
    public int Lumiere
    {
        get
        {
            return lumiere;
        }
        set
        {
            if (value < 100)
            {
                lumiere = value;
            }
            else
                lumiere = 100;
        }
    }


    public Plantes(string nom, bool vivace, int[] tempsDeCroissance, int tempsMax, int vitesseBoire, int soif, int soifMin, int lumiere, int lumiereMin, string[] attributPref, Ressource fruit)
    {
        temps = 0;
        this.vitesseBoire = vitesseBoire;
        this.attributPref = attributPref;
        this.nom = nom;
        this.vivace = vivace;
        this.tempsDeCroissance = tempsDeCroissance;
        this.tempsMax = tempsMax;
        this.eau = soif;
        this.eauMin = soifMin;
        this.lumiere = lumiere;
        this.lumiereMin = lumiereMin;
        this.attributPref = attributPref;
        malade = false;
        this.fruit = fruit;

    }
    public void Arroser(int Value)
    {
        Eau += Value;
    }
    public void Boire()
    {
        Eau -= vitesseBoire;
    }
    public override string ToString()
    {
        return RecoltePret() ? $"{nom} : eau :{eau} lumière :{lumiere} age :{temps} satisfaction :{CalculeSurvit()} => Prêt à être récolter !" : $"{nom} : eau:{eau} lumière :{lumiere} temps:{temps} satisfaction:{CalculeSurvit()}";
    }
    public int CalculeSurvit()
    {
        int survit = 0;
        survit += eau - eauMin;
        survit += lumiere - lumiereMin;
        survit += 100; // Si tout est parfait, on a 100% des critères remplis. 150%= croissance très rapide 125%= croissance rapide 100% = croissance normale, 75% = croissance lente, 50% = mort.
        return survit;
    }
    public void CalculeCroissance()
    {
        if (CalculeSurvit() >= 150)
        {
            temps += 2;
        }
        if ((150 > CalculeSurvit()) && (CalculeSurvit() >= 125))
        {
            temps += 1.25;
        }
        if ((125 > CalculeSurvit()) && (CalculeSurvit() >= 100))
        {
            temps += 1;
        }
        if ((100 > CalculeSurvit()) && (CalculeSurvit() >= 75))
        {
            temps += 0.75;
        }
        if ((75 > CalculeSurvit()) && (CalculeSurvit() >= 50))
        {
            temps += 0.5;
        }
        if (CalculeSurvit() < 50)
        {
            temps += 0;
        }

    }
    public bool CalculeMort()
    {
        if ((CalculeSurvit() < 50) || (temps > tempsMax))
        {
            return true;
        }
        else
            return false;
    }
    public bool RecoltePret()
    {
        if (temps < tempsDeCroissance[tempsDeCroissance.Length - 1])
        {
            return false;
        }
        else
            return true;
    }
    public abstract string[] Sprite();
}