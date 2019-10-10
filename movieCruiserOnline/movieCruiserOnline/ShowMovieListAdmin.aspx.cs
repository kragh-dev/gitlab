using Com.Cognizant.Moviecruiser.Dao;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace movieCruiserOnline
{
    public partial class ShowMovieListAdmin : System.Web.UI.Page
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
            movieTable.DataSource = movieItemDao.GetMovieItemListAdmin();
            movieTable.DataBind();
        }
    }
}