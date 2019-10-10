using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _04_Methods
{
    class Song
    {
        public int ID { get; set; }
        public string Name { get; set; }
        public string Artist { get; set; }
        public bool isBand { get; set; }

        public string ShowTheInfos()
        {
            var x = "No";

            if (this.isBand == true)
            {
                x = "Yes";
            }
            return string.Format($"All about the song,\nID: {this.ID}\nName: {this.Name}\nArtist: {this.Artist}\nIs Band?: {x}");
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Song LookAtMeNow = new Song() {
                ID = 1,
                Name = "Look At Me Now",
                Artist = "IDC",
                isBand = false
            };

            Song Sonne = new Song();
            Sonne.ID = 2;
            Sonne.Artist = "Rammstein";
            Sonne.Name = "Sonne";
            Sonne.isBand = false;

            Song[] allSongs = new Song[]{ Sonne, LookAtMeNow};

            int a = 0;

            do
            {
                Console.WriteLine(allSongs[a].ShowTheInfos() + "\n");
                a -= -1;
            } while (a < allSongs.Length);

            int[] arrayOfNumbers = new int[] {1, 2, 3};

            int[] arrayOfNumber02 = new int[3];
            arrayOfNumber02[0] = 4;
            arrayOfNumber02[1] = 5;
            arrayOfNumber02[2] = 6;

            string[] arrayOfChars = new string[] { "a", "b", "c" };

            string[] arrayOfChars02 = new string[3];
            arrayOfChars02[0] = "d";
            arrayOfChars02[0] = "e";
            arrayOfChars02[0] = "f";



            Console.Read();

        }
    }
}
