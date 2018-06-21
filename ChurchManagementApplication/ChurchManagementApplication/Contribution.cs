using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchManagementApplication
{
    public class Contribution
    {

        public int ContributionNo { get; set; }
        public int MemberID { get; set; }
        public DateTime ContributionDate { get; set; }
        public double Amount { get; set; }
        public string Method { get; set; }
        public int CheckNo { get; set; }
        public string DesignatedFund { get; set; }
    }
}
