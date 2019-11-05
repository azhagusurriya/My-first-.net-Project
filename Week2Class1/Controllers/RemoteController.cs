using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;

namespace Week2Class1.Controllers
{
    public class RemoteController : Controller
    {
        public JsonResult CheckNames(string username, string firstname, string lastname)
        {
            if (String.IsNullOrWhiteSpace(username) ||
                string.IsNullOrWhiteSpace(firstname) ||
                string.IsNullOrWhiteSpace(lastname))
            {
                return Json(false);
            }
            if (username.Contains(firstname.ToLower()) || username.Contains(lastname.ToLower()))
                return Json("username cannot be derieved from the user's first or last name");
            else
                return Json(true);
        }
    }
}