using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrunaDolavaleSocialNetwork.Domain.Entities
{
    public class Match
    {
        public int Id { get; set; }
        public int IdFirst { get; set; }
        public int IdSecond { get; set; }
        public bool FirstConfirmed { get; set; }
        public bool SecondConfirmed { get; set; }
    }
}
