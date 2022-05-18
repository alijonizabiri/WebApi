namespace Domain;
public class InsertEmployee
{
    public int Id { get; set; }
    public  string? FirsName { get; set; }
    public  string? LastName { get; set; }
    public  int Gender { get; set; }
    public  DateTime HireDate { get; set; }
    public  DateTime BirthDate { get; set; }
    }

    public class Employee
{
    public int Id { get; set; }
    public string? FullName { get; set; }
    public int DepartmentId  { get; set; }
    public string? DepartmentName { get; set; }
}

