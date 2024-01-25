using System.Reflection;

namespace лаба_11
{
    class Test {
        public int aaaaaaaaaaa;
        public Test() {
            aaaaaaaaaaa = 10;
        }

        public int property1 { get; set; }

        public void Met(string message)
        {
            Console.WriteLine(message);
        }

        public void NewMet()
        {

        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Test test = new Test(); 

            Reflector.InfoBuild(typeof(Test));
            Reflector.GetClassName(typeof(Test));
            Reflector.Constructors(typeof(Test)); 

            IEnumerable<string> strings = Reflector.GetPublicMethods(typeof(Test));
            IEnumerable<string> fieldsAndProperty = Reflector.GetFieldAndProperty(typeof(Test));
            IEnumerable<string> methodSort = Reflector.GetPublicMethodsSort(typeof(Test), "Met");
            IEnumerable<string> interfaces = Reflector.GetInterface(typeof(Test));

            foreach (string s in strings) 
                Console.WriteLine(s);

            foreach (string s in fieldsAndProperty)
                Console.WriteLine(s);

            foreach (string s in methodSort)
                Console.WriteLine(s);

            foreach (string s in interfaces)
                Console.WriteLine(s);

            Reflector.WriteToFile("info.txt");

            string[] mess = { "Ejflsahs" };

            Reflector.InvokeMethod("info.txt", test, "Met", mess);

            //Reflector.DeleteContentFile("info.txt");

            Test lol = Reflector.Create<Test>();
        }
    }
}