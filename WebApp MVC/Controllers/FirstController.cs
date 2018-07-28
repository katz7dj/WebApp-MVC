using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApp_MVC.Controllers
{
    public class FirstController : Controller
    {
        // GET: First
        public string Index()
        {
            return "This is my <b>default</b> action...";
        }

        public string Welcome(string name, int numTimes = 1)
        {
            return HttpUtility.HtmlEncode("Hello" + name + ", numTimes is: " + numTimes);//used for malicious software
        }
    }
}