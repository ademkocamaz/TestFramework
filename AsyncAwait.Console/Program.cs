using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AsyncAwait.Console
{
    internal class Program
    {
        static void Main(string[] args)
        {
            callMethod();
            //Task task = new Task(callMethod2);
            //task.Start();
            //task.Wait();
            System.Console.ReadKey();
        }

        private static async void callMethod2()
        {
            string filePath = "AsyncAwait.Console.pdb";
            Task<int> task = ReadFile(filePath);

            System.Console.WriteLine("Other Work 1");
            System.Console.WriteLine("Other Work 2");
            System.Console.WriteLine("Other Work 3");

            int length = await task;
            System.Console.WriteLine("Total length :" + length);

            System.Console.WriteLine("After Work 1");
            System.Console.WriteLine("After Work 2");
        }

        private static async Task<int> ReadFile(string filePath)
        {
            int length = 0;

            System.Console.WriteLine("File reading is started.");
            using (StreamReader reader = new StreamReader(filePath))
            {
                string s = await reader.ReadToEndAsync();
                length = s.Length;
            }
            System.Console.WriteLine("File reading is completed");
            return length;

        }

        private static async void callMethod()
        {
            Task<int> task = Method1();
            Method2();
            int count = await task;
            //int count = await Method1();
            Method3(count);
        }


        private static async Task<int> Method1()
        {
            int count = 0;
            await Task.Run(() =>
            {
                for (int i = 0; i < 100; i++)
                {
                    System.Console.WriteLine("Method 1 / " + i);
                    Task.Delay(100).Wait();
                    count += 1;
                }
            });
            return count;
        }

        private static void Method2()
        {
            for (int i = 0; i < 25; i++)
            {
                System.Console.WriteLine("Method 2 / " + i);
                Task.Delay(100).Wait();
            }
        }
        private static void Method3(int count)
        {
            System.Console.WriteLine("Total count is " + count);
        }

    }
}
