using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using NUnit.Framework;
using TestNinja.Fundamentals;

namespace TestNinja.UnitTests
{
    [TestFixture]
   public class CustomerControllerTests
   {
       [Test]
       public void getCustomer_IdIsZero_ShouldReturnNotFound()
       {
           var controller = new CustomerController();
           var result = controller.GetCustomer(0);

           //result must be notFound object
           Assert.That(result,Is.TypeOf<NotFound>());
           //result shoud be NotFound object or one of its derivatives
           //Assert.That(result, Is.InstanceOf<NotFound>());

        }

       [Test]
       public void getCustomer_IdIsNOTZero_ShouldReturnOK()
       {
           var controller = new CustomerController();
           var result = controller.GetCustomer(1);

           Assert.That(result, Is.TypeOf<Ok>());
       }
    }
}
