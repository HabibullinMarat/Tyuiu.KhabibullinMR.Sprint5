using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KhabibullinMR.Sprint5.Task6.V27.Lib
{
    public class DataService : ISprint5Task6V27
    {
        public int LoadFromDataFile(string path)
        {
            string str = File.ReadAllText(path);

            string[] s = str.Split(' ');

            int count = 0;
            for (int i = 0; i < s.Length; i++)
            {
                int il = 0;
                bool rew = int.TryParse(s[i], out il);
                if (rew)
                {
                    int ch = Convert.ToInt32(s[i]);
                    if (ch > 99 & ch < 1000)
                    {
                        count++;
                    }
                }

            }
            return count;
        }
    }
}
