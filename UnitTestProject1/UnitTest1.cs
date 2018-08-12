using CIV_UnitTesting_Exercises;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            RecursiveCalculations rc = new RecursiveCalculations();
            var f = rc.FibocacciRec(0,5,1);
            Assert.AreEqual(f, 5);
            //Fail

            //Could not work around the fail. Had no idea what this does.
            //Sub needs better documentation.
        }

        [TestMethod]
        public void TestMethod2()
        {
            RecursiveCalculations rc = new RecursiveCalculations();
            var f = rc.FactorialRec(5,1);
            Assert.AreEqual(f, 120);
            //Pass
        }

        [TestMethod]
        public void TestMethod3()
        {
            RecursiveCalculations rc = new RecursiveCalculations();
            var f = rc.FibCheck(5);
            Assert.IsTrue(f);
            //Pass
        }
    }
}
