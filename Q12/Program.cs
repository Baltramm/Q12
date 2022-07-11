using System;
using System.IO;
using System.Collections;
using System.Text;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading;
using System.Collections.Concurrent;

namespace Q12
{
    class Program
    {
        // объявим потокобезопасную очередь (полностью идентична обычной очереди, но
        // позволяет безопасный доступ
        // из разных потоков)
        public static ConcurrentQueue<string> words = new ConcurrentQueue<string>();

        static void Main(string[] args)
        {
            Console.WriteLine("Введите слово и нажмите Enter, чтобы добавить его в очередь.");
            Console.WriteLine();

            //  запустим обработку очереди в отдельном потоке
            StartQueueProcessing();

            while (true)
            {
                var input = Console.ReadLine();

                if (input == "peek")
                {
                    if (words.TryPeek(out var elem))
                        Console.WriteLine(elem);
                }
                else
                {
                    // если не введена - ставим элемент в очередь, как и обычно
                    words.Enqueue(input);
                }
            }
        }

        // метод, который обрабатывает и разбирает нашу очередь в отдельном потоке
        // ( для выполнения задания изменять его не нужно )
        static void StartQueueProcessing()
        {
            new Thread(() =>
            {
                Thread.CurrentThread.IsBackground = true;

                while (true)
                {
                    Thread.Sleep(5000);
                    if (words.TryDequeue(out var element))
                        Console.WriteLine("======>  " + element + " прошел очередь");
                }

            }).Start();
        }
    }
}