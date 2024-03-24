public class EmployeeTerritories {
    public String EmployeeId {get; set;}
    public String TerritoryId {get; set;}

    public EmployeeTerritories(string employeeId, string territoryId) {
        EmployeeId = employeeId;
        TerritoryId = territoryId;
    }
}