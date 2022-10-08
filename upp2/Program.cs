using System;
using System.IO;
using System.Collections.Generic;
using System.Linq;
//Många metoder används från boken och webbplatsen  https://docs.microsoft.com/en-us/dotnet/csharp/
//inspirerade av github 

// Jinting Zhang, jinzha-2@student.ltu.se, L0002B, Uppgift 2
// Ruimin Ma, ruimac-1@student.ltu.se, L0002B, Uppgift 2
namespace ConsoleApp1
{
    class Program
    {

        static void Main(string[] args)
        {

            while (true) //starta programmet 
            {
                //skapa en lista då kan personsinfo lista in
                List<Saljare> salja = new List<Saljare>();

                Console.WriteLine("Hur många bästsäljare vill man registrera?");
                int t = int.Parse(Console.ReadLine());
                Console.WriteLine("\n");


                if (t > 0)
                {
                    //får följande personensinfo
                    int i = 0;
                    while (i < t)
                    {
                        Console.WriteLine("Name: ");
                        String name = Console.ReadLine();
                        Console.WriteLine("Personnummer: ");
                        int personnnummer = int.Parse(Console.ReadLine());
                        Console.WriteLine("Distrikt: ");
                        String distrikt = Console.ReadLine();
                        Console.WriteLine("Antal salja: ");
                        int antal = int.Parse(Console.ReadLine());
                        Console.WriteLine("\n");

                        //skapa en saljare och spara info
                        Saljare saljare = new Saljare(name, personnnummer, distrikt, antal);

                        //spara alla saljaresinfo i listan
                        salja.Add(saljare);
                        i++;
                    }
                    behandling(salja);
                }
                else
                {
                    Console.WriteLine("Skriv en giltig inmatning (endast siffra, minst 1 säljare)");
                }

                Console.Write("Tryck på 'n' för att stänga appen, tryck på valfri annan tangent för att fortsätta: ");
                if (Console.ReadLine() == "n") break;
                Console.WriteLine("\n");
            }
        }

        static void behandling(List<Saljare> saljare)
        {
            string file = "";
            bbs(saljare);
            //använd bubblesort för att sortera i stigande ordning
            Console.WriteLine("");

            //dela dem till fyra olika nivå
            Dictionary<List<int>, string> level = new Dictionary<List<int>, string>();
            level.Add(new List<int>() { 0, 49 }, "mindre än 50 artiklar");
            level.Add(new List<int>() { 50, 99 }, "50-99 artiklar");
            level.Add(new List<int>() { 100, 199 }, "100-199 artiklar");
            level.Add(new List<int>() { 199, int.MaxValue }, "över 199 artiklar");

            var numbers = level.Keys;
            int LatestSeller = 0;
            int LatestIndex = 0;

            //Gå igenom säljarna
            foreach (Saljare n in saljare)
            {

                for (int i = 0; i < numbers.Count; i++)
                {
                    List<int> list = numbers.ElementAt(i);
                    // Om säljaren skulle vara i den nivån
                    if (n.antal >= list[0] && n.antal <= list[1])
                    {
                        if (i != LatestIndex)
                        {
                            if (LatestSeller > 0)
                            {
                                // Data kommer skrivas till filen
                                file += WriteLine(
                                    string.Format(
                                        "{0} säljare har nått nivå {1}  : {2} artiklar\n",
                                        LatestSeller,
                                        LatestIndex + 1,
                                        level[numbers.ElementAt(LatestIndex)]
                                        )
                                );
                                //updatera index
                                Console.WriteLine("");
                                LatestIndex = i;
                                LatestSeller = 0;
                            }
                            else
                            {
                                // Uppdatera index baserat på vilka nivåer som innehåller säljare
                                LatestIndex = i;
                                LatestSeller = 0;
                            }
                        }
                        //spara info
                        LatestSeller += 1;
                        file += WriteLine(n.String());
                        Console.WriteLine("");
                    }
                }
            }
            //spara info
            file += WriteLine(string.Format("{0} säljare(s) har nått nivå {1} : {2} artiklar\n",
                                   LatestSeller, LatestIndex + 1, level[numbers.ElementAt(LatestIndex)]));
            Console.WriteLine("");
            File.WriteAllText("bestsellersinfo.txt", file);
        }

        //metod
        static string WriteLine(string info)
        {
            Console.WriteLine(info);
            return info;
        }

        //bubblesort för att kunna sortera i stigande ordning 
        static void bbs(List<Saljare> list)
        {
            bool needSorting = true;
            for (int i = 0; i < list.Count - 1 && needSorting; i++)
            {
                needSorting = false;
                for (int j = 0; j < list.Count - 1 - i; j++)
                {
                    if (list[j].antal > list[j + 1].antal)
                    {
                        needSorting = true;
                        Saljare temp = list[j + 1];
                        list[j + 1] = list[j];
                        list[j] = temp;
                    }
                }
            }
        }

    }

    class Saljare
    {
        public string namn;
        public int personnnummer;
        public string distrikt;
        public int antal;

        //konstruktur
        public Saljare(string Name, int Personnnummer, string Distrikt, int Antal)
        {
            this.namn = Name;
            this.personnnummer = Personnnummer;
            this.distrikt = Distrikt;
            this.antal = Antal;
        }

        //output för personsinfo
        public string String()
        {
            return string.Format("Namn : {0},\t Personnummer : {1},\t Distrikt : {2},\t Antal : {3} \n", namn, personnnummer, distrikt, antal);
        }
    }
}
