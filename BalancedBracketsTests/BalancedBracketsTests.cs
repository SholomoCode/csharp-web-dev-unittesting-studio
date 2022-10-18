using Microsoft.VisualStudio.TestTools.UnitTesting;
using BalancedBracketsNS;

namespace BalancedBracketsTests
{
    [TestClass]
    public class BalancedBracketsTests
    {
        // TODO: Add tests to this file.

        [TestMethod]
        public void EmptyTest()
        {
            Assert.AreEqual(true, true);
        }

        [TestMethod]
        public void ExampleTest1()
        {
            Assert.AreEqual(BalancedBrackets.HasBalancedBrackets("[LaunchCode]"),true);

        }

        [TestMethod]
        public void ExampleTest2()
        {
            Assert.IsTrue(BalancedBrackets.HasBalancedBrackets("[]"));

        }

        [TestMethod]
        public void NoBrackets()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("This should be false"));

        }

        [TestMethod]
        public void ExampleTest3()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[la[nch[cod[e"
));
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("]launchcode["

           ));
        }

        [TestMethod]
        public void ExampleTest4()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("{LaunchCode}"
));
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets("[launchcode)"
));

        }
        [TestMethod]
        public void EmptyString()
        {
            Assert.IsFalse(BalancedBrackets.HasBalancedBrackets(""));

        }

    }
}
