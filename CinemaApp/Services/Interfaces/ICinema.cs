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
        void BookFilm(string name);
        void ShowEmptyPlace(string name);
        void ShowAllFilms();
        void RemoveFilm(Film film);

    }
}
