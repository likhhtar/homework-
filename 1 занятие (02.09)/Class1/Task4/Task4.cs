namespace Task4
{
    public class Task4
    {
/*
 * В решениях следующих заданий предполагается использование циклов.
 */

/*
 * Задание 4.1. Пользуясь циклом for, посимвольно напечатайте рамку размера width x height,
 * состоящую из символов frameChar. Можно считать, что width>=2, height>=2.
 * Например, вызов printFrame(5,3,'+') должен напечатать следующее:

+++++
+   +
+++++
 */
        internal static void PrintFrame(int width, int height, char frameChar = '*')
        {
            for (int i = 0; i < height; i++)
            {
                if(i == 0 || i == height - 1)
                    for(int j = 0; j < width; j++) Console.Write(frameChar);
                else
                {
                    for(int j = 0; j < width; j++) 
                        if(j == 0 || j == width - 1) Console.Write(frameChar);
                        else Console.Write(' ');
                }
                Console.Write('\n');
            }
        }

/*
 * Задание 4.2. Выполните предыдущее задание, пользуясь циклом while.
 */
        internal static void PrintFrame2(int width, int height, char frameChar = '*')
        {
            int i = 0, j;
            while(i < height)
            {
                j = 0;
                if(i == 0 || i == height - 1)
                    while(j < width)
                    {
                        Console.Write(frameChar);
                        j++; 
                    }
                else
                {
                    while (j < width)
                    {
                        if (j == 0 || j == width - 1) Console.Write(frameChar);
                        else Console.Write(' ');
                        j++;
                    }
                        
                }
                Console.Write('\n');
                i++;
            }
        }


/*
 * Задание 4.3. Даны целые положительные числа A и B. Найти их наибольший общий делитель (НОД),
 * используя алгоритм Евклида:
 * НОД(A, B) = НОД(B, A mod B),    если B ≠ 0;        НОД(A, 0) = A,
 * где «mod» обозначает операцию взятия остатка от деления.
 */
        internal static long Gcd(long a, long b)
        {
            while (a != 0 && b != 0)
            {
                if (a > b) a %= b;
                else b %= a;
            }

            return a + b;
        }

/*
 * Задание 4.4. Дано вещественное число X и целое число N (> 0). Найти значение выражения
 * 1 + X + X^2/(2!) + … + X^N/(N!), где N! = 1·2·…·N.
 * Полученное число является приближенным значением функции exp в точке X.
 */
        internal static double ExpTaylor(double x, int n)
        {
            double fact = 1; // factorial
            double xn = 1; // x в степени [0, n]
            double res = 0; // sum of xn
            for (int i = 0; i <= n; i++)
            {
                res += xn / fact;
                xn *= x;
                fact *= (i + 1);
            }

            return res;
        }

        public static void Main(string[] args)
        {
            PrintFrame(5, 3, '+');
            PrintFrame2(5, 3, '+');
            Console.WriteLine(Gcd(5, 3));
            Console.WriteLine(ExpTaylor(5.2, 5));
        }
    }
}