

Console.WriteLine("Podaj imie bohatera");
string imieBohatera = Console.ReadLine();

Console.WriteLine("Punkty zycia");
int HP = int.Parse(Console.ReadLine());

Console.WriteLine("Ilosc zlota");
int zloto = int.Parse(Console.ReadLine());

Console.WriteLine("Poziom");
int poziom = int.Parse(Console.ReadLine());

Console.WriteLine("Liczbe mikstur");
int iloscMikstur = int.Parse(Console.ReadLine());

Console.WriteLine("===Karta Bohatera===");
Console.WriteLine($"Imie: {imieBohatera}");
Console.WriteLine($"Punkty zycia: {HP}");
Console.WriteLine($"Zloto: {zloto}");
Console.WriteLine($"Poziom doswiadczenia: {poziom}");
Console.WriteLine($"Liczba mikstur: {iloscMikstur}");
Console.WriteLine("====================");


//opisanie stanu bohatera
if (HP <= 0)
{
    Console.WriteLine("Bohater nie zyje");
}
else if (HP > 0 && HP < 50)
{
    Console.WriteLine("Bohater jest ranny");
}
else
{
    Console.WriteLine("Bohater jest w dobrej formie");
}



//wybor akcji
Console.WriteLine("===Wybor akcji===");
Console.WriteLine("1-atak");
Console.WriteLine("2-leczenie");
Console.WriteLine("3-ucieczka");
Console.WriteLine("=================");

int wyborAkcji = int.Parse(Console.ReadLine());

switch (wyborAkcji)
{
    case 1:
        Console.WriteLine("Bohater atakuje");
        break;
    case 2:
        Console.WriteLine("Bohater leczy sie");
        break;
    case 3:
        Console.WriteLine("Bohater ucieka");
        break;        
}

