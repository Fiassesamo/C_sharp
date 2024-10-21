using System;

class Program
{
    static void Main(string[] args)
    {
        while (true)
        {
            Console.WriteLine("\nWybierz zadanie:\n1. Delta i pierwiastki trójmianu kwadratowego\n2. Kalkulator\n3. Operacje na tablicy (10 liczb)\n4. Algorytmy na tablicy (10 liczb)\n5. Liczby od 20 do 0 z wyłączeniami\n6. Nieskończona pętla\n7. Sortowanie liczb\n8. Wyjście");
            int wybor = Convert.ToInt32(Console.ReadLine());

            switch (wybor)
            {
                case 1:
                    ObliczPierwiastki();
                    break;
                case 2:
                    Kalkulator();
                    break;
                case 3:
                    OperacjeNaTablicy();
                    break;
                case 4:
                    AlgorytmyNaTablicy();
                    break;
                case 5:
                    LiczbyOd20Do0();
                    break;
                case 6:
                    NieskonczonaPetla();
                    break;
                case 7:
                    SortowanieBabelkowe();
                    break;
                case 8:
                    return;
                default:
                    Console.WriteLine("Niepoprawna opcja.");
                    break;
            }
        }
    }

    // Zadanie 1: Delta i pierwiastki trójmianu kwadratowego
    static void ObliczPierwiastki()
    {
        Console.WriteLine("Podaj współczynnik a:");
        double a = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Podaj współczynnik b:");
        double b = Convert.ToDouble(Console.ReadLine());

        Console.WriteLine("Podaj współczynnik c:");
        double c = Convert.ToDouble(Console.ReadLine());

        double delta = (b * b) - (4 * a * c);
        Console.WriteLine($"\nDelta wynosi: {delta}");

        if (delta > 0)
        {
            double x1 = (-b - Math.Sqrt(delta)) / (2 * a);
            double x2 = (-b + Math.Sqrt(delta)) / (2 * a);
            Console.WriteLine($"x1 = {x1}, x2 = {x2}");
        }
        else if (delta == 0)
        {
            double x = -b / (2 * a);
            Console.WriteLine($"x = {x}");
        }
        else
        {
            Console.WriteLine("Brak rozwiązań rzeczywistych.");
        }
    }

    // Zadanie 2: Kalkulator
    static void Kalkulator()
    {
        while (true)
        {
            Console.WriteLine("\nWybierz operację:\n1. Suma\n2. Różnica\n3. Iloczyn\n4. Iloraz\n5. Potęga\n6. Pierwiastek\n7. Funkcje trygonometryczne\n8. Powrót");
            int wybor = Convert.ToInt32(Console.ReadLine());

            switch (wybor)
            {
                case 1:
                    OperacjaMatematyczna((x, y) => x + y, "Suma");
                    break;
                case 2:
                    OperacjaMatematyczna((x, y) => x - y, "Różnica");
                    break;
                case 3:
                    OperacjaMatematyczna((x, y) => x * y, "Iloczyn");
                    break;
                case 4:
                    OperacjaMatematyczna((x, y) => x / y, "Iloraz");
                    break;
                case 5:
                    OperacjaMatematyczna((x, y) => Math.Pow(x, y), "Potęga");
                    break;
                case 6:
                    Console.WriteLine("Podaj liczbę:");
                    double liczba = Convert.ToDouble(Console.ReadLine());
                    Console.WriteLine($"Pierwiastek z {liczba} = {Math.Sqrt(liczba)}");
                    break;
                case 7:
                    Console.WriteLine("Podaj kąt w stopniach:");
                    double kat = Convert.ToDouble(Console.ReadLine()) * Math.PI / 180;
                    Console.WriteLine($"Sin({kat}) = {Math.Sin(kat)}");
                    Console.WriteLine($"Cos({kat}) = {Math.Cos(kat)}");
                    Console.WriteLine($"Tan({kat}) = {Math.Tan(kat)}");
                    break;
                case 8:
                    return;
                default:
                    Console.WriteLine("Niepoprawna opcja.");
                    break;
            }
        }
    }

    static void OperacjaMatematyczna(Func<double, double, double> operacja, string nazwaOperacji)
    {
        Console.WriteLine("Podaj pierwszą liczbę:");
        double liczba1 = Convert.ToDouble(Console.ReadLine());
        Console.WriteLine("Podaj drugą liczbę:");
        double liczba2 = Convert.ToDouble(Console.ReadLine());

        double wynik = operacja(liczba1, liczba2);
        Console.WriteLine($"{nazwaOperacji} wynosi: {wynik}");
    }

