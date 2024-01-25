namespace лаба__12
{
    class Program
    {
        static void Main(string[] args)
        {
            RSADiskInfo.GetDiskInfo();
                
            RSAFileInfo.GetFileInfo("info.txt");

            RSADirInfo.GetDirInfo("E:\\Универ\\2 курс\\ООП\\лаба №12");

            Console.WriteLine();

            //RSAFileManager.GetDiskInfo("D:");

            //RSAFileManager.CreateNewFolder("D:", "D:\\Загрузки", ".pptx");

            //RSALog.WriteText("info.txt", "Hello World");

            //RSALog.ReadText("info.txt");

            //RSALog.FindText("info.txt", "Hello");

            DateTime startTime = new DateTime(2023, 11, 22);
            DateTime endTime = new DateTime(2023, 11, 23);


            RSALog.SortDate("E:\\Универ\\2 курс\\ООП\\лаба №12\\rsalogfile.txt", "Запись", startTime, endTime);
        }
    }
}