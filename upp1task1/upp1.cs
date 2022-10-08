using System;
//Ruimin Ma, ruimac-1@student.ltu.se, L0002B, Uppgift 1 Console-variant 
namespace Uppgift1
{
    class Program
    {
        static void Main(string[] args)
        {
            bool runapp = true;
            // när boolean runapp är true , gör följande steg
            while (runapp)
            {
                // skapa object 
                Change ch = new Change();
                // köra object
                ch.cases();

                // när input är "n" , stänga appen
                Console.Write("Tryck på 'n' + Enter för att stänga appen, tryck på valfri annan tangent + Enter för att fortsätta: ");
                if (Console.ReadLine() == "n") runapp = false;
                Console.WriteLine("\n");
            }
        }
        public class Change
        {
            // skapa variabler
            int sum;
            int pris;
            int betalt;
            public void cases()
            {
                //läsa inut
                Console.WriteLine("Ange pris :");
                this.pris = Convert.ToInt32(Console.ReadLine());
                Console.WriteLine("Ange betalt :");

                //räkna hur mycket ska betala
                this.betalt = Convert.ToInt32(Console.ReadLine());
                this.sum = this.betalt - this.pris;
                
                //olika fall
                if(sum == 0)
                {
                    Console.WriteLine("Tillräckligt");
                    return;
                }else if (sum < 0)
                {
                    Console.WriteLine("Ej tillräckligt");
                }else {
                    Program x= new Program();

                    //anropa mentoderna och printa hur många valören ska tillbaka
                    int femhundra = x.fivehundred(this.sum);
                    this.sum = sum - femhundra * 500;
                    int tvahundra = x.twohundred(this.sum);
                    this.sum = sum - tvahundra * 200;
                    int hundra = x.onehundred(this.sum);
                    this.sum = sum - hundra * 100;
                    int femtio = x.fifty(this.sum);
                    this.sum = sum - femtio * 50;
                    int tjugo = x.twenty(this.sum);
                    this.sum = sum - tjugo * 20;
                    int tio = x.ten(this.sum);
                    this.sum = sum - tio * 10;
                    int fem = x.five(this.sum);
                    this.sum = this.sum - fem * 5;
                    int ett = x.one(this.sum);

                    Console.WriteLine("Växel tillbaka :");
                    if(femhundra != 0)
                        Console.WriteLine(femhundra + " femhundralapp");
                    if(tvahundra != 0)
                        Console.WriteLine(tvahundra + " tvåhundralapp");
                    if(hundra != 0)
                        Console.WriteLine(hundra + " etthundralapp");
                    if(femtio != 0)
                        Console.WriteLine(femtio + " femtiolapp");
                    if(tjugo != 0)
                        Console.WriteLine(tjugo + " tjugolapp");
                    if(tio != 0)
                        Console.WriteLine(tio + " tiokrona");
                    if(fem != 0)
                        Console.WriteLine(fem + " femkrona");
                    if(ett != 0)
                        Console.WriteLine(ett + " ettkrona");

                }
            }
        }
        //räkna hur många av valör ska tillbaka 
        public int fivehundred(int sum)
        {
            int femhundra = sum / 500;
            return femhundra;
        }
        public int twohundred(int sum)
        {
            int tvåhundra = sum / 200;
            return tvåhundra;
        }
        public int onehundred(int sum)
        {
            int hundra = sum / 100;
            return hundra;
        }
        public int fifty(int sum)
        {
            int femtio = sum / 50;
            return femtio;
        }
        public int twenty(int sum)
        {
            int tjugo = sum / 20;
            return tjugo;
        }
        public int ten(int sum)
        {
            int tio = sum / 10;
            return tio;
        }
        public int five(int sum)
        {
            int fem = sum / 5;
            return fem;
        }
        public int one(int sum)
        {
            int en = sum / 1;
            return en;
        }

    }
}