using Domain;

public interface IDepartmentService
{
    public Department GetDepartmentById(int Id);
    public int InsertDepartment(InsertDepartment department);
    public int UpdateDepartment(InsertDepartment department, int Id);
    public List<Department> GetDepartmentList();
}