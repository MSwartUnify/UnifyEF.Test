using Microsoft.EntityFrameworkCore;
using Unify.EFTest.Data;
using Unify.EFTest.Data.EntityModels;

namespace Unify.EFTest.Service.Clients;

public class ClientService : IClientService
{
    private readonly DatabaseContext _DatabaseContext;

    public ClientService(DatabaseContext databaseContext)
    {
        _DatabaseContext = databaseContext;
    }

    /// <inheritdoc />
    // public IEnumerable<ClientEntity> GetClientsWithUsers()
    // {
    //     return null;
    // }
}