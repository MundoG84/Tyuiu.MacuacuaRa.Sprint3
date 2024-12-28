using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MacuacuaRa.Sprint3.Task6.V3.Lib
{
    public class DataService : ISprint3Task6V3
    {
        public int GetSumTheDivisors(int startValue, int stopValue)
        {
            int result = 0;

            for (int x = startValue; x <= stopValue; x++)
            {
                for (int d = 1; d <= x; d++)
                {
                    if (x % d == 0 && d > 8)  // Проверка, что делитель больше 8
                    {
                        result += d;
                    }
                }
            }

            return result;
        }

    }
}
