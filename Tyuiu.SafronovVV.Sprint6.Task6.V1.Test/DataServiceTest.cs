using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.IO;
using Tyuiu.SafronovVV.Sprint6.Task6.V1.Lib;

namespace Tyuiu.SafronovVV.Sprint6.Task6.V1.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\DataSprint6\InPutFileTask6V1.txt";
            FileInfo info = new FileInfo(path);
            bool res = info.Exists;
            bool wait = true;
            Assert.AreEqual(wait, res);
        }
    }
}
