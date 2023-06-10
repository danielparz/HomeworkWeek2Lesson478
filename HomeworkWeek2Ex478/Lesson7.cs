using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeworkWeek2Lesson478
{
    public class Lesson7
    {
        public void Q1()
        {
            //Napisz program w C#, który stworzy dwie zmienne int i sprawdzi czy są one równe czy nie. 
            //    Dane testowe: a : 5 
            //    b : 5 
            //    Rezultat w terminalu :
            //    5 i 5 są równe

            Console.WriteLine("Zad. 1");

            int a = 5;
            int b = 5;

            if (a == b) Console.WriteLine($"{a} i {b} są równe.");
            if (a < b) Console.WriteLine($"{a} jest mniejsze od {b}.");
            if (a > b) Console.WriteLine($"{a} jest większe od {b}.");
        }

        public void Q2()
        {
            //Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest parzysta czy nieparzysta.
            //    Dane testowe : 15 
            //    Rezultat w terminalu : 
            //    15 jest liczbą nieparzystą

            Console.WriteLine("Zad. 2");

            Console.WriteLine("Podaj liczbę całkowitą: ");
            Int32.TryParse(Console.ReadLine(), out int a);

            if (a % 2 == 0)
                Console.WriteLine($"Liczba {a} jest parzysta.");
            else
                Console.WriteLine($"Liczba {a} jest nieparzysta.");
        }

        public void Q3()
        {
            //Napisz program w C#, który sprawdzi czy podana przez użytkownika liczba jest dodatnia czy ujemna. 
            //    Dane testowe : 14 
            //    Rezultat w terminalu : 
            //    4 jest liczbą dodatnią

            Console.WriteLine("Zad. 3");

            Console.WriteLine("Podaj dowolną liczbę całkowitą: ");
            Int32.TryParse(Console.ReadLine(), out int a);

            if (a < 0) Console.WriteLine($"{a} jest liczbą niedodatnią.");
            else if (a > 0) Console.WriteLine($"{a} jest liczbą nieujemną.");
            else Console.WriteLine($"Liczba {a} jest zerem.");
        }

        public void Q4()
        {
            //Napisz program w C#, który sprawdzi czy podany przez użytkownika rok jest rokiem przestępnym.
            //    Dane testowe : 2016 
            //    Rezultat w terminalu : 
            //    2016 jest rokiem przestępnym

            Console.WriteLine("Zad. 4");

            Console.WriteLine("Podaj rok, żeby dowiedzieć się, czy jest przestepny: ");
            UInt32.TryParse(Console.ReadLine(), out uint year);

            if (((year % 4 == 0) && (year % 100 != 0)) || (year % 400 == 0)) Console.WriteLine($"Rok {year} jest rokiem przestępnym.");
            else Console.WriteLine($"Rok {year} nie jest rokiem przestępnym.");
        }

        public void Q5()
        {
            //Napisz program w C#, który sprawdzi czy podany przez użytkownika wiek uprawnia go do ubiegania się 
            //    o stanowisko posła, premiera, sentarora, prezydenta. 
            //    Dane testowe : 21 
            //    Rezultat w terminalu : Możesz zostać posłem

            Console.WriteLine("Zad. 5");

            // poseł - 21
            // premier - 21
            // senator - 30
            // prezydent - 35

            Console.WriteLine("Podaj swój wiek: ");
            Int32.TryParse(Console.ReadLine(), out int age);
            if (age < 21)
                Console.WriteLine("Niestety nie możesz ubiegać się o żaden urząd.");
            else if (age < 30)
                Console.WriteLine("Możesz startować na urząd posła oraz premiera.");
            else if (age < 35)
                Console.WriteLine("Możesz startować na urzad posła, premiera oraz senatora.");
            else
                Console.WriteLine("Możesz startować na urzad posła, premiera, senatora oraz prezydenta.");
        }

        public void Q6()
        {
            //Napisz program w C#, który pobierze wzrost użytkownika i przypisze mu wymyśloną kategorię wzrostu. 
            //    Dane testowe : 140 
            //    Rezultat w terminalu : Jesteś krasnoludem

            Console.WriteLine("Zad. 6");

            Console.WriteLine("Podaj swój wzrost: ");
            Int32.TryParse(Console.ReadLine(), out int height);

            if(height <= 0)
                Console.WriteLine("Nie istniejesz");
            else if (height <= 100)
                Console.WriteLine("Jesteś liliputem");
            else if (height <= 140)
                Console.WriteLine("Jesteś karłem");
            else if (height <= 160)
                Console.WriteLine("Urośnij....");
            else if (height <= 170)
                Console.WriteLine("Normalny wzrost :)");
            else if (height <= 180)
                Console.WriteLine("Do najniższych nie należysz.");
            else if (height <= 200)
                Console.WriteLine("Nie patrz tak na mnie z góry...");
            else
                Console.WriteLine("Hej, jak tam na górze?");
        }

        public void Q7()
        {
            //    Napisz program w C#, który pobierze 3 liczby od użytkownika i sprawdzi, która jest największa
            //Dane testowe:
            //    25
            //    63
            //    79
            //Rezultat w terminalu:
            //    79 jest największa z podanych

            Console.WriteLine("Zad. 7");

            Console.WriteLine("Podaj liczbę a: ");
            Int32.TryParse(Console.ReadLine(), out int a);
            Console.WriteLine("Podaj liczbę b: ");
            Int32.TryParse(Console.ReadLine(), out int b);
            Console.WriteLine("Podaj liczbę c: ");
            Int32.TryParse(Console.ReadLine(), out int c);

            if (a < b)
                if (b < c)
                    Console.WriteLine($"Liczba {c} jest największa z podanych.");
                else
                    Console.WriteLine($"Liczba {b} jest największa z podanych.");
            else if (a < c)
                Console.WriteLine($"Liczba {c} jest największa z podanych.");
            else
                Console.WriteLine($"Liczba {a} jest najwieksza z podanych.");
        }

        public void Q8()
        {
            //            Napisz program, który sprawdzi, czy kandydat może ubiegać się o miejsce
            //na studiach wg. Następujących kryteriów:
            //Wynik z Matury z matematyki powyżej 70
            //Wynik z fizyki powyżej 55
            //Wynik z chemii powyżej 45
            //Łączny wynik z 3 przedmiotów powyżej 180
            //Albo
            //Wynik z matematyki i jednego przedmiotu powyżej 150
            //Dane testowe:
            //Matematyka 80
            //Fizyka 71
            //Chemia 0
            //Rezultat w terminalu:
            //            Kandydat dopuszczony do rekrutacji

            Console.WriteLine("Zad. 8");

            int math = 80;
            int physics = 71;
            int chem = 0;

            if (((math > 70) && (physics > 55) && (chem > 45) && (math + physics + chem > 180)) || ((math + physics > 150) || (math + chem > 150)))
                Console.WriteLine("Kandydat dopuszczony do rekrutacji.");
            else
                Console.WriteLine("Kandydat niedopuszczony do rekrutacji.");
               
        }

        public void Q9()
        {
            //            Napisz program, który odczyta temperature I zwróci nazwę jak wponiższych kryteriach
            //Temp < 0 – cholerine piździ
            //Temp 0 – 10 – zimno
            //Temp 10 – 20 – chłodno
            //Temp 20 – 30 – w sam raz
            //Temp 30 – 40 – zaczyna być słabo, bo gorąco
            //Temp >= 40 – a weź wyprowadzam się na alaskę.
            //Dane testowe : 41
            //Rezultat w terminalu:
            //            a weź wyprowadzam się na alaskę.

            Console.WriteLine("Zad. 9");

            Console.WriteLine("Podaj temperaturę: ");
            Int32.TryParse(Console.ReadLine(), out int temp);

            if (temp < 0)
                Console.WriteLine("Cholernie piździ");
            else if (temp < 10)
                Console.WriteLine("Zimno");
            else if (temp < 20)
                Console.WriteLine("Chłodno");
            else if (temp < 30)
                Console.WriteLine("W sam raz");
            else if (temp < 40)
                Console.WriteLine("Zaczyna być słabo, bo gorąco");
            else
                Console.WriteLine("Wyprowadzam się na Alaskę");
        }

        public void Q10()
        {
            //            Napisz program, który sprawdzi, czy z 3 podanych długości można
            //stworzyć trójkąt
            //Dane testowe: 40 55 65
            //Rezultat w terminalu:
            //            Można zbudować trójkąt

            Console.WriteLine("Zad. 10");

            Console.WriteLine("Podaj bok a: ");
            Int32.TryParse(Console.ReadLine(), out int a);
            Console.WriteLine("Podaj bok b: ");
            Int32.TryParse(Console.ReadLine(), out int b);
            Console.WriteLine("Podaj bok c: ");
            Int32.TryParse(Console.ReadLine(), out int c);

            if ((a < b + c) && (b < c + a) && (c < a + b))
                Console.WriteLine($"Z boków o długościach {a}, {b} i {c} można utworzyć trójkąt.");
            else
                Console.WriteLine("Z podanych boków nie można utworzyć trójkąta.");
        }

        public void Q11()
        {
            //            Napisz program, który zmieni ocenę ucznia na jej opis
            //                Dane testowe : 3
            //            Rezultat w terminalu:
            //                Dostateczny

            Console.WriteLine("Zad. 11");

            Console.WriteLine("Podaj ocenę: ");
            Int32.TryParse(Console.ReadLine(), out int grade);

            switch (grade)
            {
                case 1:
                    Console.WriteLine("Niedostateczny");
                    break;
                case 2:
                    Console.WriteLine("Dopuszczający");
                    break;
                case 3:
                    Console.WriteLine("Dostateczny");
                    break;
                case 4:
                    Console.WriteLine("Dobry");
                    break;
                case 5:
                    Console.WriteLine("Bardzo dobry");
                    break;
                case 6:
                    Console.WriteLine("Celujący");
                    break;
                default:
                    Console.WriteLine("Nie ma takiej oceny!");
                    break;
            }
        }

        public void Q12()
        {
            //Napisz program, który pobierze numer dnia tygodnia i wyświetli jego nazwę
            //Dane testowe : 4
            //Rezultat w terminalu:
            //Czwartek

            Console.WriteLine("Zad. 12");

            Console.WriteLine("Podaj dzień tygodnia: ");
            Int32.TryParse(Console.ReadLine(), out int dayOfWeek);

            switch (dayOfWeek)
            {
                case 1:
                    Console.WriteLine("Poniedziałek");
                    break;
                case 2:
                    Console.WriteLine("Wtorek");
                    break;
                case 3:
                    Console.WriteLine("Środa");
                    break;
                case 4:
                    Console.WriteLine("Czwartek");
                    break;
                case 5:
                    Console.WriteLine("Piątek");
                    break;
                case 6:
                    Console.WriteLine("Sobota");
                    break;
                case 7:
                    Console.WriteLine("Niedziela");
                    break;
                default:
                    Console.WriteLine("Nie ma takiej oceny!");
                    break;
            }
        }

        public void Q13()
        {
            //            Napisz program, który będzie posiadał proste menu(wg.Wzoru poniżej) I
            //będzie prostym kalkulatorem
            //Podaj pierwszą liczbę:
            //…
            //Podaj drugą liczbę:
            //…
            //Podaj numer operacji do wykonania:
            //1.Dodawanie
            //2.Odejmowanie
            //3.Mnożenie
            //4.Dzielenie
            //…
            //Twój wynik to:

            Console.WriteLine("Zad. 13");

            Console.WriteLine("Podaj pierwszą liczbę: ");
            Int32.TryParse(Console.ReadLine(), out int a);
            Console.WriteLine("Podaj drugą liczbę: ");
            Int32.TryParse(Console.ReadLine(), out int b);

            Console.WriteLine("Podaj numer operacji do wykonania: \r\n\t1. Dodawanie\r\n\t2.Odejmowanie\r\n\t3.Mnożenie\r\n\t4.Dzielenie");
            Int32.TryParse(Console.ReadLine(), out int operation);

            switch (operation)
            {
                case 1:
                    Console.WriteLine($"Twój wynik to: {a + b}");
                    break;
                case 2:
                    Console.WriteLine($"Twój wynik to: {a - b}");
                    break;
                case 3:
                    Console.WriteLine($"Twój wynik to: {a * b}");
                    break;
                case 4:
                    if (b == 0)
                        Console.WriteLine("Pamiętaj cholero, nie dziel przez 0!");
                    else
                        Console.WriteLine($"Twój wynik to: {(float)a / (float)b}");
                    break;
                default:
                    Console.WriteLine("Nieprawidłowe działanie.");
                    break;
            }
        }
    }
}