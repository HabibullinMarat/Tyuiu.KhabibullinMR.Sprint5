using Tyuiu.KhabibullinMR.Sprint5.Task0.V19.Lib;

namespace Tyuiu.KhabibullinMR.Sprint5.Task0.V19.Test
{
    [TestClass]
    public sealed class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            string path = @"C:\Users\habib\source\repos\Tyuiu.KhabibullinMR.Sprint5\Tyuiu.KhabibullinMR.Sprint5.Task0.V19\bin\Debug\net8.0\OutPutFileTask0.txt";

            FileInfo fileInfo = new FileInfo(path);
            bool fileExists = fileInfo.Exists;
            bool wait = true;
            Assert.AreEqual(wait, fileExists);
        }
    }
}
