using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.Model
{

    public class Reservation
    {
        public long resID
        {
            get { return resID; }
            set { resID = value; }
        }

        public int rWeek
        {
            get { return rWeek; }
            set { rWeek = value; }
        }

        public Cabin cabin
        {
            get { return cabin; }
            set { cabin = value; }
        }


        public Customer customer
        {
            get { return customer; }
            set { customer = value; }
        }
    }
}

