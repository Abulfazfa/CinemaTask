using CinemaApp.Models.BaseEntity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CinemaApp.Services.Interfaces
{
    internal interface ICinema
    {
        void AddFilm();
        void FindByCatagory(int number);
        void FindByAddress(string address);
        void BookFilm(string name, int column, int row);
        void ShowEmptyPlace(string name);
        void ShowAllFilms();
        void ShowAllFilmInCertainCinema(string name);
        void RemoveFilm(Film film);

    }
}
