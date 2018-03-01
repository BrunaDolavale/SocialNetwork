using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BrunaDolavaleSocialNetwork.Domain.Entities
{
    public class Message
    {
        public int Id { get; set; }
        public int IdFirst { get; set; }
        public int IdSecond { get; set; }
        public string Content { get; set; }
        public DateTime Date { get; set; }
    }
}
