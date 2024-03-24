public class Queries {

    public void LastNames(List<Employee> EmployeeList) {

        var LastNamesQuery = 
            from e in EmployeeList
            select new {
                LastName = e.LastName
            };

        foreach (var LastName in LastNamesQuery) {
            Console.WriteLine(LastName.LastName);
        }
    }

    public void EmployeeRegions(List<Employee> EmployeeList, List<Regions> RegionsList, 
                                List<Territories> TerritoriesList, List<EmployeeTerritories> EmployeeTerritoriesList) {
        var EmployeeRegionsQuery = 
            from e in EmployeeList
            join et in EmployeeTerritoriesList on e.EmployeeId equals et.EmployeeId
            join t in TerritoriesList on et.TerritoryId equals t.TerritoryId
            join r in RegionsList on t.RegionId equals r.RegionId

            select new {
                LastName = e.LastName,
                TerritoryDescription = t.TerritoryDescription,
                RegionDescription = r.RegionDescribtion  
            };

        foreach (var er in EmployeeRegionsQuery) {
            Console.WriteLine($"Employee Last Name: {er.LastName}, Region: {er.RegionDescription}, Territory: {er.TerritoryDescription}");
        }
    }

    public void GroupedRegions (List<Employee> EmployeeList, List<Regions> RegionsList, 
                                List<Territories> TerritoriesList, List<EmployeeTerritories> EmployeeTerritoriesList){

        var GroupedRegionsQuery = 
            from r in RegionsList
            select new {
                Region = r.RegionDescribtion,
                Employees = (
                    from e in EmployeeList
                    join et in EmployeeTerritoriesList on e.EmployeeId equals et.EmployeeId
                    join t in TerritoriesList on et.TerritoryId equals t.TerritoryId
                    join rr in RegionsList on t.RegionId equals rr.RegionId

                    where r.RegionId == rr.RegionId

                    select e.LastName
                ).ToList()
            };


        foreach(var region in GroupedRegionsQuery) {
            Console.WriteLine($"Region: {region.Region}, Employees:");

            foreach(var employee in region.Employees) {
                Console.WriteLine(employee);
            }
        }
    }

    public void CountRegions (List<Employee> EmployeeList, List<Regions> RegionsList, 
                                List<Territories> TerritoriesList, List<EmployeeTerritories> EmployeeTerritoriesList){

        var CountRegionsQuery =
            from r in RegionsList
            select new {
                Region = r.RegionDescribtion,
                EmployeesCount = (
                    from e in EmployeeList
                    join et in EmployeeTerritoriesList on e.EmployeeId equals et.EmployeeId
                    join t in TerritoriesList on et.TerritoryId equals t.TerritoryId
                    join rr in RegionsList on t.RegionId equals rr.RegionId

                    where r.RegionId == rr.RegionId

                    select e.EmployeeId
                ).ToList().Count
            };

        foreach(var region in CountRegionsQuery) {
            Console.WriteLine($"Region: {region.Region}, Employees numer: {region.EmployeesCount}");
        }
    }

}