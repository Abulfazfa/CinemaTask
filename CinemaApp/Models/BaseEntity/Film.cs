using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaApp.Models.BaseEntity
{
    internal class Film
    {
        public int Id { get; set; }
        public static int FilmCounter { get; set; }
        public string? Name { get; set; }
        public int Catagory { get; set; }
        public int Price { get; set; }
        public int Count { get; set; }
        public Film()
        {
            FilmCounter++;
            Id = FilmCounter;
        }
    }
}
