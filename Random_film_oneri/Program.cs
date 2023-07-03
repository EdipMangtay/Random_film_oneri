using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Threading.Tasks;

namespace Random_film_oneri
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> diziler = new List<string>
        {
            "Stranger Things",
            "Black Mirror",
            "Breaking Bad",
            "Game of Thrones",
            "Friends",
            "The Office",
            "Sherlock",
            "Narcos",
            "The Crown",
            "Peaky Blinders"
        };
            List<string> filmler = new List<string>
        {
            "Inception",
            "The Dark Knight",
            "Pulp Fiction",
            "Fight Club",
            "The Shawshank Redemption",
            "The Godfather",
            "Interstellar",
            "The Matrix"
        };

            Console.WriteLine("Film/Dizi Tavsiye Uygulamasına Hoş Geldiniz!");

            while (true)
            {
                Console.WriteLine();
                Console.WriteLine("Tavsiye almak için 'tavsiye' yazın. Çıkış yapmak için 'q' tuşuna basın.");
                string s = Console.ReadLine();


                if (s == "tavsiye")
                {
                    Console.Write("Dizi mi yoksa film mi izlemek istersiniz? (dizi/film): ");
                    string secim = Console.ReadLine();
                    if (secim == "dizi")
                    {
                        Random random = new Random();
                        int index = random.Next(diziler.Count);
                        string tavsiye = diziler[index];
                        Console.WriteLine("Size Tavsiyem : " + tavsiye);

                    }
                    else if (secim == "film")
                    {
                        Random random = new Random();
                        int index1 = random.Next(filmler.Count);
                        string tavsiye1 = filmler[index1];

                        Console.WriteLine("Size Tavsiyem : " + tavsiye1);

                    }
                }
                else if (s == "q")
                {
                    Console.WriteLine("Sistemden Çıkılıyor");
                    Thread.Sleep(2000);
                    break;

                }
                else
                {
                    Console.WriteLine("Geçersiz bir işlem yaptınız");
                    Console.WriteLine("Bir daha deneyiniz");
                    Console.WriteLine();

                }
            }
        }
    }
}
