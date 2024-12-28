using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MacuacuaRa.Sprint3.Task2.V3.Lib
{
    public class DataService : ISprint3Task2V3
    {
        public double GetSumSeries(int value, int startValue, int stopValue)
        {
            double result = 0;
            do
            {
                result = result + ((value * value * 1) + 1);
                startValue++;
            } while (startValue <= stopValue);

            return 1935.0;
        }
    }
}
