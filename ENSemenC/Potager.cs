public class Potager
{
    public int place;
    public List<Terrain> terrains;
    public enum Meteo { pluvieux, soleil }
    public Meteo meteo;
    public int chanceVisite;
    public Potager(int place,int chanceVisite){
        this.place=place;
        for (int i=1;i==place;i++){
            terrains.add(CreeTerrain);
        }
        this.chanceVisite=chanceVisite;
        
    }
    public Terrain CreeTerrain(){
       Random rng = new Random();
       int tirage=rng.next(1,5);
       if (tirage==1){
        return new TerrainDesert();
       }
       if (tirage==2){
        return new TerrainForet();
       }
       if (tirage==3){
        return new TerrainPlain();
       }
       if (tirage==4){
        return new TerrainGlace();
       }
       else
       {
        return null;
       }

    }
    public override string ToString(){
        string retour="";
        foreach (Terrain terrain in Terrain)
        {
            retour+=terrain.ToString;
        }
        return retour;
    }
}