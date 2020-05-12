using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using CuttingRodApp;

namespace UnitTests
{
    [TestClass]
    public class RodCuttingManagerTest
    {
        [TestMethod]
        public void TestButtomUpCutRodExtendedMethod()
        {
            int size = 10;
            int[] tab = new int [] {1, 2, 3, 4, 5, 6, 7};
            RodCuttingManager rCM = new RodCuttingManager(size, tab);

            //Assert.AreEqual();
        }
    }
}
