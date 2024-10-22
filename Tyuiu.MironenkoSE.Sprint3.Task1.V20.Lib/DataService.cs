﻿using tyuiu.cources.programming.interfaces.Sprint3;
namespace Tyuiu.MironenkoSE.Sprint3.Task1.V20.Lib
{
    public class DataService : ISprint3Task1V20
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double multseries = 16; 
            while (startValue <= stopValue)
            {
                multseries=multseries*Math.Pow(1/Math.Cos(startValue),2);
                startValue++;
            }
            return Math.Round(multseries, 3);

        }
    }
}
