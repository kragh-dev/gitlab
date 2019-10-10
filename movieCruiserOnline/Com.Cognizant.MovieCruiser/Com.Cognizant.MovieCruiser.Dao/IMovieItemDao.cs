using Com.Cognizant.Moviecruiser.Model;
using System.Collections.Generic;

namespace Com.Cognizant.Moviecruiser.Dao
{
    public interface IMovieItemDao
    {
        List<MovieItem> GetMovieItemListAdmin();
        List<MovieItem> GetMovieItemListCustomer();
        void ModifyMovieItem(MovieItem movieItem);
        MovieItem GetMovieItem(long movieItemId);
    }
}
