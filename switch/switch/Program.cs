using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace @switch
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int day = 0;
            //Console.Write("Hanyadik napot írjam ki?: ");
            //day = Convert.ToInt32(Console.ReadLine());
            //switch (day)
            //{
            //    case 1:
            //        Console.WriteLine("Hétfő");
            //        break;
            //    case 2:
            //        Console.WriteLine("Kedd");
            //        break;
            //    case 3:
            //        Console.WriteLine("Szerda");
            //        break;
            //    case 4:
            //        Console.WriteLine("Csütörtök");
            //        break;
            //    case 5:
            //        Console.WriteLine("Péntek");
            //        break;
            //    case 6:
            //        Console.WriteLine("Szombat");
            //        break;
            //    case 7:
            //        Console.WriteLine("Vasárnap");
            //        break;
            //    default:
            //        Console.WriteLine("Nincs ilyen nap");
            //        break;
            //}
            //Console.ReadLine();

            //int jegy = 0;
            //Console.Write("Adja meg a jegyet: ");
            //jegy = Convert.ToInt32(Console.ReadLine());
            //switch (jegy)
            //{
            //    case 1:
            //        Console.WriteLine("Elégtelen");
            //        break;
            //    case 2:
            //        Console.WriteLine("Elégséges");
            //        break;
            //    case 3:
            //        Console.WriteLine("Közepes");
            //        break;
            //    case 4:
            //        Console.WriteLine("Jó");
            //        break;
            //    case 5:
            //        Console.WriteLine("Jeles");
            //        break;
            //    default:
            //        Console.WriteLine("Érvénytelen jegyformátum");
            //        break;
            //}
            //    Console.ReadKey();
            
            Random random = new Random();
            Console.WriteLine("Dobok egy kockával...");
            int szam = random.Next(1, 7);
            Console.WriteLine("A dobott szám: " + szam);
            switch (szam)
            {
                case 1:
                    int elso = random.Next(random.Next(1, 7));
                    Console.WriteLine($"Második dobásod: {elso}");
                    if (elso == 6)
                    {
                        Console.WriteLine("Nyertél egy TV-t!");
                    }
                    else
                        Console.WriteLine("Nem nyertél semmit.");
                    break;
                case 2:
                    Console.WriteLine("Nyertél 10000Ft-ot!");
                    break;
                case 3:
                    Console.WriteLine("Nem nyertél semmit.");
                    break;
                case 4:
                    int negyedik = random.Next(1, 7);
                    Console.WriteLine($"Második dobásod: {negyedik}");
                    Console.WriteLine($"Nyertél {(szam + negyedik) * 1000} Ft-ot!");
                    break;
                case 5:
                    int otodik = random.Next(1, 7);
                    Console.WriteLine($"Második dobásod: {otodik}");
                    Console.WriteLine($"Nyertél {(szam + otodik) * 10000} Ft-ot!");
                    break;
                case 6:
                    Console.WriteLine("Megnyerted a fődíjat! Kétszemélyes utazás a kiválasztott helyre!");
                    break;
                default:
                    Console.WriteLine("Te ilyet hogy dobtal");
                    break;
            }
        Console.ReadKey();

        }
    }
}
