using System;
using System.Collections.Generic;

namespace KeyManager.Infraestructure.Models
{
    public partial class Applications
    {
        public Applications()
        {
            ApplicationAccounts = new HashSet<ApplicationAccounts>();
        }

        public Guid Id { get; set; }
        public string Description { get; set; }
        public string Url { get; set; }
        public Guid UserId { get; set; }

        public Users User { get; set; }
        public ICollection<ApplicationAccounts> ApplicationAccounts { get; set; }
    }
}
