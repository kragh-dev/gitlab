using Com.Cognizant.Moviecruiser.Model;
using System;
using System.Collections.Generic;

namespace Com.Cognizant.Moviecruiser.Dao
{
    /// <summary>
    /// This class is used to test all the methods created in FavoritesDaoCollection class to perform functionalities such as add, remove and retrival
    /// </summary>
    public class FavoritesDaoCollectionTest
    {
        static string format = "{0,-10}{1,-20}{2,-15}{3,-10}{4,-15}{5,-15}{6}";
        static string heading = string.Format(format, "ID", "Name", "Price", "Active", "Date of Launch", "Category", "Free Delivery");
        public FavoritesDaoCollectionTest()
        {
            MovieItemDaoCollection movieItemDao = new MovieItemDaoCollection();
            List<MovieItem> movieItemList = movieItemDao.GetMovieItemListAdmin();
            Console.WriteLine("Available Items:\n" + heading);
            foreach (MovieItem item in movieItemList)
            {
                Console.WriteLine(item);
            }
            string choice;
            FavoritesDaoCollection favoritesDao = new FavoritesDaoCollection();
            Console.WriteLine();
            l1: Console.Write("1. Add To Favorite\n2. Remove Favorite Movie\n3. Get All Favorite Movies\n\nEnter your choice: ");
            choice = Console.ReadLine();
            switch (choice)
            {
                case "1":
                    {
                        TestAddFavoriteMovie(favoritesDao);
                        goto l1;
                    }
                case "2":
                    {
                        TestRemoveFavoriteMovie(favoritesDao);
                        goto l1;
                    }
                case "3":
                    {
                        TestGetAllFavoriteMovies(favoritesDao);
                        goto l1;
                    }
                default:
                    {
                        Console.WriteLine("Exiting...");
                        break;
                    }

            }
            Console.WriteLine();
        }
        //This  method check the functionality to add a movie to favorites
        public static void TestAddFavoriteMovie(FavoritesDaoCollection favoritesDao)
        {
            Console.Write("Enter User ID: ");
            long userId = long.Parse(Console.ReadLine());
            Console.Write("Enter Movie ID to add to user favorites: ");
            long movieId = long.Parse(Console.ReadLine());
            favoritesDao.AddFavoriteMovie(userId, movieId);
            Favorites favoriteMovies = favoritesDao.GetAllFavoriteMovies(userId);
            Console.WriteLine("\nAfter adding entered movie in favorites...\n\n" + heading);
            foreach (MovieItem movie in favoriteMovies.MovieItemList)
            {
                Console.WriteLine(movie);
            }
            Console.WriteLine();
        }
        //This  method check the functionality to remove a movie from favorites
        public static void TestRemoveFavoriteMovie(FavoritesDaoCollection favoritesDao)
        {
            try
            {
                Console.Write("Enter User ID: ");
                long userId = long.Parse(Console.ReadLine());
                Favorites favoriteMovies = favoritesDao.GetAllFavoriteMovies(userId);
                Console.WriteLine("\n" + heading);
                foreach (MovieItem movie in favoriteMovies.MovieItemList)
                {
                    Console.WriteLine(movie);
                }
                Console.Write("Enter Movie ID to remove from user favorites: ");
                long movieId = long.Parse(Console.ReadLine());
                favoritesDao.RemoveFavoriteMovie(userId, movieId);
                favoriteMovies = favoritesDao.GetAllFavoriteMovies(userId);
                Console.WriteLine("\n" + heading);
                foreach (MovieItem movie in favoriteMovies.MovieItemList)
                {
                    Console.WriteLine(movie);
                }
                Console.WriteLine();
                throw new FavoritesEmptyException();
            }
            catch (FavoritesEmptyException e)
            {
                Console.WriteLine("\n" + e.Message + "\n");
            }
        }
        //This  method check the functionality to retrieve movies from favorites
        public static void TestGetAllFavoriteMovies(FavoritesDaoCollection favoritesDao)
        {
            try
            {
                Console.Write("Enter User ID: ");
                long userId = long.Parse(Console.ReadLine());
                Favorites favoriteMovies = favoritesDao.GetAllFavoriteMovies(userId);
                Console.WriteLine("\n" + heading);
                foreach (MovieItem movie in favoriteMovies.MovieItemList)
                {
                    Console.WriteLine(movie);
                }
                Console.WriteLine();
                throw new FavoritesEmptyException();
            }
            catch (FavoritesEmptyException e)
            {
                Console.WriteLine("\n" + e.Message + "\n");
            }
        }
    }
}