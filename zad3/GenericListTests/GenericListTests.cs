using Microsoft.VisualStudio.TestTools.UnitTesting;
using GenericList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GenericList.Tests
{
    [TestClass]
    public class AssignmentTests
    {
        [TestMethod]
        public void Enumerable_10Points()
        {
            IGenericList<int> list = new GenericList<int>();

            for (int i = 0; i < 100; i++)
            {
                list.Add(-i);
            }

            foreach (var i in list)
            {
                Assert.AreEqual(i, list.GetElement(-i));
            }
        }
    }
}