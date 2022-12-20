// See https://aka.ms/new-console-template for more information
//Console.WriteLine("Hello, World!");
using CinemaApp.Models.BaseEntity;
Film film = new();
Cinema Cinema = new();
foreach (var item in Cinema.Places)
{
    Console.WriteLine(item);
}
