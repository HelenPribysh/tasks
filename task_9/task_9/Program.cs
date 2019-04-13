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
            Console.WriteLine(JsonConvert.SerializeObject(data));
        }

        public static dynamic GetSongData(Song song)
        {
            return new
            {
                Name = song.NameOfSong,
                Lenth = song.LengthOfSong,
                Year = song.DataOfRelease
            };
        }
    }
}
