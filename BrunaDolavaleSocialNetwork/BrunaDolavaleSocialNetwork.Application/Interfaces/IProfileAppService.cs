using System;
using System.Collections.Generic;
using BrunaDolavaleSocialNetwork.Domain.Entities;
using System.Text;

namespace BrunaDolavaleSocialNetwork.Application.Interfaces
{
    public interface IClientAppService : IBaseAppService<Profile>
    {
        IEnumerable<Profile> GetSpecialClients();
    }

}

