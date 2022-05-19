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
    public async Task<int> InsertManager(InsertManager manager)
    {
        var result = _managerService.InsertManager(manager);
        return await result;
    }

    [HttpGet ("GetManagers")]
    public async Task<List<Manager>> GetManagers()
    {
        var result = _managerService.GetManagers();
        return await result;
    }
}
