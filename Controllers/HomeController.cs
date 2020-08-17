using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCEcommerce.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult About()
        {
            ViewBag.Message = "Your application description page.";

            return View();
        }

        public ActionResult Contact()
        {
            ViewBag.Message = "Your contact page.";

            return View();
        }

        public ActionResult Store()
        {
            ViewBag.Message = "Your Product page.";
            SqlConnection Con = new SqlConnection();
            string path = ConfigurationManager.ConnectionStrings["dbpath"].ConnectionString;
            Con.ConnectionString = path;
            DataTable dt = new DataTable();
            return View();
        }
    }
}