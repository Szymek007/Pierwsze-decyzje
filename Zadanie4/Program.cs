Console.WriteLine("Podaj ilosc punktow zycia");
int punktyZycia = int.Parse(Console.ReadLine());

Console.WriteLine("Masz klucz?");
bool maKlucz = bool.Parse(Console.ReadLine());

Console.WriteLine("Znasz haslo?");
bool znaHaslo = bool.Parse(Console.ReadLine());


if (punktyZycia <= 0)
{
    Console.WriteLine("Bohater nie zyje");
}
else if (punktyZycia > 0 && maKlucz || znaHaslo)
{
    Console.WriteLine("Mozesz wejsc");
}
else
{
    Console.WriteLine("Nie mozesz wejsc bo nie masz jak otworzyc drzwi");
}
