using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalkulacka
{
    class Program
    {
        static void Main(string[] args)
        {
            // cokoliv za dvěma lomítky // je komentář, tedy není bráno za kód ke spuštění

            Console.WriteLine("Zadej dvě čísla: "); // funkce pro vypsání textu do konzole a odřádkování

            Console.Write("Cislo 1: "); // funkce pro vypsání textu do konzole
            string vstup1 = Console.ReadLine(); // načte textový vstup z konzole do proměnné s názvem vstup1, čeká na stisk klávesy ENTER pro potvrzení vstupu
            int cislo1 = int.Parse(vstup1); // převede text vstup1 na číselnou hodnotu a uloží do proměnné cislo1. Pokud nerozezná číslo, program spadne

            Console.Write("Cislo 2: ");
            string vstup2 = Console.ReadLine(); // načte textový vstup z konzole do proměnné s názvem vstup1
            int cislo2 = int.Parse(vstup2);

            Console.WriteLine("Vyber operaci");
            Console.WriteLine("1 - scitani");
            Console.WriteLine("2 - odcitani");
            Console.WriteLine("3 - nasobeni");
            Console.WriteLine("4 - deleni");
            Console.Write("Zadej operaci: ");
            string operace = Console.ReadLine(); // načte zadanou hodnotu od uživatele do proměnné operace, nepotřebujeme pracovat s číslem, tedy můžeme nechat uloženou hodnotu jako text

            int vysledek = 0;   // deklarace proměnné vysledek, která slouží pro uložení výsledku

            // použítí příkazu if - else pro větvení programu podle splnění dané podmínky
            // if(podmínka)
            // {
            //      příkazy které se provedou pokud je podmínka splněna
            // }
            // else
            // {
            //      pokud není podmínka splněna začne se vykonávat kód zapsaný za příkaz else
            //  }

            // příkaz if lze použít i samostatně bez else, pokud není potřeba vykonat kód, když není podmínka splněna
            // if(podmínka)
            // {
            //      příkazy které se provedou pokud je podmínka splněna
            // }

            if (operace == "1") // příkaz if slouží k otestování podmínky, pokud je podmínka splněna vykoná se kód hned za příkazem ve složených závorkách
            {
                vysledek = cislo1 + cislo2;
            } 
            else if (operace == "2") // pokud první podmínka výše neplatí otestuje se druhá podmínka
            {
                vysledek = cislo1 - cislo2;
            } 
            else if (operace == "3")
            {
                vysledek = cislo1 * cislo2;
            } 
            else if (operace == "4")
            {
                vysledek = cislo1 / cislo2;
            }
            else // pokud neplatí ani jedna výše testovaná podmínka, vykoná se část else
            {
                vysledek = 0;
                Console.WriteLine("Vybrali jste nesprávnou operaci");
            }

            Console.WriteLine("Výsledek je: " + vysledek); // vypsání výsledku

            Console.ReadLine(); // čeká na stisk klávesy ENTER, aby konzolové okno zůstalo otevřené

        }
    }
}
