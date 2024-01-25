using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace лаба__12
{
    class RSALog
    {
        static FileInfo logFile = new FileInfo("E:\\Универ\\2 курс\\ООП\\лаба №12");
        static string path = Path.Combine(logFile.FullName, "rsalogfile.txt");


        static public void WriteText(string fileName, string text)
        {

            File.AppendAllText(fileName, text);

            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine($"Запись в файл {fileName}, время: {DateTime.Now}");
            }
        }

        static public void ReadText(string fileName)
        {
            File.ReadAllText(fileName);

            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine($"Прочтен файл {fileName}, время: {DateTime.Now}");
            }
        }

        static public void FindText(string fileName, string text)
        {
            string[] lines = File.ReadAllText(fileName).Split('\n');

            foreach (string item in lines)
            {
                if (item.IndexOf(text) >= 0)
                {
                    Console.WriteLine(item);
                }
            }

            using (StreamWriter writer = new StreamWriter(path, true))
            {
                writer.WriteLine($"Произведен поиск по файлу {fileName}, время: {DateTime.Now}");
            }

        }

        static public void SortDate(string path, string word, DateTime start, DateTime end)
        {
            string filePath = path;
            string keyword = word;
            DateTime startTime = start;
            DateTime endTime = end;

            var logs = File.ReadAllLines(filePath)
                        .Where(l => l.Contains(keyword) ||
                          (DateTime.Parse(l.Split('|')[1]) >= startTime &&
                           DateTime.Parse(l.Split('|')[1]) <= endTime));

            
            foreach (string log in logs)
            {
                Console.WriteLine(log);
            }

        }
    }

}
