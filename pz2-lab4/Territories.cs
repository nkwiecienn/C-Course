public class Territories {
    public String TerritoryId {get; set;}
    public String TerritoryDescription {get; set;}
    public String RegionId {get; set;}

    public Territories(string territoryId, string territoryDescription, string regionId) {
        TerritoryId = territoryId;
        TerritoryDescription = territoryDescription;
        RegionId = regionId;
    }
}