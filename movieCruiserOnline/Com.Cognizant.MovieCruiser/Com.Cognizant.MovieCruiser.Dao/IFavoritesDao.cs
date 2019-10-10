using Com.Cognizant.Moviecruiser.Model;

namespace Com.Cognizant.Moviecruiser.Dao
{
    //This interface is to give a basic structure how the functions should be implemented to the FavoriteDaoCollection
    public interface IFavoritesDao
    {
        void AddFavoriteMovie(long userId, long movieItemId);
        Favorites GetAllFavoriteMovies(long userId);
        void RemoveFavoriteMovie(long userId, long movieItemId);
    }
}
