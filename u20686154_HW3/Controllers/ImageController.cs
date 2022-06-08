﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using u20686154_HW3.Models;

namespace u20686154_HW3.Controllers
{
    public class ImageController : Controller
    {
        // GET: File
        public ActionResult Index()
        {
          

            string[] filePaths = Directory.GetFiles(Server.MapPath("~/Media/Images/"));

           

            List<FileModel> files = new List<FileModel>();

            foreach (string filePath in filePaths)
            {
                files.Add(new FileModel { FileName = Path.GetFileName(filePath) });
            }

            return View(files);
        }

        public FileResult DownloadFile(string fileName) 
        {
            

            string path = Server.MapPath("~/Media/Images/") + fileName;

           

            byte[] bytes = System.IO.File.ReadAllBytes(path);

          

            return File(bytes, "application/octet-stream", fileName);
        }

        public ActionResult DeleteFile(string fileName)
        {
           

            string path = Server.MapPath("~/Media/Images/") + fileName;
            byte[] bytes = System.IO.File.ReadAllBytes(path);

            System.IO.File.Delete(path);

            return RedirectToAction("Index");
        }
    }
}