using System;
using System.Collections.Generic;
using System.Text;
using KeyManager.Shared.Models.Masters.Base; 

namespace KeyManager.Shared.Models.Masters
{
    public class User : HistoricModelBase
    {
        public string Name { get; set; }
        public byte[] BioData { get; set; }

        public IEnumerable<Application> Applications { get; set; }
    }
}
