using Tyuiu.KhabibullinMR.Sprint5.Task2.V19.Lib;

namespace Tyuiu.KhabibullinMR.Sprint5.Task2.V19
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = { { 9, 2, 5},

                            {8, 8, 2},

                            {7, 4, 8 }};

            int rows = matrix.GetUpperBound(0)+1;
            int colomns = matrix.Length / rows;
            
            DataService ds = new DataService();
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("* ИСХОДНЫЕ ДАННЫЕ:                                                         ");
            Console.WriteLine("***************************************************************************");
            Console.WriteLine("Массив:");

            for (int i = 0; i < rows; i++)
            {
                for (int j = 0; j < colomns; j++)
                {
                    Console.Write($"{matrix[i,j]}\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("***************************************************************************");
            Console.WriteLine("РЕЗУЛЬТАТ:                                                                 ");
            Console.WriteLine("***************************************************************************");

            string res = ds.SaveToFileTextData(matrix);

            Console.WriteLine("Файл: " + res);
            Console.WriteLine("Создан!");
            Console.ReadKey();


        }
    }
}
