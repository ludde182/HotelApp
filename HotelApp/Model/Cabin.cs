using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.Model
{
    public class Cabin
    {

        public Cabin() { }
        

        public int cabinNo
        {
            get { return cabinNo; }
            set { cabinNo = value; }
        }

        public string cType
        {
            get { return cType; }
            set { cType = value; }
        }

        public List<Reservation> reservations
           {
               get { return reservations; }
               set { reservations = value; }
           }


    }
}
