using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MironenkoSE.Sprint3.Task7.V26.Lib
{
    public class DataService : ISprint3Task7V26
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] valueA;
            int len = (stopValue - startValue) + 1;
            valueA = new double[len];
            double y;
            int count = 0;
            for (int x=startValue; x<=stopValue; x++)
            {
                y =Math.Round( 5 - 3 * x + (1 + Math.Sin(x) / 2 * x - 0.5),2);
                valueA[count]= y;
                count++;
            }
            return valueA;
        }
    }
}
