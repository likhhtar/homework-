namespace Task3
{
    public class Task3
    {
/*
 * Прежде чем приступать к выполнению заданий, допишите к ним тесты.
 */

/*
 * Задание 3.1. Для данного вещественного x найти значение следующей функции f, принимающей значения целого типа:
 * 	        0,	если x < 0,
 * f(x) = 	1,	если x принадлежит [0, 1), [2, 3), …,
           −1,	если x принадлежит [1, 2), [3, 4), … .
 */
        internal static double F(double x) => x < 0 ? 0 : ((int) x % 2 == 0 ? 1 : -1);

/*
 * Задание 3.2. Дан номер года (положительное целое число). Определить количество дней в этом году,
 * учитывая, что обычный год насчитывает 365 дней, а високосный — 366 дней. Високосным считается год,
 * делящийся на 4, за исключением тех годов, которые делятся на 100 и не делятся на 400
 * (например, годы 300, 1300 и 1900 не являются високосными, а 1200 и 2000 — являются).
 */
        internal static int NumberOfDays(int year) => year % 4 == 0 ? ((year % 100 == 0 && year % 400 != 0) ? 365 : 366) : 365;

/*
 * Задание 3.3. Локатор ориентирован на одну из сторон света («С» — север, «З» — запад,
 * «Ю» — юг, «В» — восток) и может принимать три цифровые команды поворота:
 * 1 — поворот налево, −1 — поворот направо, 2 — поворот на 180°.
 * Дан символ C — исходная ориентация локатора и целые числа N1 и N2 — две посланные команды.
 * Вернуть ориентацию локатора после выполнения этих команд.
 */
        internal static char Rotate2(char orientation, int cmd1, int cmd2)
        {
            char rotate1(char orientation, int cmd) => 
                orientation == 'С' ? (cmd == 1 ? 'З' : (cmd == -1 ? 'В' : 'Ю')) : 
                    (orientation == 'В' ? (cmd == 1 ? 'С' : (cmd == -1 ? 'Ю' : 'З')) :
                        (orientation == 'Ю' ? (cmd == 1 ? 'В' : (cmd == -1 ? 'З' : 'С')) : 
                            (cmd == 1 ? 'Ю' : (cmd == -1 ? 'С' : 'В'))));

            orientation = rotate1(orientation, cmd1);
            orientation = rotate1(orientation, cmd2);
            return orientation;
        }

/*
 * Задание 3.4. Дано целое число в диапазоне 20–69, определяющее возраст (в годах).
 * Вернуть строку-описание указанного возраста, обеспечив правильное согласование
 * числа со словом «год», например: 20 — «двадцать лет», 32 — «тридцать два года»,
 * 41 — «сорок один год».
 *
 * Пожалуйста, научитесь делать такие вещи очень аккуратно. Программное обеспечение
 * переполнено некорректными с точки зрения русского языка решениями.
 */
        internal static String AgeDescription(int age)
        {
            int secWord = age % 10, firWord = age / 10;
            string first1 = null; //first word 
            string second2 = null, third = null; // second and third words
            
            if (firWord == 2) first1 = "двадцать";
            else if (firWord == 3) first1 = "тридцать";
            else if (firWord == 4) first1 = "сорок";
            else if (firWord == 5) first1 = "пятьдесят";
            else if (firWord == 6) first1 = "шестьдесят";

            if (secWord == 1) second2 = " один";
            else if (secWord == 2) second2 = " два";
            else if (secWord == 3) second2 = " три";
            else if (secWord == 4) second2 = " четыре";
            else if (secWord == 5) second2 = " пять";
            else if (secWord == 6) second2 = " шесть";
            else if (secWord == 7) second2 = " семь";
            else if (secWord == 8) second2= " восемь";
            else if (secWord == 9) second2 = " девять";

            if (secWord == 0 || secWord > 4) third = " лет";
            else if (secWord == 1) third = " год";
            else third = " года";

            return first1 + second2 + third;
        }

        public static void Main(string[] args)
        {
            Console.WriteLine(F(0.0));
            Console.WriteLine(NumberOfDays(2021));
            Console.WriteLine(Rotate2('В', -1, -1));
            Console.WriteLine(AgeDescription(42));
        }
    }
}