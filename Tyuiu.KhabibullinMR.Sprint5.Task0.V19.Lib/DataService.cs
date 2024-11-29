using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KhabibullinMR.Sprint5.Task0.V19.Lib
{
    public class DataService : ISprint5Task0V19
    {
        public string SaveToFileTextData(int x)
        {
            string path = $@"{Path.GetTempPath()}OutPutFileTask0.txt";
            double y = (2 * Math.Pow(x, 2) - 1) / Math.Pow((x*x - 2),0.5);
            y = Math.Round(y,3);
            File.WriteAllText(path,Convert.ToString(y));
            return path;
        }
    }
}
