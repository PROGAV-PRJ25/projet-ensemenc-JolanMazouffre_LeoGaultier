public abstract class Plantes
{
    protected bool vivace;
    protected int nombreEtape;
    protected double temps;
    protected int[] tempsDeCroissance;
    protected int tempsMax;
    protected int soif;
    protected int soifMin;
    protected int lumiere;
    protected int lumiereMin;
    protected string[] attributPref;
    protected bool malade;
    protected int nFruits;
    protected int nLoot;
    protected Ressource fruit;
    protected Ressource loot;

    protected int Soif
    {
        get
        {
            return soif;
        }
        set
        {
            if (soif + value < 100)
            {
                soif += value;
            }
            else
                soif = 100;
        }
    }
    protected int Lumiere
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


    public Plantes(bool vivace, int nombreEtape, int[] tempsDeCroissance, int tempsMax, int soif, int soifMin, int lumiere, int lumiereMin, string[] attributPref, int nFruits, int nLoot, Ressource fruit, Ressource loot)
    {
        this.vivace = vivace;
        this.nombreEtape = nombreEtape;
        this.tempsDeCroissance = tempsDeCroissance;
        this.tempsMax = tempsMax;
        this.soif = soif;
        this.soifMin = soifMin;
        this.lumiere = lumiere;
        this.lumiereMin = lumiereMin;
        this.attributPref = attributPref;
        malade = false;
        this.nFruits = nFruits;
        this.nLoot = nLoot;
        this.fruit = fruit;
        this.loot = loot;

    }
    public void Arroser(int Value)
    {
        soif += Value;
    }
}