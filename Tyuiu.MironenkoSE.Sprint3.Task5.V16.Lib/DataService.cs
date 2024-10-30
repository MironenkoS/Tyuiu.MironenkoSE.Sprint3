using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MironenkoSE.Sprint3.Task5.V16.Lib
{
    public class DataService : ISprint3Task5V16
    {
        public double GetSumSumSeries(int x, int startValue1, int startValue2, int stopValue1, int stopValue2)
        {
            double Sum = 0;
            int i, k;
            for (i= startValue1; i<= stopValue1; i++)
            {
                for (k= startValue2; k<= stopValue2; k++)
                {
                    Sum = Sum + ((Math.Cos(k) + Math.Pow(x, 2)));
                }
            }
            return Math.Round(Sum, 3);
        }
    }
}
