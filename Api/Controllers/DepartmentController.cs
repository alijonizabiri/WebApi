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
    public List<Department> GetDepartments()
    {
        return _departmentService.GetDepartmentList();
    }

    [HttpPost ("InsertDepartment")]
    public int InsertDepartment(InsertDepartment department)
    {
        return _departmentService.InsertDepartment(department);
    }

    [HttpGet("GetDepartmentById")]
    public Department GetDepartmentById(int id)
    {
        var result = _departmentService.GetDepartmentById(id);
        return result;
    }

    [HttpPut("UpdateDepartment")]
    public int UpdateDepartment(InsertDepartment department, int Id)
    {
        return _departmentService.UpdateDepartment(department, Id);
    }
}