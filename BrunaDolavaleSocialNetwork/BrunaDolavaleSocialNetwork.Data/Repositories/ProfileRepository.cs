using BrunaDolavaleSocialNetwork.Domain.Entities;
using BrunaDolavaleSocialNetwork.Domain.Interfaces;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrunaDolavaleSocialNetwork.Data.Repositories
{
    public class ProfileRepository : BaseRepository<Profile>, IProfileRepository
    {
    }
}