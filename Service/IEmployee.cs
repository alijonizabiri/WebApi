using Domain;

public interface IEmployeeService
{
    public Employee GetEmployeeById(int Id);
    public int InsertEmployee(InsertEmployee employee);
    public int UpdateEmployee(InsertEmployee employee, int Id);
    public List<Employee> GetEmployees();
}