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
        public static int CinemaCounter { get; set; }
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Address { get; set; }
        public int[,] Places;
        List<Cinema> Cinemas;
        List<Film> Films { get; set; }
        public Cinema()
        {
            CinemaCounter++;
            Id = CinemaCounter;
            Places = new int[10, 5];
            Films = new();
            Cinemas = new();
        }

        public void AddFilm()
        {
            Cinema cinema1 = new()
            {
                Name = "28 May Cinema",

                Address = "28 May"
            };
            Cinema cinema2 = new()
            {
                Name = "Ganclik Cinema",

                Address = "Ganclic Mall"
            };
            Cinema cinema3 = new()
            {
                Name = "Park Bulvar Cinema",

                Address = "Park Bulvar"
            };
            Cinemas.Add(cinema1);
            Cinemas.Add(cinema2);
            Cinemas.Add(cinema3);
          

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
            switch (address)
            {
                case "28 May":
                    List<Cinema> cinema1 = Cinemas.FindAll(f => f.Address == "28 May");
                    break;
                case "Ganclic Mall":
                    List<Cinema> cinema2 = Cinemas.FindAll(f => f.Address == "Ganclic Mall");
                    break;
                case "Park Bulvar":
                    List<Cinema> cinema3 = Cinemas.FindAll(f => f.Address == "Park Bulvar");
                    break;
                
            }
        }

        public void BookFilm(string name, int column, int row)
        {
            foreach (var film in Films)
            {
                if (film.Name == name && film.Count > 0)
                {
                    film.Count--;
                    Places[column, row] = 1;
                    Console.WriteLine($"You book successfully ticket for {film.Name}");
                }
            }
        }

        public void ShowEmptyPlace(string name)
        {
            Cinema cinema = Cinemas.Find(c => c.Name == name);
            int count = 0;
            foreach (var item in cinema.Places)
            {
                if (item == 0)
                {
                    count++;
                }
            }
            Console.WriteLine(count);
        }

        public void ShowAllFilms()
        {
            foreach (var film in Films)
            {
                Console.WriteLine(film.Name + " " + film.Catagory);
            }
        }
        public void ShowAllFilmInCertainCinema(string name)
        {
            foreach (var cinema in Cinemas)
            {
                if (name == cinema.Name)
                {
                    foreach (var film in Films)
                    {
                        Console.WriteLine(film.Name + " " + film.Catagory);
                    }
                }
            }
        }

        public void RemoveFilm(Film film)
        {
            
        }
    }
}