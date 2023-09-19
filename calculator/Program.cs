using System.Security.Cryptography.X509Certificates;


namespace Calculator
{
    public class Program
    {
        static void Main()
        {
            float sign;
            float num, num1, result;
            int[] actions = { 1, 2, 3, 4, 5, 6, 7, 8 };
            Console.WriteLine("Добро пожаловать в калькулятора. Выберете одно из действий: ");
            Console.WriteLine("1) Сложение");
            Console.WriteLine("2) Вычитание из первого второе");
            Console.WriteLine("3) Перемножение");
            Console.WriteLine("4) Деление первого на второе");
            Console.WriteLine("5) Возвести в степень первую переменную (степень определяется вторым числом)");
            Console.WriteLine("6) Находит квадратный корень из числа");
            Console.WriteLine("7) Найти 1 процент от числа");
            Console.WriteLine("8) Факториал из числа");
            Console.WriteLine("9) Заканчивает программу");
            while (true) 
            {
                
                Console.Write("Введите действие: ");
                sign = Convert.ToSingle(Console.ReadLine());


                if (sign == 1)
                {
                    Console.Write("Введите первое число: ");
                    num = Convert.ToSingle(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    num1 = Convert.ToSingle(Console.ReadLine());
                    result = num + num1;
                    Console.WriteLine("Сумма чисел равна " + result);
                }

                else if (sign == 2)
                {
                    Console.Write("Введите первое число: ");
                    num = Convert.ToSingle(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    num1 = Convert.ToSingle(Console.ReadLine());
                    result = num - num1;
                    Console.WriteLine("Разность чисел равна " + result);
                }

                else if (sign == 3)
                {
                    Console.Write("Введите первое число: ");
                    num = Convert.ToSingle(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    num1 = Convert.ToSingle(Console.ReadLine());
                    result = num * num1;
                    Console.WriteLine("Произведение чисел равно" + result);
                }

                else if (sign == 4)
                {
                    Console.Write("Введите первое число: ");
                    num = Convert.ToSingle(Console.ReadLine());
                    Console.Write("Введите второе число: ");
                    num1 = Convert.ToSingle(Console.ReadLine());
                    result = num / num1;
                    Console.WriteLine("Частное чисел равно " + result);
                }

                else if (sign == 5)
                {
                    Console.Write("Введите число которое возведется в N-ную степень: ");
                    num = Convert.ToSingle(Console.ReadLine());
                    Console.Write("Введите степень числа: ");
                    num1 = Convert.ToSingle(Console.ReadLine());
                    result = Convert.ToInt32(Math.Pow(num, num1));
                    Console.WriteLine("Первое число в степени " + num1 + " равно " + result);
                }

                else if (sign == 6)
                {
                    Console.Write("Введите число у которого хотите найти квадратный корень: ");
                    num = Convert.ToSingle(Console.ReadLine());
                    result = Convert.ToInt32(Math.Sqrt(num));
                    Console.WriteLine("Квадратный корень числа равен " + result);
                }

                else if (sign == 7)
                {
                    Console.Write("Введите число от которого хотите найти один процент: ");
                    num = Convert.ToSingle(Console.ReadLine());
                    result = num / 100;
                    Console.WriteLine("Один процент числа равен " + result);
                }

                else if (sign == 8)
                {

                       Console.Write("Введите число у которого хотите найти факториал: ");
                       num = Convert.ToSingle(Console.ReadLine());
                       result = 1;
                       for (int i = 1; i <= num; i++)
                       {
                           
                           result *= i;
                           
                       }
                       Console.WriteLine("Факториал числа равен " + result);

                }
                else if (sign > 8 || sign <1)
                {
                    Console.Write("Окончание работы программы.");
                    break;
                }

            }
        }
    }
}