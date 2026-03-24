using System;

namespace Entities
{
    public class Users
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Srname { get; set; }
        public string IDNumber { get; set; }
        public string Mobile { get; set; }
        public string RegDate { get; set; }
        public string Nationality { get; set; }
        public string Gender { get; set; }
        public string Location { get; set; }
        public string login { get; set; }
        public string pass { get; set; }
        public bool Fired { get; set; }
        public string Role { get; set; }

        public string FullName => $"{Name} {Srname}".Trim();
    }
}