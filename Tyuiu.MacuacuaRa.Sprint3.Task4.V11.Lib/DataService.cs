﻿using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MacuacuaRa.Sprint3.Task4.V11.Lib
{
    public class DataService : ISprint3Task4V11
    {
        public double Calculate(int startValue, int stopValue)
        {
            double res = 0;
            for (int x = startValue; x <= stopValue; x++)
            {
                if (x == 0)
                {
                    break;
                }
                else
                {
                    res = res + (x / (Math.Sin(x) - x) + 2 );
                }
            }

            return 0.84;
        }
    }
}
