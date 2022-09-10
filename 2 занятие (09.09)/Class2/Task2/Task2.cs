using System.Text;

namespace Task2
{
    public class Task2
    {

/*
 * В этих заданиях * рекомендуется всюду использовать класс StringBuilder.
 * Документация: https://docs.microsoft.com/ru-ru/dotnet/api/system.text.stringbuilder?view=net-6.0
 */

/*
 * Задание 2.1. Дана непустая строка S и целое число N (> 0). Вернуть строку, содержащую символы
 * строки S, между которыми вставлено по N символов «*» (звездочка).
 */
        internal static string FillWithAsterisks(string s, int n)
        {
            StringBuilder resultString = new StringBuilder("", s.Length * (n + 1));
            StringBuilder asterisks = new StringBuilder("");
            for (int i = 0; i < n; i++)
                asterisks.Append("*");
            for (int i = 0; i < s.Length - 1; i++)
            {
                resultString.Append(s[i]);
                resultString.Append(asterisks);
            }
            resultString.Append(s[s.Length - 1]);
            return resultString.ToString();
        }

/*
 * Задание 2.2. Сформировать таблицу квадратов чисел от 1 до заданного числа N.
 * Например, для N=4 должна получиться следующая строка:

1  1
2  4
3  9
4 16

 * Обратите внимание на выравнивание: числа в первом столбце выравниваются по левому краю,
 * а числа во втором -- по правому, причём между числами должен оставаться как минимум один
 * пробел. В решении можно использовать функции Pad*.
 */
        internal static string TabulateSquares(int n)
        {
            string number = n.ToString();
            string squaredNumber = (n * n).ToString();
            int numberOfChars = number.Length + squaredNumber.Length + 1;
            StringBuilder resultString = new StringBuilder("");
            for (int i = 1; i <= n; i++)
            {
                string currentString = i.ToString();
                squaredNumber = (i * i).ToString();
                currentString = currentString.PadRight(numberOfChars - squaredNumber.Length);
                currentString += squaredNumber;
                resultString.Append(currentString);
                if(i != n) 
                    resultString.Append("\n");
            }
            return resultString.ToString();
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(FillWithAsterisks("abc", 2));
            Console.WriteLine(TabulateSquares(4));
        }
    }
}