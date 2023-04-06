using Microsoft.VisualStudio.TestTools.UnitTesting;
using PaymentContext.Domain.Entities;

namespace PaymentContext.Test.Entities;

[TestClass]
public class StudentTest
{

    [TestMethod]
    public void TestMethod1()
    {
        var student = new Student("Bruce", "Wayne", "123456789", "brucewayne@hotmail.com");
    }
}
