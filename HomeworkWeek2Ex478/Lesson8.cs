using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkWeek2Lesson478
{
    public class Lesson8
    {
        public void Q1()
        {
            //Napisz program, który sprawdzi ile jest liczb pierwszych w zakresie 0 – 100.

            Console.WriteLine("Zad. 1");

            List<int> primeNumbers = new List<int>();

            for (int i = 2; i < 100;)
            {
                if (IsPrimeNumber(i))
                {
                    primeNumbers.Add(i);
                }
                if (i == 2) i++;
                else i += 2;
            }

            Console.WriteLine($"W zakreesie 0 - 100 jest {primeNumbers.Count()} liczb pierwszych. Są to: ");
            foreach (int i in primeNumbers)
                Console.Write($"{i} ");

        }

        public void Q2()
        {
            //Napisz program, w którym za pomocą pętli do…while znajdziesz wszystkie liczby parzyste z zakresu 0 – 1000.

            Console.WriteLine("Zad. 2");

            int num = 0;

            do
            {
                if (num % 2 == 0)
                    Console.WriteLine(num);
                num += 2;
            } while (num <= 1000);
        }

        public void Q3()
        {
            //Napisz program, który zaimplementuje ciąg Fibonacciego i wyświetli go na ekranie.

            Console.WriteLine("Zad. 3");

            Console.WriteLine("Podaj, ile wyrazów ciągu Fibonacciego chcesz wypisać: ");
            Int32.TryParse(Console.ReadLine(), out int count);

            for (int i = 1; i <= count; i++)
                Console.Write($"{Fibonacci(i)} ");
        }

        public void Q4()
        {
            //Napisz program, który po podaniu liczby całkowitej wyświetli piramidę liczb od 1 do podanej liczby w formie jak poniżej: 
            //    1 
            //    2 3 
            //    4 5 6 
            //    7 8 9 10

            Console.WriteLine("Zad. 4");

            int line = 1;
            int counter = 0;

            Console.WriteLine("Podaj, ile kolejnych liczb wyświetlić: ");
            Int32.TryParse(Console.ReadLine(), out int count);

            for (int i = 1; i <= count; i++)
            {
                Console.Write($"{i} ");
                counter++;
                if (counter == line)
                {
                    Console.Write("\r\n");
                    counter = 0;
                    line++;
                }
            }
        }

        public void Q5()
        {
            //Napisz program, który dla liczb od 1 do 20 wyświetli na ekranie ich 3 potęgę.

            Console.WriteLine("Zad. 5");

            for (int i = 1; i <= 20; i++)
            {
                Console.WriteLine($"{i * i * i} ");
            }
        }
        public void Q6()
        {
            //Napisz program, który dla liczb od 0 do 20 obliczy sumę wg wzoru:
            //1 + ½ +1 / 3 + ¼ itd.

            Console.WriteLine("Zad. 6");

            double sum = 0;

            for (int i = 1; i <= 20; i++)
                sum += (1d / i);
            Console.WriteLine($"Suma ciągu wynosi: {sum}");
        }

        public void Q7()
        {
            //Napisz program, który dla liczby zadanej przez użytkownika narysuje diament 
            //o krótszej przekątnej o długości wprowadzonej przez użytkownika

            Console.WriteLine("Zad. 7");

            Console.WriteLine("Podaj długość krótszej przekątnej diamentu: ");
            Int32.TryParse(Console.ReadLine(), out int d);

            for (int i = 1; i <= d; i++)
            {
                // wcięcie
                for (int j = d - i; j > 0; j--)
                    Console.Write(" ");
                // gwiazdki
                for (int j = i; j > 0; j--)
                    Console.Write("* ");
                Console.WriteLine();
            }
            for (int i = d - 1; i > 0; i--)
            {
                for (int j = d - i; j > 0; j--)
                    Console.Write(" ");
                for (int j = i; j > 0; j--)
                    Console.Write("* ");
                Console.WriteLine();
            }
        }

        public void Q8()
        {
            //            Napisz program, który odwróci wprowadzony przez użytkownika ciąg znaków. Np.
            //Testowe dane:
            //Abcdefg
            //Rezultat
            //Gfedcba

            Console.WriteLine("Zad. 8");

            Console.WriteLine("Podaj ciąg znaków: ");
            string input = Console.ReadLine();
            StringBuilder sb = new StringBuilder();

            for (int i = 1; i <= input.Length; i++)
                sb.Append(input[input.Length - i]);

            Console.WriteLine($"Wprowadzony ciąg znaków: {input}");
            Console.WriteLine($"odwrócony ciąg znaków: {sb.ToString()}");
        }

        public void Q9()
        {
            //Napisz program, który zamieni liczbę dziesiętną na liczbę binarną.

            Console.WriteLine("Zad. 9");

            Console.WriteLine("Podaj liczbę w systemie dziesiętnym: ");
            Int32.TryParse(Console.ReadLine(), out int number10);

            StringBuilder sb = new StringBuilder();

            while ((double)number10 / 2 > 0)
            {
                sb.Append(number10 % 2);
                number10 /= 2;
            }

            string number2 = sb.ToString();
            sb.Clear();

            for (int i = 1; i <= number2.Length; i++)
                sb.Append(number2[number2.Length - i]);

            Console.WriteLine($"Liczba {number10} w systemie binarnym wygląda tak: {sb.ToString()}");
        }

        public void Q10()
        {
            //Napisz program, który znajdzie najmniejszą wspólną wielokrotność dla zadanych 2 liczb.

            Console.WriteLine("Zad. 10");

            Console.WriteLine("Podaj pierwszą liczbę całkowitą: ");
            Int32.TryParse(Console.ReadLine(), out int a);
            Console.WriteLine("Podaj drugą liczbę całkwitą: ");
            Int32.TryParse(Console.ReadLine(), out int b);

            Console.WriteLine($"Najmniejsza wspólna wielokrotność licz {a} i {b} wynosi: {(a * b) / NWD(a, b)}");
        }

        public int NWD(int a, int b)
        {
            int c;
            //if (a < b)
            //{
            //    c = a;
            //    a = b;
            //    b = c;
            //}
            while (b != 0)
            {
                c = a % b;
                a = b;
                b = c;
            }
            return a;
        }

        public int Fibonacci(int n)
        {
            if (n == 1) return 0;
            if (n <= 3) return 1;
            else return Fibonacci(n - 1) + Fibonacci(n - 2);
        }

        public bool IsPrimeNumber(int a)
        {
            if (a == 2) return true;
            for (int i = 2; i <= Math.Sqrt(a); i++)
                if (a % i == 0) return false;
            return true;
        }
    }
}
