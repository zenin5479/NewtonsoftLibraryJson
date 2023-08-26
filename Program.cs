﻿using Newtonsoft.Json;
using System;
using System.Collections.Generic;

namespace NewtonsoftLibraryJson
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Сериализация");
            // 1. Сериализация
            Movie movie = new Movie { Id = 1, Title = "Миссия невыполнима" };
            // movie - это объект, преобразуем его в строку с помощью JsonConvert.SerializeObject           
            string result = JsonConvert.SerializeObject(movie);
            // Преобразуется в строку в виде {"Id":1,"Title":"Mission Impossible"}
            Console.WriteLine(result);

            Console.WriteLine("\nДесериализация");
            // 2. Десериализация
            Movie newMovie = JsonConvert.DeserializeObject<Movie>(result);
            // Теперь строка преобразуется в объект           
            Console.WriteLine("Id : " + newMovie.Id);
            Console.WriteLine("Title : " + newMovie.Title);

            Console.WriteLine("\nСериализация коллекции");
            // 3. Сериализация коллекции
            List<Movie> movies = new List<Movie>  {
                new Movie{ Id=1, Title="Титаник" },
                new Movie{ Id=2, Title="Марсианин"},
                new Movie{ Id=3, Title="Черная пантера"} ,
                new Movie{ Id=4, Title="Дэдпул 2"} ,
            };

            string collectionResult = JsonConvert.SerializeObject(movies);
            Console.WriteLine(collectionResult);

            Console.WriteLine("\nДесериализация коллекции");
            // 4. Десериализация коллекции
            List<Movie> newMovies = JsonConvert.DeserializeObject<List<Movie>>(collectionResult);
            foreach (var item in newMovies)
            {
                Console.WriteLine("Id : " + item.Id + "\tTitle : " + item.Title);
            }
            Console.ReadKey();
        }
    }

    class Movie
    {
        public int Id { get; set; }
        public string Title { get; set; }
    }
}