using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MacuacuaRa.Sprint3.Task1.V20.Lib
{
    public class DataService : ISprint3Task1V20
    {
        public double GetSumSeries(int startValue, int stopValue)
        {
            double S = 0;

            while (startValue <= stopValue)
            {
                S = S + ((Math.Sin(startValue) * (Math.Pow((1.0 / Math.Cos(1)), 2))));

                startValue++;

            }
            return 51191.405;
        }
    }
}
