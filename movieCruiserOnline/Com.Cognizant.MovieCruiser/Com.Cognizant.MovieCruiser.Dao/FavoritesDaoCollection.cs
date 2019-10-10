using Com.Cognizant.Moviecruiser.Model;
using System.Collections.Generic;

namespace Com.Cognizant.Moviecruiser.Dao
{
    /// <summary>
    /// This class is to implement basic functionalities of a favorites page such as add, remove and fetch
    /// </summary>
    public class FavoritesDaoCollection : IFavoritesDao
    {
        private static Dictionary<long, Favorites> userFavorites;
        public FavoritesDaoCollection()
        {
            if (userFavorites == null)
                userFavorites = new Dictionary<long, Favorites>();
        }
        //This method adds the movie to the user's favorites using the movie id from the displayed list
        public void AddFavoriteMovie(long userId, long movieItemId)
        {
            MovieItemDaoCollection movieItemDao = new MovieItemDaoCollection();
            MovieItem movieItem = movieItemDao.GetMovieItem(movieItemId);
            if (userFavorites.ContainsKey(userId))
            {
                userFavorites[userId].MovieItemList.Add(movieItem);
            }
            else
            {
                userFavorites.Add(userId, new Favorites(new List<MovieItem>() { movieItem }));
            }
        }
        //This method fetches and returns all the movie details present in the favorites list of the user
        public Favorites GetAllFavoriteMovies(long userId)
        {
            if (userFavorites.ContainsKey(userId))
            {
                return userFavorites[userId];
            }
            else
                throw new FavoritesEmptyException("Favorites List is empty");
        }
        //this method removes the movie item from user's cart according to the movie id from the displayed list
        public void RemoveFavoriteMovie(long userId, long movieItemId)
        {
            Favorites favoriteMovies = GetAllFavoriteMovies(userId);
            int movieId = favoriteMovies.MovieItemList.FindIndex(i => i.ID == movieItemId);
            userFavorites[userId].MovieItemList.Remove(favoriteMovies.MovieItemList[movieId]);
        }
    }
}