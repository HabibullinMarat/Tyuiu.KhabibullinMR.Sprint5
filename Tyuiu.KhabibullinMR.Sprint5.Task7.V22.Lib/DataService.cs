using System.Runtime.ExceptionServices;
using tyuiu.cources.programming.interfaces.Sprint5;

namespace Tyuiu.KhabibullinMR.Sprint5.Task7.V22.Lib
{
    public class DataService : ISprint5Task7V22
    {
        public string LoadDataAndSave(string path)
        {
            string str = File.ReadAllText(path);
            for (int i = 0; i < str.Length; i++)
            {
                if (str[i] == ',' || str[i] == '.' || str[i] == '!' || str[i] == '?' || str[i]=='-')
                {
                    str = str.Replace(str[i],'#');
                }
            }
            return str;
        }
    }
}
