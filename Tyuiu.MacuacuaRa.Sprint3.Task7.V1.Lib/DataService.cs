using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MacuacuaRa.Sprint3.Task7.V1.Lib
{
    public class DataService : ISprint3Task7V1
    {
        public double[] GetMassFunction(int startValue, int stopValue)
        {
            double[] result;
            int len = (stopValue - startValue) + 1;
            result = new double[11];
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
                Console.WriteLine(y);
                result[count] = y;
                count++;
            }

            return result;
        }
    }
}
