using System;

namespace Split
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string text = "String.Split метод возвращает строковый массив, содержащий подстроки данного экземпляра, разделенные элементами заданной строки или массива знаков Юникода.";
            string[] arrayText = text.Split(' ');

            for (int i = 0; i < arrayText.Length; i++)
            {
                Console.WriteLine(arrayText[i]);
            }
        }
    }
}
