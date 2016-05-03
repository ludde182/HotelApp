using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HotelApp.Exception
{
    class HandleException : System.Exception
    {
        public HandleException ()
        {

        }

        public string errMessage { get; set; }

        public HandleException(string errMsg)
        {
            errMessage = errMsg;
        }
    }
}
