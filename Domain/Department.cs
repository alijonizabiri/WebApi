namespace Domain;
public class Department
{
    public  int DepartmentId { get; set; }
    public  string? DepartmentName { get; set; }
    public int ManagerId { get; set; }
    public  string? ManagerFullName { get; set; }
   
}

public class InsertDepartment 
{
    public int Id { get; set; }
    public string? Name { get; set; }

}