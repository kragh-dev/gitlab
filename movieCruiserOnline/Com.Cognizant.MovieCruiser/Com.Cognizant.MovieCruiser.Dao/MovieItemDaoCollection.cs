using System;
using System.Collections.Generic;
using Com.Cognizant.Moviecruiser.Model;
using Com.Cognizant.Moviecruiser.Dao;

namespace Com.Cognizant.Moviecruiser.Dao
{
    public class MovieItemDaoCollection : IMovieItemDao
    {
        public List<MovieItem> movieItemList;
        public MovieItemDaoCollection()
        {
            if (movieItemList == null)
            {
                movieItemList = new List<MovieItem>()
                {
                    new MovieItem(101,"Avengers",356000000,true,DateTime.ParseExact("26/04/2018","dd/MM/yyyy",null),"Action Sci-Fi",true),
                    new MovieItem(102,"Alladin",183000000,true,DateTime.ParseExact("23/06/2019","dd/MM/yyyy",null),"Adventure",true),
                    new MovieItem(103,"Pizza",10000000,false,DateTime.ParseExact("21/06/2014","dd/MM/yyyy",null),"Comedy Drama",false),
                    new MovieItem(104,"Mankatha",234567890,true,DateTime.ParseExact("31/08/2012","dd/MM/yyyy",null),"Action",true),
                    new MovieItem(105,"Mersal",98767543,true,DateTime.ParseExact("02/11/2017","dd/MM/yyyy",null),"Action",false),
                };
            }
        }
        public List<MovieItem> GetMovieItemListAdmin()
        {
            return movieItemList;
        }
        public List<MovieItem> GetMovieItemListCustomer()
        {
            List<MovieItem> customerItemList = new List<MovieItem>();
            foreach (MovieItem movie in movieItemList)
            {
                if (movie.Active)
                {
                    customerItemList.Add(movie);
                }
            }
            return customerItemList;
        }
        public MovieItem GetMovieItem(long movieItemId)
        {
            int itemIndex = movieItemList.FindIndex(movie => movie.ID == movieItemId);
            return movieItemList[itemIndex];
        }
        public void ModifyMovieItem(MovieItem movieItem)
        {
            int itemIndex = movieItemList.FindIndex(movie => movie.ID == movieItem.ID);
            movieItemList[itemIndex] = movieItem;
        }
    }
}