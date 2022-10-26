using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManagementBranchUI.ManagementBranchData
{
    public class ManagementBranchData
    {
        public string ID { get; set; }
        public string ManagementBranchName { get; set; }
        public ManagementData Director { get; set; }
        public ManagementData Lawyer { get; set; }
    }
}
