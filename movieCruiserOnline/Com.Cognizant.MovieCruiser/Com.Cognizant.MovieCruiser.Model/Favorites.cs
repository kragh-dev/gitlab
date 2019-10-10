using System.Collections.Generic;

namespace Com.Cognizant.Moviecruiser.Model
{
    /// <summary>
    /// Favorites class is used to the store the favorites of the user in a list manner of type "MovieItem" - custom class
    /// </summary>
    public class Favorites
    {
        private List<MovieItem> movieItemList;
        public List<MovieItem> MovieItemList
        {
            get
            {
                return movieItemList;
            }
            set
            {
                movieItemList = value;
            }
        }
        public Favorites()
        {

        }
        public Favorites(List<MovieItem> MovieItemList)
        {
            this.MovieItemList = MovieItemList;
        }
    }
}