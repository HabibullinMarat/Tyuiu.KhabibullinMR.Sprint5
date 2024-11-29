using Tyuiu.KhabibullinMR.Sprint5.Task7.V22.Lib;

namespace Tyuiu.KhabibullinMR.Sprint5.Task7.V22
{
    internal class Program
    {
        static void Main(string[] args)
        {
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");

            string path = $@"{Path.GetTempPath()}InPutDataFileTask7V22.txt";

            Console.WriteLine("Данные находятся в файлй: " + path);

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                                 ");
            Console.WriteLine("***************************************************************************");

            string res = ds.LoadDataAndSave(path);
            Console.WriteLine(res);
            Console.ReadKey();
        }
    }
}
