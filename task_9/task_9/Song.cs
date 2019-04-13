using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace task9
{
    class Song
    {
        public string NameOfSong { get => NameOfSong; set => NameOfSong = value; }
        public double LengthOfSong { get => LengthOfSong; set => LengthOfSong = value; }
        public string Author { get => Author; set => Author = value; }
        public int DataOfRelease { get => DataOfRelease; set => DataOfRelease = value; }
        internal Genres Genres { get => Genres; set => Genres = value; }

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
