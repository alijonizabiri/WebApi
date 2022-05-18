using Domain;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route("api/[controller]")]
public class EmployeeController : ControllerBase
{
    private IEmployeeService _employeeService;
    public EmployeeController(IEmployeeService employeeService)
    {
        _employeeService = employeeService;
    }

    [HttpGet("GetEmployeeById")]
    public Employee GetEmployeeById(int id)
    {
        var result = _employeeService.GetEmployeeById(id);
        return result;
    }

    [HttpGet ("GetEmployees")]
    public List<Employee> GetEmplloyees()
    {
        return _employeeService.GetEmployees();
    }

    [HttpPost ("InsertEmployee")]
    public int InsertEmployee(InsertEmployee employee)
    {
        var result = _employeeService.InsertEmployee(employee);
        return result;
    }

    [HttpPut ("UpdateEmployee")]
    public int UpdateEmployee(InsertEmployee employee, int id)
    {
        var result = _employeeService.UpdateEmployee(employee, id);
        return result;
    }
}
