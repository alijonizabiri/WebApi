using Domain;

public interface IEmployeeService
{
    public Task<Employee> GetEmployeeById(int Id);
    public Task<int> InsertEmployee(InsertEmployee employee);
    public Task<int> UpdateEmployee(InsertEmployee employee, int Id);
    public Task<List<Employee>> GetEmployees();
}