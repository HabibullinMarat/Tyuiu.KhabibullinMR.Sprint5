using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KhabibullinMR.Sprint5.Task5.V9.Lib
{
    public class DataService : ISprint5Task5V9
    {
        public double LoadFromDataFile(string path)
        {
            string strX = File.ReadAllText(path);
            string[] s = strX.Split(',');
            for (int i = 0; i < s.Length; i++)
            {
                s[i] = s[i].Replace(".", ",");
            }

            double[] dS = new double[s.Length];
            for (int i = 0; i < s.Length; i++)
            {
                dS[i] = Convert.ToDouble(s[i]);
            }
            double max = dS.Max();

            return max;
        }
    }
}
