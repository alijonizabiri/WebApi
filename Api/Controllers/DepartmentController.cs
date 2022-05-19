using Domain;
using Microsoft.AspNetCore.Mvc;

[ApiController]
[Route ("api/[controller]")]
public class DepartmentController : ControllerBase
{
    private IDepartmentService _departmentService;
    public DepartmentController(IDepartmentService departmentService)
    {
        _departmentService = departmentService;
    }

    [HttpGet("GetDepartments")]
    public async Task<List<Department>> GetDepartments()
    {
        return await  _departmentService.GetDepartmentList();
    }

    [HttpPost ("InsertDepartment")]
    public async Task<int> InsertDepartment(InsertDepartment department)
    {
        return await _departmentService.InsertDepartment(department);
    }

    [HttpGet("GetDepartmentById")]
    public async Task<Department> GetDepartmentById(int id)
    {
        var result = _departmentService.GetDepartmentById(id);
        return await result;
    }

    [HttpPut("UpdateDepartment")]
    public async Task<int> UpdateDepartment(InsertDepartment department, int Id)
    {
        return await _departmentService.UpdateDepartment(department, Id);
    }
}