using BrunaDolavaleSocialNetwork.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrunaDolavaleSocialNetwork.Domain.Interfaces.Services
{
    public interface IProfileService : IBaseService<Profile>
    {
        IEnumerable<Profile> GetSpecialClients(IEnumerable<Profile> profiles);
    }
}

