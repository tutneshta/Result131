using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.IO;

namespace Result131
{
    class Program
    {
        static void Main(string[] args)
        {
            string path = "D:\\task13\\Text.txt";
            StreamReader text = new StreamReader(path);

            string insertChar = "O";

            var myList = new List<string>();

            while (!text.EndOfStream)
            {
                myList.Add(text.ReadLine());
            }

            LinkedList<string> LinkedList = new LinkedList<string>(myList);

            var watchTwo = Stopwatch.StartNew();

            //выбрать нужный тест (убрать коммент)

            //AddToList(myList, insertChar);

            //AddToLinkedList(LinkedList, insertChar);

            Console.WriteLine($"Вставка  текста: {watchTwo.Elapsed.TotalMilliseconds}  мс");
        }

        //вставляет текст в конец списка List
        static void AddToList(List<string> text, string insertChar)
        {
            text.Insert(text.Count, insertChar);
        }

        //вставляет текст в конец списка LinkedList
        static void AddToLinkedList(LinkedList<string> linkedList, string insertChar)
        {
            linkedList.AddLast(insertChar);
        }
    }
}