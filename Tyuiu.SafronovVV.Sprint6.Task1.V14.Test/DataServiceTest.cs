using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

using Tyuiu.SafronovVV.Sprint6.Task1.V14.Lib;

namespace Tyuiu.SafronovVV.Sprint6.Task1.V14.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService service1 = new DataService();
            double[] TestA = new double[] { -2.15, -2.57, -3, -3.83, -11.70, 3, 2.19, 3.31, 2.97, 1.18, 0.03 };
            CollectionAssert.AreEqual(TestA, service1.GetMassFunction(-5, 5));
        }
    }
}
