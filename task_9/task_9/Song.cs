using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace task9
{
    class Song
    {
        private string nameOfSong;
        private double lengthOfSong;
        private string author;
        private int dataOfRelease;
        private Genres genres;

        public string NameOfSong { get => nameOfSong; set => nameOfSong = value; }
        public double LengthOfSong { get => lengthOfSong; set => lengthOfSong = value; }
        public string Author { get => author; set => author = value; }
        public int DataOfRelease { get => dataOfRelease; set => dataOfRelease = value; }
        internal Genres Genres { get => genres; set => genres = value; }

        public Song(string _nameOfSong, double _lengthOfSong, string _author, int _dataOfRelease, Genres _genres)
        {
            NameOfSong = _nameOfSong;
            LengthOfSong = _lengthOfSong;
            Author = _author;
            DataOfRelease = _dataOfRelease;
            Genres = _genres;
        }        
    }

    internal enum Genres
    {
        pop, metal, reggi
    };

}
