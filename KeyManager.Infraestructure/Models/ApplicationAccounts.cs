using System;
using System.Collections.Generic;

namespace KeyManager.Infraestructure.Models
{
    public partial class ApplicationAccounts
    {
        public Guid Id { get; set; }
        public string Description { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime EndDate { get; set; }
        public DateTime LastModificationPwdDate { get; set; }
        public string Mail { get; set; }
        public string User { get; set; }
        public string Pwd { get; set; }
        public Guid ApplicationId { get; set; }

        public Applications Application { get; set; }
    }
}
