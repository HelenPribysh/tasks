using System;
using static task9.Genres;
using Newtonsoft.Json;

namespace task9
{
    class Program
    {
        static void Main(string[] args)
        {
            Song song = new Song("Umbrella", 4, "Rihanna", 2007, pop);            
            var data = GetSongData(song);

            Console.WriteLine(data);
            JsonConvert.SerializeObject(data);
        }

        public static dynamic GetSongData(Song song)
        {
            var data = new
            {
                Name = song.NameOfSong,
                Lenth = song.LengthOfSong,
                Year = song.DataOfRelease
            };

            //Console.WriteLine($"{song.NameOfSong}, {song.LengthOfSong}, {song.DataOfRelease}");
            return data;
        }
    }
}
