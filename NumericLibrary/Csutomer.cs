using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericLibrary
{
    public class Customer
    {
        public virtual bool AddCustomer(EMail email)
        {
            //EMail email = new EMail();
            bool msg = email.SendMail();
            return msg;
        }
    }
}
