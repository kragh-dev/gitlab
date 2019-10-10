using System;

namespace Com.Cognizant.Moviecruiser.Dao
{
    /// <summary>
    /// Custom exception - this exception is throwed when the favorites list is empty
    /// </summary>
    public class FavoritesEmptyException : Exception
    {
        string output;
        //In here the message is passed to the base case by by its constructor which is displayed as message
        public FavoritesEmptyException() : base("Favorites is Empty") 
        {

        }
        public FavoritesEmptyException(string message) : base(message)
        {
            output = message;
        }
    }
}