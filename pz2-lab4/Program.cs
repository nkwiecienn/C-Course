using System.ComponentModel.Design;

public class Program {
    public static void Main() {
        Reader<Employee> EmployeeReader = new();
        Reader<Regions> RegionsReader = new();
        Reader<Territories> TerritoriesReader = new();
        Reader<EmployeeTerritories> EmployeeTerritoriesReader = new();

        List<Employee> EmployeeList = EmployeeReader.Generate(@"C:\Users\natal\VS Projects\pz2-lab4\data\import-northwind-dataset\employees.csv", 
                                        x => new Employee(x[0], x[1], x[2], x[3], x[4], x[5], x[6], x[7], x[8], 
                                        x[9], x[10], x[11], x[12], x[13], x[14], x[15], x[16], x[17]));
        List<Regions> RegionsList = RegionsReader.Generate(@"C:\Users\natal\VS Projects\pz2-lab4\data\import-northwind-dataset\regions.csv",
                                        x => new Regions(x[0], x[1]));
        List<Territories> TerritoriesList = TerritoriesReader.Generate(@"C:\Users\natal\VS Projects\pz2-lab4\data\import-northwind-dataset\territories.csv",
                                        x => new Territories(x[0], x[1], x[2]));
        List<EmployeeTerritories> EmployeeTerritoriesList = EmployeeTerritoriesReader.Generate(@"C:\Users\natal\VS Projects\pz2-lab4\data\import-northwind-dataset\employee_territories.csv",
                                        x => new EmployeeTerritories(x[0], x[1]));


        Queries queries = new();

        Console.WriteLine("Wybierz nazwiska wszystkich pracowników");

        queries.LastNames(EmployeeList);

        Console.WriteLine("Wypisz nazwiska pracowników oraz dla każdego z nich nazwę regionu i terytorium gdzie pracuje");

        queries.EmployeeRegions(EmployeeList, RegionsList, TerritoriesList, EmployeeTerritoriesList);

        Console.WriteLine("Wypisz nazwy regionów oraz nazwiska pracowników, którzy pracują w tych regionach");

        queries.GroupedRegions(EmployeeList, RegionsList, TerritoriesList, EmployeeTerritoriesList);

        Console.WriteLine("Wypisz nazwy regionów oraz liczbę pracowników w tych regionach");

        queries.CountRegions(EmployeeList, RegionsList, TerritoriesList, EmployeeTerritoriesList);

    }
}
