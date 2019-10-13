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
    public partial class ShowFavorites : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
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
            long id = 1;
            try
            {
                var count = favoritesDao.GetAllFavoriteMovies(id).MovieItemList.Count;
                if (count > 0)
                {
                    movieTable.DataSource = favoritesDao.GetAllFavoriteMovies(id).MovieItemList;
                    movieTable.DataBind();
                    lblCount.Visible = true;
                    favCount.Text = count.ToString();
                }
                else
                {
                    throw new FavoritesEmptyException();
                }
            }
            catch (FavoritesEmptyException favoritesEmptyException)
            {
                favEmpty.Text = favoritesEmptyException.Message + ". Use 'Add to Favorites' option in the ";
                favEmptyLink.Visible = true;
            }
        }
        [WebMethod, ScriptMethod]
        public static bool DeleteMovieFromFavorites(long movieId, long userId)
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
            favoritesDao.RemoveFavoriteMovie(userId, movieId);
            return true;
        }
    }
}