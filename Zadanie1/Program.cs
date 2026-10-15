Console.WriteLine("Podaj liczbe");
int liczba = int.Parse(Console.ReadLine());

if (liczba % 2 == 0)
{
    Console.WriteLine("Liczba jest parzysta.");
}
else if (liczba % 2 == 1)
{
    Console.WriteLine("liczba jest nieparzysta.");
}

