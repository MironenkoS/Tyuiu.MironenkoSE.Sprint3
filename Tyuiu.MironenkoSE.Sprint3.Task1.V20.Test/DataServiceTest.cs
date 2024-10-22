using Tyuiu.MironenkoSE.Sprint3.Task1.V20.Lib;
namespace Tyuiu.MironenkoSE.Sprint3.Task1.V20.Test
{
    [TestClass]
    public class DataServiceTest
    {
        [TestMethod]
        public void TestMethod1()
        {
            DataService ds = new DataService();
            
            int startValue = 1;
            int stopValue = 16;
            double res =ds.GetSumSeries(startValue, stopValue);
            double wait = 90546.716;
            Assert.AreEqual(res,wait);
        }
    }
}