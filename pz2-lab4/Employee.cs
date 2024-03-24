public class Employee {
    public String EmployeeId {get; set;}
    public String LastName {get; set;}
    public String FirstName {get; set;}
    public String Title {get; set;}
    public String TitleOfCourtesy {get; set;}
    public String BirthDate {get; set;}
    public String HireDate {get; set;}
    public String Address {get; set;}
    public String City {get; set;}
    public String Region {get; set;}
    public String PostalCode {get; set;}
    public String Country {get; set;}
    public String HomePhone {get; set;}
    public String Extension {get; set;}
    public String Photo {get; set;}
    public String Notes {get; set;}
    public String Reportsto {get; set;}
    public String Photopath {get; set;}

    public Employee(string employeeId, string lastName, string firstName, string title, 
                    string titleOfCourtesy, string birthDate, string hireDate, string address, 
                    string city, string region, string postalCode, string country, 
                    string homePhone, string extension, string photo, string notes, 
                    string reportsto, string photopath) 
    {
        EmployeeId = employeeId;
        LastName = lastName;
        FirstName = firstName;
        Title = title;
        TitleOfCourtesy = titleOfCourtesy;
        BirthDate = birthDate;
        HireDate = hireDate;
        Address = address;
        City = city;
        Region = region;
        PostalCode = postalCode;
        Country = country;
        HomePhone = homePhone;
        Extension = extension;
        Photo = photo;
        Notes = notes;
        Reportsto = reportsto;
        Photopath = photopath;
    }
}