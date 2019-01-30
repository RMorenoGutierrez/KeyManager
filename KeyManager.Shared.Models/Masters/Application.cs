using System;
using System.Collections.Generic;
using System.Text;
using KeyManager.Shared.Models.Masters.Base;

namespace KeyManager.Shared.Models.Masters
{
    public class Application : ModelBase
    {
        public string Description { get; set; }
        public string Url { get; set; }

        public User User { get; set; }

        public IEnumerable<ApplicationAccount> ApplicationAccounts { get; set; }

    }
}
