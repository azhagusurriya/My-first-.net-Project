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
            bool result = ValidationClassLibrary.ValidationsHelper.CheckNames(username, firstname, lastname); 
            if (result)
                return Json("username cannot be derieved from the user's first or last name");
            else
                return Json(true);
        }
    }
}