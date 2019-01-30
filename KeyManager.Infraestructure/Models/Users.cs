using System;
using System.Collections.Generic;

namespace KeyManager.Infraestructure.Models
{
    public partial class Users
    {
        public Users()
        {
            Applications = new HashSet<Applications>();
        }

        public Guid Id { get; set; }
        public string Name { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime? LastLoginDate { get; set; }
        public byte[] BioData { get; set; }

        public ICollection<Applications> Applications { get; set; }
    }
}
