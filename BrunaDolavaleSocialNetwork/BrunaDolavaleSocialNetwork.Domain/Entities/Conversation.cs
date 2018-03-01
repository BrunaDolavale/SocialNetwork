using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrunaDolavaleSocialNetwork.Domain.Entities
{
    public class Conversation
    {
        public int Id { get; set; }
        public int IdFirst { get; set; }
        public int IdSecond { get; set; }
        public Profile Profile { get; set; }
        public Message Messages { get; set; }
    }
}
