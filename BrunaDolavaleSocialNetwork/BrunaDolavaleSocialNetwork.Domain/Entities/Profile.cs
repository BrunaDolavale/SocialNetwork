using System;
using System.Collections.Generic;

namespace BrunaDolavaleSocialNetwork.Domain.Entities
{
    public class Profile
    {
        public int Id { get; set; }
        public string Password { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public DateTime Birth { get; set; }
        public bool Gender { get; set; }
        public string Sexuality { get; set; }
        public string Description { get; set; }
        public int CellphoneNumber { get; set; }
        public string Email { get; set; }
        public string SchoolLevel { get; set; }
        public string Office { get; set; }
        public string PhotoProfile { get; set; }
    }
}
