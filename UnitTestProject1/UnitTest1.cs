using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Day3.Controllers; 

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
      public void TestMethod3()
        {

            // les 3 a 
            // Arrange  : ntsutuw el clqss vqlues controller

            var contrller = new ValuesController();

            //Act 
        var resultat =    contrller.multi(0,0);
                 
            //Assert : verifier le output 
            Assert.AreEqual(-1, resultat);
        }
        [TestMethod]

        public void TestMethod2()
        {

            // les 3 a 
            // Arrange  : ntsutuw el clqss vqlues controller

            var contrller = new ValuesController();

            //Act 
            var resultat = contrller.multi(2, 2);

            //Assert : verifier le output 
            Assert.AreEqual(0, resultat);
        }
    }
}
