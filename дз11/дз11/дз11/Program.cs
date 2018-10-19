using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace дз11
{
    class Program
    {
        static void Main(string[] args)
        {
            do
            {
                Random rand = new Random();
                int corzina = rand.Next(40, 140);
                int colIgroks = rand.Next(2, 8);
                Igrok[] masIgrok = new Igrok[colIgroks];

                var Igrokbloknot = new Igrok_bloknot();
                Igrokbloknot.name = "Вася";

                var Igrok = new Igrok();
                Igrok.name = "Петя";

                var UderIgrok = new Uber_igrok();
                UderIgrok.name = "Света";

                var UderChiter = new Uber_chiter();
                UderChiter.name = "Dasha";

                var Chiter = new Chiter();
                Chiter.name = "Sasha";

                for (int i = 0; i > masIgrok.Length; i++)
                {
                    int chisloName = rand.Next(10);
                    if (chisloName >= 9)
                    {
                        masIgrok[i] = UderChiter;
                    }
                    else if (chisloName >= 7)
                    {
                        masIgrok[i] = Chiter;

                    }
                    else if (chisloName >= 5)
                    {
                        masIgrok[i] = Igrokbloknot;
                    }
                    else if (chisloName >= 2)
                    {
                        masIgrok[i] = Igrok;
                    }
                    else if (chisloName >= 0)
                    {
                        masIgrok[i] = UderIgrok;
                    }
                }
                Console.WriteLine("игра начинаеться: ");
                Console.WriteLine("вес корзины:");
                Console.WriteLine(corzina);

                    foreach (var Igrokmass in masIgrok)
                    {
                        if (Igrokmass != null)
                        {
                            if (Igrokmass is IHod)
                            {
                                var stored1 = Igrokmass as IHod;
                            }
                            int igrokCorzina = Igrokmass.CorzinoI;
                            Console.WriteLine($"{Igrokmass.name} {Igrokmass.CorzinoI}");
                            if (igrokCorzina == corzina)
                            {
                                Console.WriteLine($"{Igrokmass.name} игрок выиграл");
                                break;
                            }

                        }
                    }
               


            } while (Console.ReadKey().Key != ConsoleKey.Escape);
        }

    }
}
