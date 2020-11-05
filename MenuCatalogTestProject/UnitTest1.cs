using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using BigMammaUML3;

namespace MenuCatalogTestProject
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            MenuCatalog m = new MenuCatalog();
            Assert.AreEqual(m.Count, 0);

            m.Add(new Pizza(true, 1, "Margheritta", "med tomat og ost", 55, MenuType.Pizza, false, false));
            Assert.AreEqual(m.Count, 1);
        }

        [TestMethod]
        public void TestMethod2()
        {
            MenuCatalog e = new MenuCatalog();
            e.Add(new Pizza(true, 1, "Margheritta", "med tomat og ost", 55, MenuType.Pizza, false, false));
            Assert.AreEqual(e.Count, 1);
            e.Delete(1);
            Assert.AreEqual(e.Count, 0);
        }
    }
}
