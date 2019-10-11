using Com.Cognizant.Moviecruiser.Dao;
using Com.Cognizant.Moviecruiser.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace movieCruiserOnline
{
    public partial class ShowEditMovieItem : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            if (!IsPostBack)
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
                    HttpContext.Current.Session["adminObj"] = movieItemDao;
                }
                MovieItem item = movieItemDao.GetMovieItem(long.Parse(Request.QueryString["movieId"]));
                txtMovieName.Text = item.Title;
                txtGross.Text = item.Budget.ToString();
                if (item.Active.Equals(true))
                {
                    radioItemActive.SelectedValue = "Yes";
                }
                else
                {
                    radioItemActive.SelectedValue = "No";
                }
                txtDOL.Text = item.DateOfLaunch.ToString("yyyy-MM-dd");
                dropDownItemCategory.SelectedValue = item.Genre;
                checkBoxHasTeaser.Checked = item.HasTeaser;
            }
        }

        protected void btnSave_Click(object sender, EventArgs e)
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
                HttpContext.Current.Session["adminObj"] = movieItemDao;
            }
            long id = long.Parse(Request.QueryString["movieId"]);
            string itemName = txtMovieName.Text;
            long itemPrice = long.Parse(txtGross.Text);
            bool itemStatus = (radioItemActive.SelectedValue.Equals("yes", StringComparison.InvariantCultureIgnoreCase)) == true ? true : false;
            DateTime dateOfLaunch = DateTime.ParseExact(txtDOL.Text, "yyyy-MM-dd", null);
            string category = dropDownItemCategory.SelectedValue;
            bool deliveryStatus = checkBoxHasTeaser.Checked == true ? true : false;
            MovieItem item = new MovieItem(id, itemName, itemPrice, itemStatus, dateOfLaunch, category, deliveryStatus);
            movieItemDao.ModifyMovieItem(item);
            Response.Redirect("EditMovieItemStatus.aspx");
        }
    }
}