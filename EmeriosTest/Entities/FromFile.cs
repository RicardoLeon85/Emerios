using System.Configuration;
using System.IO;
using System.Text;

namespace EmeriosTest.Entities
{
    public class FromFile : ExternalInfo
    {
        public Info ReadInfo
        {
            get
            {
                string pathFile = ConfigurationManager.AppSettings["pathFile"];

                string[] lines = File.ReadAllLines(pathFile, Encoding.UTF8);

                var lenght = lines[0].Length > 0 ? lines[0].Split(',').Length : 0;
                var info = new Info(lines.Length, lenght);

                for (int i = 0; i < lines.Length; i++)
                {
                    var items = lines[i].Split(',');

                    for (int j = 0; j < items.Length; j++)
                    {
                        info.Matriz[i, j] = items[j].Trim().ToUpper();
                    }
                }

                return info;
            }
        }
    }
}
