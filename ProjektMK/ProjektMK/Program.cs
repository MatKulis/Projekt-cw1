using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ProjektMK
{
    class Program
    {
        static void Main(string[] args)
        {
          
            
            Console.WriteLine("Kasa fiskalna");
            Console.WriteLine("Legenda");
            Console.WriteLine("Q-Dodawanie produktu");
            Console.WriteLine("W-Dodaj ten sam produkt ponownie");
            Console.WriteLine("E-Pokaz stan koszyka");
            Console.WriteLine("R-Suma do zaplaty");           
            Console.WriteLine("T-Wydrukuj paragon");
            Console.WriteLine("Y-Wyczysc koszyk");
            Console.WriteLine("U-Zakoncz program");
            var a = Console.ReadKey();
            switch (a.Key)
            {
                case ConsoleKey.Q: 
                    {
                        
                    Console.WriteLine(" Dodawanie produktu: {0}",Zawartosc.zakupy);
                    break;
                        
                    }

                case ConsoleKey.W:
                    {
                        Console.WriteLine(" Dodwanie ponownie tego samego: {0}",Zawartosc.zakupy);
                        break;
                    }
                case ConsoleKey.E:
                    {
                        Console.WriteLine(" Pokazuje:");
                        break;
                    }
                case ConsoleKey.R:
                    {
                        Console.WriteLine(" Musisz zaplacic:");
                        break;
                    }
                case ConsoleKey.T:
                    {
                        Console.WriteLine(" Drukuje");
                        break;
                    }
                case ConsoleKey.Y:
                    {
                        Console.WriteLine(" Koszyk wyczyszczony");
                        break;
                    }
                case ConsoleKey.U:
                    {
                        Console.WriteLine(" Koncze");
                        break;
                    }
                default:
                    Console.WriteLine("Wcisnieto nie prawidlowy przycisk");
                    break;
            
            }


            Console.ReadKey();
        }
    }
}
