using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchManagementApplication
{
    public class Member
    {
        public int MemberID { get; set; }
        public string LastName { get; set; }
        public string FirstName { get; set; }
        public string Honorific { get; set; }
        public string Gender { get; set; }
        public DateTime BirthDate { get; set; }
        public string MaritalStatus { get; set; }
        public string Address { get; set; }
        public string City { get; set; }
        public string State { get; set; }
        public int Zip { get; set; }
        public string Phone { get; set; }
        public string Email { get; set; }
        public string MemberType { get; set; }
        public DateTime MembershipDate { get; set; }
        public DateTime AttendanceBeginDate { get; set; }
        public DateTime AttendanceLastDate { get; set; }
    }
}
