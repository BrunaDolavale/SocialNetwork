using BrunaDolavaleSocialNetwork.Domain.ValueObjects;
using System;
using System.Collections.Generic;

namespace BrunaDolavaleSocialNetwork.Domain.Entities
{
    public class Profile
    {
        public Guid Id { get; set; }
        public Password Password { get; set; }
        public Name Name { get; set; }
        public LastName LastName { get; set; }
        public DateTime Birth { get; set; }
        public Gender Gender { get; set; }
        public Sexuality Sexuality { get; set; }
        public Description Description { get; set; }
        public CellphoneNumber CellphoneNumber { get; set; }
        public Email Email { get; set; }
        public SchoolLevel SchoolLevel { get; set; }
        public Office Office { get; set; }
        public PhotoProfile PhotoProfile { get; set; }
    }
}
