﻿using Tyuiu.KhabibullinMR.Sprint5.Task6.V27.Lib;

namespace Tyuiu.KhabibullinMR.Sprint5.Task6.V27.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {

        }
    
    
        [TestMethod]
        public void TestMethod2()
        {
            string path = Path.GetTempFileName();

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);

        }
    }
}
