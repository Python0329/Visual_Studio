using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;

namespace Variabler
{
    class Program
    {
        static void Main(string[] args)
        {
            String facit;
            string Åsikt;
            double radie;
            double pi;
            double höjd;
            int decimaler;

            Console.WriteLine("vad är radien?");
            radie = double.Parse(Console.ReadLine());
            Console.WriteLine("vad är höjden?");
            höjd = double.Parse(Console.ReadLine());
            Console.WriteLine("Hur många decimaler vill du ha?");
            decimaler = int.Parse(Console.ReadLine());
            facit = "ja";

            Console.WriteLine("Volymen är" + Math.Round((Math.Pow(radie, 2) * Math.PI * höjd), decimaler) + "cm^3");

            Console.WriteLine("Är du nöjd?");
            Åsikt = Console.ReadLine();

            if (Åsikt == facit)
            {
                Console.WriteLine("Va Bra!!");
            }

            else
            {
                Console.WriteLine("va tråkigt!!");
            }

            //Övning 1

            double Tal1;
            double Tal2;

            Console.WriteLine("Mata in tal 1:");
            Tal1 = double.Parse(Console.ReadLine());
            Console.WriteLine("Mata in tal 2:");
            Tal2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Summan:" + (Tal1 + Tal2));
            Console.WriteLine("Produkten:" + Tal1 * Tal2);
            Console.WriteLine("Divisionen:" + Tal1 / Tal2);

            //Övning 2

            string Förnamn;
            string Efternamn;

            Console.WriteLine("Mata in ditt förnamn:");
            Förnamn = Console.ReadLine();
            Console.WriteLine("Mata in ditt efternamn:");
            Efternamn = Console.ReadLine();
            Console.WriteLine(Förnamn + (" ") + Efternamn);

            //Övning 3 / 4

            //variabler
            double Grader;

            //Efterfrågan
            //Console.WriteLine("Mata in grader i celsius:");
            Console.Write("Mata in grader i celsius:");
            Grader = double.Parse(Console.ReadLine());
            Console.WriteLine("Det blir " + (Grader * 1.8 + 32) + " grader Farenheit");

            //Övning 5

            double radie2;

            Console.Write("cirkelns radie:");
            radie2 = double.Parse(Console.ReadLine());
            Console.WriteLine("Area: " + Math.Pow(radie2, 2) * Math.PI);
            Console.WriteLine("Omkrets: " + 2 * radie2 * Math.PI);

            //Inlämningsuppgift

            // Deklarerar att det finns två variabler.
            string Namn;
            int Ålder;

            //Skapar en finn ruta högst upp i programet.
            Console.WriteLine("*********************************************");
            Console.WriteLine("*                                           *");
            Console.WriteLine("*               PENSIONSÅLDER               *");
            Console.WriteLine("*                                           *");
            Console.WriteLine("*********************************************");
            Console.WriteLine();

            //Frågar efter Informationen
            Console.Write("Vad är ditt namn? ");
            Namn = Console.ReadLine();
            Console.Write("Hur gammal är du? ");
            Ålder = int.Parse(Console.ReadLine());

            //Gör det fint
            Console.WriteLine();
            Console.WriteLine("*********************************************");
            Console.WriteLine();

            //Skriver ut hur många år det är kvar m.m
            Console.WriteLine("Hej " + Namn + "," + " du har " + (65 - Ålder) + " år kvar till pensionen.");

            //Extraupgift

            //(1)

            double tal11;
            double tal12;
            double tal13;

            Console.Write("Vad är tal 1?");
            tal11 = double.Parse(Console.ReadLine());
            Console.Write("Vad är tal 2?");
            tal12 = double.Parse(Console.ReadLine());
            Console.Write("Vad är tal 3?");
            tal13 = double.Parse(Console.ReadLine());

            Console.WriteLine("Summan av talen är " + (tal11 + tal12 + tal13) + "!");
            Console.WriteLine("Medelvärdet av talen är " + ((tal11 + tal12 + tal13) / 3) + "!");

            //(2)

            double Höjd_Triangel;
            double Basen_Triangel;

            Console.Write("Vad är Höjden?");
            Höjd_Triangel = double.Parse(Console.ReadLine());
            Console.Write("Vad är Basen?");
            Basen_Triangel = double.Parse(Console.ReadLine());

            Console.WriteLine("Arean av triangeln är" + ((Höjd_Triangel * Basen_Triangel) / 2) + "cm^2");

            //(3)

            Console.WriteLine(Math.Pow(9, 2));
            Console.WriteLine(Math.Sqrt(81));
            Console.WriteLine(Math.Cos((30 * (Math.PI)) / 180));





            //hej deta var skoj

        }
    }
}
