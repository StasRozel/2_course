using System.Diagnostics;
using System.Reflection;

namespace лаба__14
{
    internal class Program
    {
        static void Task4()
        {
            Thread myThread1 = new Thread(Print1);
            Thread myThread2 = new Thread(Print2);

            myThread2.Priority = ThreadPriority.Highest;

            myThread1.Start();
            myThread2.Start();

            void Print1()
            {
                for (int i = 0; i < 13; i += 2)
                {
                    Console.WriteLine($"Первый поток: {i}");
                    Thread.Sleep(400);
                }
            }

            void Print2()
            {
                for (int i = 1; i < 13; i += 2)
                {
                    Console.WriteLine($"Второй поток: {i}");
                    Thread.Sleep(400);
                }
            }
        }

        static void Task4i()
        {
            Thread Thread1 = new Thread(Print1J);


            Thread1.Start();


            void Print1J()
            {
                for (int i = 0; i < 13; i += 2)
                {
                    Console.WriteLine($"Первый поток: {i}");
                    Thread.Sleep(400);

                    if (i == 12)
                    {
                        Thread myThread2 = new Thread(Print2);
                        myThread2.Start();
                        void Print2()
                        {
                            for (int i = 1; i < 13; i += 2)
                            {
                                Console.WriteLine($"Второй поток: {i}");
                                Thread.Sleep(400);
                            }
                        }
                    }
                }
            }
        }

        static void Task4ii() {
            Thread Thread1i = new Thread(Print1i);
            Thread mThread2 = new Thread(Print2ii);
          

            Thread1i.Start();
            mThread2.Start();


            void Print1i()
            {
                for (int i = 0; i < 13; i += 2)
                {
                    Console.WriteLine($"Первый поток: {i}");
                    Thread.Sleep(400);
                }
            }

            
            void Print2ii()
            {
                for (int i = 1; i < 13; i += 2)
                {
                    Console.WriteLine($"Второй поток: {i}");
                    Thread.Sleep(400);
                }
            }
        }

        static void DoWork(object state)
        {

            // Этот метод будет вызываться в отдельном потоке раз в секунду

            Thread thread = Thread.CurrentThread;
            thread.Name = "TimerThread";

            // Выводим время
            Console.WriteLine($"{thread.Name}: {DateTime.Now}");
        }

        static Timer timer;

        static void Main(string[] args)
        {
            //---------------------1 задание---------------- -
            foreach (Process process in Process.GetProcesses())
            {
                Console.WriteLine($"ID: {process.Id}");
                Console.WriteLine($"Name: {process.ProcessName}");
                Console.WriteLine($"Priority: {process.BasePriority}");
                Console.WriteLine($"Start time: {process.GetStartTime()}");
                Console.WriteLine($"Status: {process.Responding}");
                TimeSpan? cpuTime = process.GetTotalProcessorTime();
                Console.WriteLine($"Total CPU Time: {cpuTime}");

                Console.WriteLine();
            }
            //------------------2 задание в другом проекте--------

            //------------------3 задание------------------------ -


            //-------------------4 задание------------------
            Task4();

            //---------------------
            Task4i();

            Task4ii();


            timer = new Timer(DoWork, null, 0, 1000);

            // Ждем ввода от пользователя
            Console.ReadLine();

            // Останавливаем таймер
            timer.Dispose();

        }
    }
}