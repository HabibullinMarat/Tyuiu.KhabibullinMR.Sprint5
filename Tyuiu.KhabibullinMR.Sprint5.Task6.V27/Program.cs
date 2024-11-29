using Tyuiu.KhabibullinMR.Sprint5.Task6.V27.Lib;

namespace Tyuiu.KhabibullinMR.Sprint5.Task6.V27
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");

            string path = $@"{Path.GetTempPath()}InPutDataFileTask6V27.txt";

            Console.WriteLine("Данные находятся в файлй: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                                 ");
            Console.WriteLine("***************************************************************************");

            double res = ds.LoadFromDataFile(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
