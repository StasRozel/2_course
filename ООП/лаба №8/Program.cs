namespace лаба__8
{
    class Program
    {
        


        static void Main(string[] args)
        {
            Programmer programmer = new Programmer();

            List<string> list = new List<string>() { "Tom", "Bob", "Sam" };

            programmer.DeleteEvent += (message) => Console.WriteLine(message);
            programmer.MutationEvent += (message) => Console.WriteLine(message);

            programmer.Mutation(list, 1, "LOL");

            programmer.DeleteBegin(list);
            programmer.DeleteEnd(list);

            string str = "Отпр@@@вь,,,,      мне,, это на почту,,, superDeveloper@#gmail.^^^com";
            string str1 = "kjasd1234";
            string str2 = "stas@gmail#com&&";

            WorkingStrings working = new WorkingStrings();

            Action<string> removeSpace = (str) => working.RemoveExtraSpace(str);
            Func<string, string> removeSpecChar = (str) => working.RemoveSpecialChar(str);
            Func<string, string> letterCapitalized = (str) => working.FirstLetterCapitalized(str);
            Predicate<string> checkChar = (str) => working.CheckEngChar(str);
            Func<string, string> removeCommas = (str) => working.RemoveCommas(str);

            Console.Write("Удаление лишних пробелов: ");
            removeSpace(str);
            Console.WriteLine($"Удаление спец. символов: {removeSpecChar(str)}");
            Console.WriteLine($"Первая буква каждого слова в верхнем регистре: {letterCapitalized(str)}");
            Console.WriteLine($"В строке есть английские символы: {checkChar(str)}");
            Console.WriteLine($"Удаление запятых: {removeCommas(str)}");
        }
    }
}