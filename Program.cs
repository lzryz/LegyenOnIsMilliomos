using System;
using System.IO;
using System.Text;

namespace LegyenOnIsMilliomos
{
    internal class Program
    {
        static List<Millio> Million_List = new List<Millio>();
        static int korr = 0;
        static int pont = 0;
        static Random rnd = new Random();
        static string betu = "";

        static bool Felvolt = false;
        static bool Kozvolt = false;
        static bool Telvolt = false;

        static string helyesvalasz = "";
        static string kerdes = "";
        static string Alett = "";
        static string Blett = "";
        static string Clett = "";
        static string Dlett = "";

        static void Main(string[] args)
        {
        Beolvas();
        Kerdesek();
        Penz();
        }
        private static void Valasz()
        {
            Console.Write($"Kérem adja meg a válaszát vagy kérjen segítséget: {helyesvalasz} ");
            string valasz = Console.ReadLine().ToUpper();

            if (valasz == helyesvalasz)
            {
                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine($"\nHelyes :)\n");
                Console.ResetColor();

                int tarca = 0;
                if (pont == 1) { tarca = 5000; }
                if (pont == 2) { tarca = 10000; }
                if (pont == 3) { tarca = 25000; }
                if (pont == 4) { tarca = 50000; }
                if (pont == 5) { tarca = 100000; }
                if (pont == 6) { tarca = 200000; }
                if (pont == 7) { tarca = 300000; }
                if (pont == 8) { tarca = 800000; }
                if (pont == 9) { tarca = 1500000; }
                if (pont == 10) { tarca = 3000000; }
                if (pont == 11) { tarca = 5000000; }
                if (pont == 12) { tarca = 10000000; }
                if (pont == 13) { tarca = 20000000; }
                if (pont == 14) { tarca = 40000000; }

                Console.WriteLine($"Jelenlegi összeg: {tarca}");
                Kerdesek();
                pont++;
            }

            if (valasz == "T")
            {
                int teltipp = rnd.Next(4);
                string tipp = "";
                if (teltipp <= 1) { tipp = helyesvalasz; }
                else
                {
                    int rndbetu = rnd.Next(0, 4);
                    if (rndbetu == 0) { betu = "A"; }
                    if (rndbetu == 1) { betu = "B"; }
                    if (rndbetu == 2) { betu = "C"; }
                    if (rndbetu == 3) { betu = "D"; }
                    tipp = betu;
                }

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;

                if (Telvolt == true) { Console.WriteLine("Ezt a segítséget már nem használhatod!!"); }

                Console.ResetColor();
                Telvolt = true;
                Penz();
                Console.WriteLine($"{korr}.\t{kerdes}\n\n{Alett}\t{Blett}\t{Clett}\t{Dlett}\n\nSzerintem {tipp} a helyes válasz");
                Valasz();
                
            }

            if (valasz == "K")
            {

                int[] numbers = new int[4];
                int sum = 0;
                int max = 0;
                int index = 0;

                for (int i = 0; i < numbers.Length - 1; i++)
                {
                    numbers[i] = rnd.Next(0, 101 - sum);
                    sum += numbers[i];
                }
                numbers[4 - 1] = 100 - sum;

                for (int i = 0; i < numbers.Length; i++)
                {
                    if (numbers[i] > max)
                    {
                        max = numbers[i];
                        index = i;
                    }
                }

                for (int i = index; i > 0; i--)
                {
                    numbers[i] = numbers[i - 1];
                }

                if (helyesvalasz == "A") {numbers[0] = max;}
                if (helyesvalasz == "B") { numbers[1] = max; }
                if (helyesvalasz == "C") { numbers[2] = max; }
                if (helyesvalasz == "D") { numbers[3] = max; }






                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;

                if (Kozvolt) { Console.WriteLine("Ezt a segítséget már nem használhatod!!"); }

                Console.ResetColor();
                Kozvolt = true;
                Penz();
                Console.WriteLine($"{korr}.\t{kerdes}\n\n{Alett}\t{Blett}\t{Clett}\t{Dlett}\n\nA közönség szavazata: A:{numbers[0]}%\tB:{numbers[1]}%\tC:{numbers[2]}%\tD:{numbers[3]}%");
                Valasz();
            }

            if (valasz == "F")
            {
                string betu = Felezes();

                while (betu == helyesvalasz) {betu = Felezes();}

                List<string> Fel = new List<string>();
                Fel.Add(helyesvalasz);
                Fel.Add(betu);
                Fel.Sort();

                string valasz1 = "";
                string valasz2 = "";

                if (Fel[0] == "A") {valasz1 = Alett;}
                else if (Fel[0] == "B") {valasz1 = Blett;}
                else if (Fel[0] == "C") {valasz1 = Clett;}
                else if (Fel[0] == "D") {valasz1 = Dlett;}

                if (Fel[1] == "A") {valasz2 = Alett;}
                else if (Fel[1] == "B") {valasz2 = Blett;}
                else if (Fel[1] == "C") {valasz2 = Clett;}
                else if (Fel[1] == "D") {valasz2 = Dlett;}

                Console.Clear();
                Console.ForegroundColor = ConsoleColor.Red;

                if (Felvolt) { Console.WriteLine("Ezt a segítséget már nem használhatod!!"); }

                Console.ResetColor();

                Felvolt = true;

                Penz();
                Console.WriteLine($"{korr}.\t{kerdes}\n\n{valasz1} {valasz2}");
                Valasz();

            }
            else if (valasz != helyesvalasz && valasz != "F" && valasz != "K" && valasz != "T") {}
        }


        private static void Penz() {Console.WriteLine("----------------------------\n\n14:\t40'000'000\n13:\t20'000'000\n12:\t10'000'000\n11:\t5'000'000\n10:\t3'000'000\n9:\t1'500'000\n8:\t800'000\n7:\t300'000\n6:\t200'000\n5:\t100'000\n4:\t50'000\n3:\t25'000\n2:\t10'000\n1:\t5'000\n\n----------------------------\n\n");}
        private static string Felezes()
        {
            int felez = rnd.Next(0, 4);

            if (felez == 0) { betu = "A"; }
            if (felez == 1) { betu = "B"; }
            if (felez == 2) { betu = "C"; }
            if (felez == 3) { betu = "D"; }
            return betu;
        }

        private static void Kerdesek()
        {
            Penz();
            korr++;
            
            int random = rnd.Next(0, Million_List.Count());

            helyesvalasz = Million_List[random].HelyesValasz;
            kerdes = Million_List[random].Kerdes;
            Alett = Million_List[random].A;
            Blett = Million_List[random].B;
            Clett = Million_List[random].C;
            Dlett = Million_List[random].D;

            Console.WriteLine($"{korr}.\t{kerdes}\n\n{Alett}\t{Blett}\t{Clett}\t{Dlett}\n\nFelhasználható lehetőségek Válaszok: A, B, C, D, Segítségek: T/telefonos, K/közönség, F/felezés");

            Valasz();
            
            Million_List.RemoveAt(random);
        }

        private static void Beolvas()
        {
            var sr = new StreamReader(@"..\\..\\..\\src\\milliokerdes.txt", Encoding.Latin1);
            string sor;
            while (!sr.EndOfStream) 
            {
                sor = sr.ReadLine();
                Million_List.Add(new Millio(sor));
            }
            sr.Close();
        }
    }
}