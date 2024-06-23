using System;

namespace Split
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "String.Split метод возвращает строковый массив, содержащий подстроки данного экземпляра, разделенные элементами заданной строки или массива знаков Юникода.";

            char separator = ' ';

            string[] words = text.Split(separator);

            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
        }
    }
}
