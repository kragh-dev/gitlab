using Com.Cognizant.Moviecruiser.Dao;
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
            IMovieItemDao movieItemDao = new MovieItemDaoCollection();
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
            favoritesDao.AddFavoriteMovie(userId, movieId);
            return true;
        }
    }
}