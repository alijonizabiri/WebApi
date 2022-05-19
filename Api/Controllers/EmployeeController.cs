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
    public async Task<Employee> GetEmployeeById(int id)
    {
        var result = _employeeService.GetEmployeeById(id);
        return await result;
    }

    [HttpGet ("GetEmployees")]
    public async Task<List<Employee>> GetEmplloyees()
    {
        return await _employeeService.GetEmployees();
    }

    [HttpPost ("InsertEmployee")]
    public async Task<int> InsertEmployee(InsertEmployee employee)
    {
        var result = _employeeService.InsertEmployee(employee);
        return await result;
    }

    [HttpPut ("UpdateEmployee")]
    public async Task<int> UpdateEmployee(InsertEmployee employee, int id)
    {
        var result = _employeeService.UpdateEmployee(employee, id);
        return await result;
    }
}
