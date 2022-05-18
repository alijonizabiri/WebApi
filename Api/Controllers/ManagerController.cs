using Domain;
using Microsoft.AspNetCore.Mvc;

namespace Api.Controllers;

[ApiController]
[Route ("api/[controller]")]
public class ManagerController : ControllerBase
{
    private IManagerService _managerService;

    public ManagerController(IManagerService managerService)
    {
        _managerService = managerService;
    }

    [HttpPost ("InsertManager")]
    public int InsertManager(InsertManager manager)
    {
        var result = _managerService.InsertManager(manager);
        return result;
    }

    [HttpGet ("GetManagers")]
    public List<Manager> GetManagers()
    {
        var result = _managerService.GetManagers();
        return result;
    }
}
