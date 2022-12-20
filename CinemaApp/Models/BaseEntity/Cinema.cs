using CinemaApp.Services.Enums;
using CinemaApp.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaApp.Models.BaseEntity
{
    internal class Cinema : ICinema
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public Cinema[,] Places;
        List<Film> Films { get; set; }
        public Cinema()
        {
            Places = new Cinema[10,5];
            Films = new();
        }

        public void AddFilm()
        {
            Film film1 = new()
            {
                Name = "Action Film 1",
                Price = 11,
                Catagory = (int)CatagoryOfFilms.Action
            };
            Film film2 = new()
            {
                Name = "Romantic Film 1",
                Price = 12,
                Catagory = (int)CatagoryOfFilms.Romantic
            };
            Film film3 = new()
            {
                Name = "Action Film 2",
                Price = 13,
                Catagory = (int)CatagoryOfFilms.Action
            };
            Film film4 = new()
            {
                Name = "Horrow Film 1",
                Price = 14,
                Catagory = (int)CatagoryOfFilms.Horrow
            };
            Film film5 = new()
            {
                Name = "Historical Film 1",
                Price = 15,
                Catagory = (int)CatagoryOfFilms.Historical
            };
            
            Films.Add(film1);
            Films.Add(film2);
            Films.Add(film3);
            Films.Add(film4);
            Films.Add(film5);
        }

        public void FindByCatagory(int number)
        {
                switch (number)
                {
                    case (int)CatagoryOfFilms.Horrow:
                   List<Film> horrowFilms = Films.FindAll(f => f.Catagory == (int)CatagoryOfFilms.Horrow);
                        break;
                    case (int)CatagoryOfFilms.Historical:
                    List<Film> historicalFilms = Films.FindAll(f => f.Catagory == (int)CatagoryOfFilms.Historical);
                        break;
                    case (int)CatagoryOfFilms.Action:
                    List<Film> actionFilms = Films.FindAll(f => f.Catagory == (int)CatagoryOfFilms.Action);
                        break;
                    case (int)CatagoryOfFilms.Romantic:
                    List<Film> romanticFilms = Films.FindAll(f => f.Catagory == (int)CatagoryOfFilms.Romantic);
                        break;
                }
            
        }

        public void FindByAddress(string address)
        {
           
        }

        public void BookFilm(string name)
        {
           
        }

        public void ShowEmptyPlace(string name)
        {
            throw new NotImplementedException();
        }

        public void ShowAllFilms()
        {

        }

        public void RemoveFilm(Film film)
        {
            throw new NotImplementedException();
        }
    }
}