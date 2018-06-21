using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ChurchManagementApplication
{
    public class Event
    {

        //Maybe only set and Increment by ++1
        //public static int EventID { get; set; }

        public string EventDate { get; set; }

        public string EventName { get; set; }

        //Retrieve minister from list of ministers?
        //filter by city flag reccomended

        public string Description { get; set; }

        private string cityName;

        public string City
        {
            get { return cityName; }
            set { cityName = value; }
        }

        public string Address { get; set; }

        public string Minister { get; set; }

        public string MinisterLN { get; set; }

        public int PhoneNum { get; set; }


    }
}
