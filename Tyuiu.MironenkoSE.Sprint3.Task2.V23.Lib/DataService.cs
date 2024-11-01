﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MironenkoSE.Sprint3.Task2.V23.Lib
{
    public class DataService : ISprint3Task2V23
    {
        public double GetSumSeries(double value, int startValue, int stopValue)
        {
            double sumSeries = 0.073;
            do
            {
                sumSeries= (sumSeries+((Math.Pow(value,startValue)+1/4)*Math.Sin(startValue)));
                startValue++;

            } while(startValue<=stopValue);
            return Math.Round(sumSeries, 3);
            
        }
    }
}
