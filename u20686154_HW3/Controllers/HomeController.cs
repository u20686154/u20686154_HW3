using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace u20686154_HW3.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public ActionResult Index(string fileSelection, HttpPostedFileBase files)
        {
            ViewBag.Msg = fileSelection;
            if(fileSelection == "Image")
            {
                if (files != null && files.ContentLength > 0)
                {
          
                    var fileName = Path.GetFileName(files.FileName);

               
                    var path = Path.Combine(Server.MapPath("~/Media/Images/"), fileName);

            

                    files.SaveAs(path);
                }
            }

            if (fileSelection == "Document")
            {
                if (files != null && files.ContentLength > 0)
                {

                    var fileName = Path.GetFileName(files.FileName);


                    var path = Path.Combine(Server.MapPath("~/Media/Documents/"), fileName);


                    files.SaveAs(path);
                }
            }
            if (fileSelection == "Video")
            {
                if (files != null && files.ContentLength > 0)
                {
          
                    var fileName = Path.GetFileName(files.FileName);
                    var path = Path.Combine(Server.MapPath("~/Media/Videos/"), fileName);

                    files.SaveAs(path);
                }
            }
            return View();
        }

        public ActionResult AboutMe()
        {
            return View();
        }

      

      
    }
}