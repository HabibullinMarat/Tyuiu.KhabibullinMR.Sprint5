using Tyuiu.KhabibullinMR.Sprint5.Task1.V30.Lib;

namespace Tyuiu.KhabibullinMR.Sprint5.Task1.V30
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");

            int startValue = -5;
            int stopValue = -5;

            Console.WriteLine("startValue = " + startValue);
            Console.WriteLine("stopValue = " + stopValue);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                                 ");
            Console.WriteLine("***************************************************************************");
            string res = ds.SaveToFileTextData(startValue,stopValue);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();
        }
    }
}
