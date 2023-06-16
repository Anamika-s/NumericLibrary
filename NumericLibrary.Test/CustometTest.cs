using Moq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumericLibrary.Test
{
    internal class CustomerTest
    {
        [Test]
        public void AdCustomerTest()
        {
            Mock<EMail> email = new Mock<EMail>();

            Customer customer = new Customer();
             
            email.Setup(x=>x.SendMail()).Returns(true);
            bool actual = customer.AddCustomer(email.Object);
            Assert.AreEqual(true, actual);

        }
    }
}
