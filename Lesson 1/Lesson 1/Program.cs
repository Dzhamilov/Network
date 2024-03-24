using System;

namespace Lesson_1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сервер ожидает сообщение от Client...");

            ServerHandler serverHandler = new();

            while (true)
            {
                serverHandler.AwaitMessage();
            }
        }
    }
}
