using Tyuiu.MironenkoSE.Sprint3.Task0.V23.Lib;
namespace Tyuiu.MironenkoSE.Sprint3.Task0.V23.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            double value = 1.5;
            int startvalue = 1;
            int stopvalue = 10;
            double res = ds.GetSumSeries(value, startvalue, stopvalue);
            double wait = 0.298;
            Assert.AreEqual(res, wait);
        }
    }
}