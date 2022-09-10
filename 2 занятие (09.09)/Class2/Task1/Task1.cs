﻿using Microsoft.VisualBasic;

namespace Task1
{
    public class Task1
    {
/*
 * Задание 1.1. Дана строка. Верните строку, содержащую текст "Длина: NN",
 * где NN — длина заданной строки. Например, если задана строка "hello",
 * то результатом должна быть строка "Длина: 5".
 */
        internal static int StringLength(string s)
        {
            return s.Length;
        }

/*
 * Задание 1.2. Дана непустая строка. Вернуть коды ее первого и последнего символов.
 * Рекомендуется найти специальные функции для вычисления соответствующих символов и их кодов.
 */
        internal static Tuple<int?, int?> FirstLastCodes(string s)
        {
            return new Tuple<int?, int?>(Code(First(s)), Code(Last(s)));
        }
        
        private static char? First(string s) => Strings.GetChar(s, 1); 
        private static char? Last(string s) => Strings.GetChar(s, s.Length);
        private static int? Code(char? c) => c != null ? (int)c : 0;
       

/*
 * Задание 1.3. Дана строка. Подсчитать количество содержащихся в ней цифр.
 * В решении необходимо воспользоваться циклом for.
 */
        internal static int CountDigits(string s)
        {
            int countOfDigits = 0;
            for (int i = 0; i < s.Length; i++)
            {
                if (Char.IsDigit(s[i]))
                    countOfDigits++;
            }
            return countOfDigits;
        }

/*
 * Задание 1.4. Дана строка. Подсчитать количество содержащихся в ней цифр.
 * В решении необходимо воспользоваться методом Count:
 * https://docs.microsoft.com/ru-ru/dotnet/api/system.linq.enumerable.count?view=net-6.0#system-linq-enumerable-count-1(system-collections-generic-ienumerable((-0))-system-func((-0-system-boolean)))
 * и функцией Char.IsDigit:
 * https://docs.microsoft.com/ru-ru/dotnet/api/system.char.isdigit?view=net-6.0
 */
        internal static int CountDigits2(string s)
        {
            return s.Count(character => Char.IsDigit(character) == true);
        }
        
/*
 * Задание 1.5. Дана строка, изображающая арифметическое выражение вида «<цифра>±<цифра>±…±<цифра>»,
 * где на месте знака операции «±» находится символ «+» или «−» (например, «4+7−2−8»). Вывести значение
 * данного выражения (целое число).
 */

        internal static int CurrentSignedNumber(Char lastSign, string currentNumber)
        {
            int currentSignedNumber = lastSign switch
            {
                '+' => int.Parse(currentNumber),
                '-' => -1 * int.Parse(currentNumber),
                _ => 0
            };
            return currentSignedNumber;
        }
        internal static int CalcDigits(string expr)
        {
            int result = 0;
            string currentNumber = "";
            char lastSign = '+';
            for (int i = 0; i < expr.Length; i++)
            {
                if (Char.IsDigit(expr[i]))
                    currentNumber += expr[i];
                else
                {
                    result += CurrentSignedNumber(lastSign, currentNumber);
                    lastSign = expr[i];
                    currentNumber = "";
                }
            }
            result += CurrentSignedNumber(lastSign, currentNumber);
            return result;
        }

/*
 * Задание 1.6. Даны строки S, S1 и S2. Заменить в строке S первое вхождение строки S1 на строку S2.
 */
        internal static string ReplaceWithString(string s, string s1, string s2)
        {
            int indexOfSubstring = s.IndexOf(s1);
            s = s.Remove(indexOfSubstring, s1.Length);
            s = s.Insert(indexOfSubstring, s2);
            return s;
        }
        

        public static void Main(string[] args)
        {
            Console.WriteLine(StringLength("zxcsdfax"));
            Console.WriteLine(FirstLastCodes("asdfzxcvdf"));
            Console.WriteLine(CountDigits("ad45df573fdg6"));
            Console.WriteLine(CountDigits2("ad45df573fdg6"));
            Console.WriteLine(CalcDigits("2+3+5-3-45+12"));
            Console.WriteLine(ReplaceWithString("Завтра на работу", "на работу", "на Бали!!!"));
        }
    }
}