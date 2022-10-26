using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementBranchUI.ManagementBranchData
{
    public class ManagementData
    {
        public string TCIN { get; set; }
        public string BranchID { get; set; }

        // Şube Müdürü ya da Şirket Avukatı
        public string Position { get; set; }

        public string Name { get; set; }
        public string Surname { get; set; }
        public string MobilePhone { get; set; }
        public string EMail { get; set; }
        public string Password { get; set; }
    }
}
