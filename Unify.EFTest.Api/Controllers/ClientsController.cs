using Microsoft.AspNetCore.Mvc;
using Unify.EFTest.Data.EntityModels;
using Unify.EFTest.Service.Clients;
using Unify.EFTest.Service.Departments;

namespace Unify.EFTest.Api.Controllers;

[ApiController]
[Route("[controller]")]
public class ClientsController : ControllerBase
{
    private readonly IClientService _ClientService;

    public ClientsController(IClientService clientService)
    {
        _ClientService = clientService;
    }
    
    // [HttpGet]
    // [Route("GetClientsWithUsers")]
    // public IEnumerable<ClientEntity> GetClientsWithUsers()
    // {
    //     return _ClientService.GetClientsWithUsers();
    // }
}