Console.WriteLine("Podaj aktualna ilosc HP");
int HP = int.Parse(Console.ReadLine());

Console.WriteLine("Podaj podstawowe obrazenia swojej broni");
int obrazenia = int.Parse(Console.ReadLine());

Console.WriteLine("Czy posiadasz miksture?");
bool maMiksture = bool.Parse(Console.ReadLine());

Console.WriteLine("Wybierz akcje: ");
int wybierzAkcje = int.Parse(Console.ReadLine());

if (HP < 0 )
{
    Console.WriteLine("Przegrana");
}
else 
switch (wybierzAkcje)
    {
        case 1:
            Console.WriteLine($"obrazenia: {obrazenia}");
            break;
        case 2:
            if (maMiksture)
            {
                Console.WriteLine("leczenie bohatera");   
            }
            else
            {
                Console.WriteLine("brak mozliwosci leczenia, brak mikstury");
            }
            break;
        case 3:
            Console.WriteLine("bohater ucieka");
            break; 
        
    }


if (HP < 20 && HP > 0 )
{
    Console.WriteLine("NISKI POZIOM ZYCIA!");
}