using System.Collections.Generic;
using BrunaDolavaleSocialNetwork.Domain.Entities;

namespace BrunaDolavaleSocialNetwork.Application.Interfaces
{
    public interface IClientAppService : IBaseAppService<Profile>
    {
        IEnumerable<Profile> GetSpecialClients();
    }
}
