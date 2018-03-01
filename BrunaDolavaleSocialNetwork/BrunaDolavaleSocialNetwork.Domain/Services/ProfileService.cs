using BrunaDolavaleSocialNetwork.Domain.Entities;
using BrunaDolavaleSocialNetwork.Domain.Interfaces;
using BrunaDolavaleSocialNetwork.Domain.Interfaces.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrunaDolavaleSocialNetwork.Domain.Services
{
    public class ClientService : BaseService<Profile>, IProfileService
    {
        private readonly IProfileRepository repository;

        public ClientService(IProfileRepository clientRepository)
            : base(clientRepository)
        {
            repository = clientRepository;
        }

        public IEnumerable<Profile> GetSpecialClients(IEnumerable<Profile> profiles)
        {
            return null;
            //return profiles.Where(c => c.SpecialClient(c));
        }
    }

}
