using System;

    class Program {

        static void Main() {
            Console.WriteLine("ЗАДАНИЕ 1:");
            Console.Write("Введите значение x: ");
            double x = double.Parse(Console.ReadLine());

            Console.Write("Введите значение y: ");
            double y = double.Parse(Console.ReadLine());

            double result = Matematika(x, y);

            Console.WriteLine($"Значение выражения: {result}");


            Console.WriteLine("ЗАДАНИЕ 2:");
            Console.Write("Введите первое трехзначное число: ");
            int num1 = int.Parse(Console.ReadLine());

            Console.Write("Введите второе трехзначное число: ");
            int num2 = int.Parse(Console.ReadLine());

            int sumNum1 = Summa(num1);
            int firstNum2 = First(num2);

            int result2 = sumNum1 + firstNum2;
            Console.WriteLine($"Сумма цифр первого числа + первая цифра второго числа: {result2}");

            Console.WriteLine("ЗАДАНИЕ 3:");
            Console.Write("Введите натуральное число N: ");
            int N = int.Parse(Console.ReadLine());

            bool Two = TwoZnachnoe(N);
            Console.WriteLine($"Данное высказывание: {Two}");

            Console.WriteLine("ЗАДАНИЕ 4:");
            Console.Write("Введите четырехзначное число: ");
            int FourZnachnoe = int.Parse(Console.ReadLine());

            bool proverka = Nacelo(FourZnachnoe);
            Console.WriteLine($"Делится ли нацело вторая цифра на третью: {proverka}");
   
        }

        static double Matematika(double x, double y)
    {
        double cosinus = Math.Pow(Math.Cos(x), 2);
        double reshenie = (1 - cosinus) * (Math.Sin(y) / (2 - x));
        return reshenie;
    }
        static int Summa(int number)
        {
            int sum = 0;
            while (number != 0)
            {
                sum += number % 10;
                number /= 10;
            }
            return sum;
        }

        static int First(int number)
        {
            while (number >= 10)
            {
                number /= 10;
            }
            return number;
        }
        static bool TwoZnachnoe(int number) {
            return number >= 10 && number <= 99;
    }

        static bool Nacelo(int number) {
            int secondChis = (number / 10) % 10;
            int thirdChis = (number / 100) % 10;
            return thirdChis != 0 && secondChis % thirdChis == 0;
    }
}
    
