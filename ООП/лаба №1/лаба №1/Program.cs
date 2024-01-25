using System;
using System.Text;

class Program
{
    static void Main(string[] args)
    {
        //--------------------------------------------------
        Console.WriteLine("ТИПЫ");
        //примитивы
        bool flag = false;
        byte bvar = 1;
        char cvar = 's';
        decimal decvar = 0;
        double dvar = 0;
        float fvar = 0F;
        int ivar = 0;
        long lvar = 0;
        short svar = 0;

        //ввод-вывод примитивов
        Console.Write("Введите тип bool: ");
        flag = bool.Parse(Console.ReadLine());
        Console.Write("Введите тип byte: ");
        bvar = byte.Parse(Console.ReadLine());
        Console.Write("Введите тип сhar: ");
        cvar = char.Parse(Console.ReadLine());
        Console.Write("Введите тип decimal: ");
        decvar = decimal.Parse(Console.ReadLine());
        Console.Write("Введите тип double: ");
        dvar = double.Parse(Console.ReadLine());
        Console.Write("Введите тип float: ");
        fvar = float.Parse(Console.ReadLine());
        Console.Write("Введите тип int: ");
        ivar = int.Parse(Console.ReadLine());
        Console.Write("Введите тип long: ");
        lvar = long.Parse(Console.ReadLine());
        Console.Write("Введите тип short: ");
        svar = short.Parse(Console.ReadLine());

        Console.WriteLine(flag);
        Console.WriteLine(bvar);
        Console.WriteLine(cvar);
        Console.WriteLine(decvar);
        Console.WriteLine(dvar);
        Console.WriteLine(fvar);
        Console.WriteLine(ivar);
        Console.WriteLine(lvar);
        Console.WriteLine(svar);

        //явное и неявное преобразование
        Console.WriteLine("Пример неявного преобразования " + 5);
        int newshort = svar;
        int newchar = cvar;

        int l = Convert.ToInt32(dvar);
        double d = Convert.ToDouble(ivar);
        char c = Convert.ToChar(ivar);
        bool b = Convert.ToBoolean(fvar);
        byte bits = Convert.ToByte(fvar);

        //упаковка и распаковка переменной 
        int num = 143;

        object box = num;

        int newNum = (int)box;

        //работа с переменной с неявным преобразованием
        string str = "5" + 5;
        Console.WriteLine(str);


        //работа с var
        var counter = "Lol";
        //counter = 1;

        Console.WriteLine("СТРОКИ");

        char s = 's';
        char s1 = 's';
        char k = 'k';
        //Сравнение литералов 
        if(s == s1)
        {
            Console.WriteLine("Литералы равны");
        } 

        if(s == k) 
        {
            Console.WriteLine("Литералы равны");
        }
        //Методы для работы со строками
        string str1 = "Hello World!";
        string str2 = "Hello World!";
        string str3 = "Hello World,My name is Stas,I`m ";
        int number = 1;

        string sumString = str1 + str2;

        string copy = string.Copy(str3);

        string subString = str3.Substring(4, 6);

        string[] words = str3.Split(',');

        string insertString = str3.Insert(32, "front-end developer");

        string deleteResult = str3.Replace("I`m ", "");

        string example = $"Вот пример {number} интерполированной строки";
        //Нулевая и пустая строка
        string strNull = null;
        string strEmpty = "";
        Console.WriteLine(String.IsNullOrEmpty(strNull));
        Console.WriteLine(String.IsNullOrEmpty(strEmpty));
        //Работа с stringBuilder
        StringBuilder builder = new StringBuilder();
        builder.Append("a fox jumped over a ");
        builder.Append("lazy dog");
        builder.Replace("fox ", "cat ");
        builder.Replace("over ", "");
        builder.AppendFormat(" lol lol lol");

        Console.WriteLine(builder);

        Console.WriteLine("МАССИВЫ");

        int[,] matrix = { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };

        //вывод двумерного массива
        int rows = matrix.GetUpperBound(0) + 1;
        int columns = matrix.Length / rows;

        for (l = 0; l < rows; l++)
        {
            for (int j = 0; j < columns; j++)
            {
                Console.Write($"{matrix[l, j]}  ");
            }
            Console.WriteLine();
        }
        //работа с одромерным массивом 
        int[] ints = { 1, 2, 3, 4, 5, 6, 7, 8, 9, };
        Console.WriteLine($"{ints.Length}");

        foreach (int inum in ints)
        {
            Console.Write($"{inum} ");
        }

        Console.Write("\nИзмените любой элемент: ");
        int numberElement = int.Parse(Console.ReadLine());
        int valueElement = int.Parse(Console.ReadLine());

        ints[numberElement-1] = valueElement;

        foreach (int inum in ints)
        {
            Console.Write($"{inum} ");
        }
        Console.WriteLine();

        float[][] myArr = new float[4][];
        myArr[0] = new float[2];
        myArr[1] = new float[3];
        myArr[2] = new float[4];

        for (int f = 0; f < 3; f++)
        {
            for (l = 0; l < myArr[f].Length; l++)
            {
                myArr[f][l] = l;
                Console.Write("{0}\t", myArr[f][l]);
            }
            Console.WriteLine();
        }

        var arr = new object[1, 2, 3];
        var helloWorld = "hello world!";

        Console.WriteLine("КАРТЕЖИ");

        (int, string, char, string, ulong) tuples = (1, "hello", 's', "world", 412);

        int One = tuples.Item1;
        string Hello = tuples.Item2;

        Console.WriteLine(One);
        Console.WriteLine(Hello);

        (int one, string hello, _, _, _) = tuples;

        Console.WriteLine(one);
        Console.WriteLine(hello);

        (int zero, string, char, string, ulong) tuples1 = (0, "hello", 'r', "pops", 123);



        if (tuples != tuples1)
        {
            Console.WriteLine("!!!!");
        }

        Console.WriteLine(tuples);
        Console.WriteLine(tuples.Item1);
        Console.WriteLine(tuples.Item3);
        Console.WriteLine(tuples.Item4);

        (int, int, int, char) fun(int[] array, string str)
        {
            int min = int.MaxValue;
            int max = int.MinValue;
            int sum = 0;

            for (int i = 0; i < array.Length; i++)
            {
                if (min > array[i])
                {
                    min = array[i];
                }
                if (max < array[i])
                {
                    max = array[i];
                }

                sum += array[i];
            }

            (int, int, int, char) tuples = (min, max, sum, str[0]);

            return tuples;
        }

        int[] elems = { 1, 2, 3, 54, 21, 64 };

        fun(elems, "Hello World");

        int maxValue = int.MaxValue;

        void check()
        {
            
            try
            {
                checked
                {
                    int numberValue = maxValue + 1;
                }
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        check();
        void unckeck()
        {
            try
            {
                unchecked
                {
                    int numberValue = maxValue + 10;
                }
            }
            catch (OverflowException e)
            {
                Console.WriteLine(e.Message);
            }
        }
        unckeck();

    }
}