using System;
using System.Collections.Generic;
using System.Collections;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.Model
{
    public class Customer
    {

        private string _cPnr;
        private string _cMail;
        private string _cName;

        public Customer() { }

        public string cPnr
        {
            get { return cPnr; }
            set { cPnr = value; }
        }

        public string cMail
        {
            get { return cMail; }
            set { cMail = value; }
        }

        public string cName
        {
            get { return cName; }
            set { cName = value; }
        }
        
        
        public List<Reservation> reservations
           {
               get { return reservations; }
               set { reservations = value; }
           }
    }
}

