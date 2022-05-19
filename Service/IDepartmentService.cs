using Domain;

public interface IDepartmentService
{
    public Task<Department> GetDepartmentById(int Id);
    public Task<int> InsertDepartment(InsertDepartment department);
    public Task<int> UpdateDepartment(InsertDepartment department, int Id);
    public Task<List<Department>> GetDepartmentList();
}