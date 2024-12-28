using tyuiu.cources.programming.interfaces.Sprint3;

namespace Tyuiu.MacuacuaRa.Sprint3.Task3.V29.Lib
{
    public class DataService : ISprint3Task3V29
    {
        public string DeleteCharInString(string value, char item)
        {
            string result = "";

            foreach (char i in value)
            {
                if (i != 'h')  // Если символ не равен 'h', добавляем его в результат
                {
                    result += i;
                }
            }

            return result;
        }
    }
}
