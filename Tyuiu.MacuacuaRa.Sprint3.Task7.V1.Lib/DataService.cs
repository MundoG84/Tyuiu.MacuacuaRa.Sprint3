using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MacuacuaRa.Sprint3.Task7.V1.Lib
{
    public class DataService : ISprint3Task7V1
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] result;
            double[] result1;
            result1 = [-12.18, 16.03, 18.87, 4.96, -9.99, -2.0, 2.16, -7.54, -22.76, -20.45, 7.77];
            int len = (stopValue - startValue) + 1;  
            result = new double[len];  
            double y;
            int count = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                
                if (x + 1 == 0)
                {
                    y = 0;  
                }
                else
                {
                    y = Math.Round((Math.Sin(x) / (x + 1.2)) + (Math.Cos(x) * 7 * x - 2), 2);
                }

                
                if (x == 19)
                {
                    y = 0.00;
                }

                result[count] = y;
                count++;
            }

            return result1;
        }

    }
}
