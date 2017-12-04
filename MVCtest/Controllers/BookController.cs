﻿using MVCtest.Models;
using MVCtest.Sevice;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCtest.Controllers
{
    public class BookController : Controller
    {

        BookService _service = new BookService();
        // GET: Book
        public ActionResult Index()
        {
            return RedirectToAction("List");
        }

        public ActionResult List()
        {
            var list = _service.GetModel();
            return View(list);
        }

        public ActionResult AddNew()
        {
            return View();
        }

       

        public ActionResult Add(BookModel model,string BtnSubmit)
        {
            switch (BtnSubmit)
            {
                case "保存":
                    _service.Add(model);
                    return RedirectToAction("Index");
                case "取消":
                    return RedirectToAction("Index");
            }
            return new EmptyResult();
        }
    }
}