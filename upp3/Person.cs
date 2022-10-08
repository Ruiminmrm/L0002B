using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//Ruimin Ma, ruimac-1@student.ltu.se, L0002B, Uppgift 3
//Jinting Zhang, jinzha-2@student.ltu.se, L0002B, Uppgift 3
namespace WinFormsApp2
{
    public class Person
    {
        private string fornamn;
        private string efternamn;
        private string personnummer;
        public Person(string personnummer, string efternamn, string fornamn)
        {
            this.fornamn = fornamn;
            this.efternamn = efternamn;
            this.personnummer = personnummer;
        }
        public string Getfornamn()
        {
            return fornamn;
        }
        public string Getefternamn()
        {
            return efternamn;
        }
        public string Getprnr()
        {
            return personnummer;
        }

        public string Getkon()
        {
            //anta kön är man, 
            string kon = "Man";
            //köndigit är index 8
            int n;
            char ch = this.personnummer[8];
            //om index 8 är inte digit -> throw exception
            //om index 8 är digit -> n blir det element i index 8
            if(!int.TryParse(ch.ToString(), out n))
            {
                throw new Exception();
            }
            //om index 8 är udda -> man
            //om index 8 är jämn -> kvinna
            if (n % 2 == 0)
                kon = "Kvinna";
            return kon;
        }
        //använda prnkollalgorithm för att checka giltigt personnummer 
        public bool Checkprnr(string pr)
        {

            int[] test = { 2, 1, 2, 1, 2, 1, 2, 1, 2, 1 };
            int sum = 0;
            int a, b;
            int[] sumarr = new int[pr.Length];
            int[] arr = new int[pr.Length];
            for (int i = 0; i < pr.Length; i++)
            {
                arr[i] = int.Parse(pr[i].ToString());
                sumarr[i] = arr[i] * test[i];     
                string str = sumarr[i].ToString();
                char[] ch = str.ToCharArray();
                if(ch.Length == 2)
                {
                    a = int.Parse(ch[0].ToString());
                    b = int.Parse(ch[1].ToString());
                    sumarr[i] = a + b; 
                }
            }
            for (int i = 0; i < sumarr.Length; i++)
                sum = sum + sumarr[i];
            return (sum % 10) == 0;
        }



    }
}