    // Zadanie 3: Operacje na tablicy
    static void OperacjeNaTablicy()
    {
        double[] liczby = new double[10];
        for (int i = 0; i < liczby.Length; i++)
        {
            Console.WriteLine($"Podaj liczbę {i + 1}:");
            liczby[i] = Convert.ToDouble(Console.ReadLine());
        }

        while (true)
        {
            Console.WriteLine("\nWybierz operację:\n1. Wyświetlanie tablicy (od początku)\n2. Wyświetlanie tablicy (od końca)\n3. Elementy o nieparzystych indeksach\n4. Elementy o parzystych indeksach\n5. Powrót");
            int wybor = Convert.ToInt32(Console.ReadLine());

            if (wybor == 5) break;

            switch (wybor)
            {
                case 1:
                    for (int i = 0; i < liczby.Length; i++)
                    {
                        Console.WriteLine(liczby[i]);
                    }
                    break;
                case 2:
                    for (int i = liczby.Length - 1; i >= 0; i--)
                    {
                        Console.WriteLine(liczby[i]);
                    }
                    break;
                case 3:
                    for (int i = 1; i < liczby.Length; i += 2)
                    {
                        Console.WriteLine(liczby[i]);
                    }
                    break;
                case 4:
                    for (int i = 0; i < liczby.Length; i += 2)
                    {
                        Console.WriteLine(liczby[i]);
                    }
                    break;
                default:
                    Console.WriteLine("Niepoprawny wybór.");
                    break;
            }
        }
    }

    // Zadanie 4: Algorytmy na tablicy
    static void AlgorytmyNaTablicy()
    {
        double[] liczby = new double[10];
        double suma = 0, iloczyn = 1, min = double.MaxValue, max = double.MinValue;

        for (int i = 0; i < liczby.Length; i++)
        {
            Console.WriteLine($"Podaj liczbę {i + 1}:");
            liczby[i] = Convert.ToDouble(Console.ReadLine());
        }

        for (int i = 0; i < liczby.Length; i++)
        {
            suma += liczby[i];
            iloczyn *= liczby[i];
            if (liczby[i] < min) min = liczby[i];
            if (liczby[i] > max) max = liczby[i];
        }

        double srednia = suma / liczby.Length;

        Console.WriteLine($"Suma: {suma}");
        Console.WriteLine($"Iloczyn: {iloczyn}");
        Console.WriteLine($"Średnia: {srednia}");
        Console.WriteLine($"Min: {min}");
        Console.WriteLine($"Max: {max}");
    }

    // Zadanie 5: Liczby od 20 do 0 z wyłączeniami
    static void LiczbyOd20Do0()
    {
        for (int i = 20; i >= 0; i--)
        {
            if (i == 2 || i == 6 || i == 9 || i == 15 || i == 19)
                continue;
            Console.WriteLine(i);
        }
    }

    // Zadanie 6: Nieskończona pętla
    static void NieskonczonaPetla()
    {
        while (true)
        {
            Console.WriteLine("Podaj liczbę całkowitą (wprowadź liczbę ujemną, aby zakończyć):");
            int liczba = Convert.ToInt32(Console.ReadLine());

            if (liczba < 0)
                break;
        }
    }

    // Zadanie 7: Sortowanie bąbelkowe
    static void SortowanieBabelkowe()
    {
        Console.WriteLine("Podaj liczbę elementów do posortowania:");
        int n = Convert.ToInt32(Console.ReadLine());
        int[] liczby = new int[n];

        for (int i = 0; i < n; i++)
        {
            Console.WriteLine($"Podaj liczbę {i + 1}:");
            liczby[i] = Convert.ToInt32(Console.ReadLine());
        }

        for (int i = 0; i < liczby.Length - 1; i++)
        {
            for (int j = 0; j < liczby.Length - i - 1; j++)
            {
                if (liczby[j] > liczby[j + 1])
                {
                    int temp = liczby[j];
                    liczby[j] = liczby[j + 1];
                    liczby[j + 1] = temp;
                }
            }
        }

        Console.WriteLine("Posortowane liczby:");
        foreach (int liczba in liczby)
        {
            Console.WriteLine(liczba);
        }
    }
}