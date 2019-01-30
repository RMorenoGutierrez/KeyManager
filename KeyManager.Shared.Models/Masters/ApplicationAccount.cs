using System;
using System.Collections.Generic;
using System.Text;
using KeyManager.Shared.Models.Masters.Base;

namespace KeyManager.Shared.Models.Masters
{
    public class ApplicationAccount : HistoricModelBase
    {
        public string Description { get; set; }
        public DateTime LastModificationPwdDate { get; set; }
        public string Mail { get; set; }
        public string User { get; set; }
        public string Pwd { get; set; }

        public Application Application { get; set; }
    }
}
