using Com.Cognizant.Moviecruiser.Dao;
using Com.Cognizant.Moviecruiser.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Script.Services;
using System.Web.Services;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace movieCruiserOnline
{
    public partial class ShowMovieListCustomer : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            IMovieItemDao movieItemDao;
            if (HttpContext.Current.Session["adminObj"] == null)
            {
                movieItemDao = new MovieItemDaoCollection();
                HttpContext.Current.Session["adminObj"] = movieItemDao;
            }
            else
            {
                movieItemDao = (IMovieItemDao)HttpContext.Current.Session["adminObj"];
            }
            movieTable.DataSource = movieItemDao.GetMovieItemListCustomer();
            movieTable.DataBind();
        }
        [WebMethod, ScriptMethod]
        public static bool AddMovieToFavorites(long movieId, long userId)
        {
            IFavoritesDao favoritesDao;
            if (HttpContext.Current.Session["customerObj"] == null)
            {
                favoritesDao = new FavoritesDaoCollection();
                HttpContext.Current.Session["customerObj"] = favoritesDao;
            }
            else
            {
                favoritesDao = (IFavoritesDao)HttpContext.Current.Session["customerObj"];
            }
            List<long> movieIds;
            if (HttpContext.Current.Session["movieIds"] == null)
            {
                movieIds = new List<long>() { };
                HttpContext.Current.Session["movieIds"] = movieIds;
            }
            else
            {
                movieIds = (List<long>)HttpContext.Current.Session["movieIds"];
            }
            if (movieIds.Contains(movieId))
            {
                return false;
            }
            else
            {
                favoritesDao.AddFavoriteMovie(userId, movieId);
                movieIds.Add(movieId);
                return true;
            }
            //favoritesDao.AddFavoriteMovie(userId, movieId);
            //return true;
        }
    }
}