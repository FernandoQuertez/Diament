using System;
using System.Text.RegularExpressions;
class Diament
{
    static void Main()
    {
        Console.WriteLine("Podaj liczbę (wyznaczenie najszerszego miejsca diamentu: )");
        int szerokość = Convert.ToInt32((Console.ReadLine()));
        Console.WriteLine("Podaj znak specjalny (*, @ lub &): ");
        string znaczek = Console.ReadLine();
        char symbol = znaczek[0];
        
        if (Regex.IsMatch(znaczek, @"^[*@&]+$"))
{
    Console.WriteLine("Znak jest poprawny");
}
else
{
    Console.WriteLine("Podano niepoprawny znak");
}
 if (szerokość % 2 == 0)
        {
            Console.WriteLine("Szerokość musi być liczbą nieparzystą");
            return;
        }
         int polowa = szerokość / 2;

       
        for (int i = 0; i <= polowa; i++)
        {
            int gwiazdki = 2 * i + 1;
            int spacje = polowa - i;

            Console.Write(new string(' ', spacje));
            Console.WriteLine(new string(symbol, gwiazdki));
        }

        
        for (int i = polowa - 1; i >= 0; i--)
        {
            int gwiazdki = 2 * i + 1;
            int spacje = polowa - i;

            Console.Write(new string(' ', spacje));
            Console.WriteLine(new string(symbol, gwiazdki));
        }
    }
    
}