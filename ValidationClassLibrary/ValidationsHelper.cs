using System;
using System.Collections.Generic;
using System.Text;

namespace ValidationClassLibrary
{
    public class ValidationsHelper
    {
        public static bool CheckNames(
            string username, 
            string firstname, 
            string lastname)
        {
            if (string.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(firstname) ||
                string.IsNullOrWhiteSpace(lastname))
            {
                return false;
            }
            username = username.ToLower();

            if (username.Contains(firstname.ToLower()) || username.Contains(lastname.ToLower()))
                return false;
            else
                return true;
        }
    }
}
