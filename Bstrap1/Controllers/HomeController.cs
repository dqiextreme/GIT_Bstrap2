using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

using Bstrap2.Models;
using Bstrap2.Clases;

using Microsoft.Web.WebPages.OAuth;
using WebMatrix.WebData;



namespace Bstrap2.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index(LoginModel model)
        {
            //var a = WebSecurity.IsAuthenticated.ToString();

            if (WebSecurity.IsAuthenticated)
            {
                return View();
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
        }

        public ActionResult Index2()
        {
            return View();
        }

        public ActionResult Grid()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            var res = Badjunto.all();
            ViewBag.res = res;
            return View(res);
        }

        public ActionResult Grid2()
        {
            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            //var res = Badjunto.all().Select(x=> new { x.Archivo, x.ID}).ToList();
            var res = Badjunto.all();

            ViewBag.res = res;
            return View(res);
        }

        public ActionResult Grid3()
        {
            if (WebSecurity.IsAuthenticated)
            {
                ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
                //var res = Badjunto.all().Select(x=> new { x.Archivo, x.ID}).ToList();
                var res = Badjunto.all();

                ViewBag.res = res;
                return View(res);
            }
            else
            {
                return RedirectToAction("Login", "Account");
            }
        }

        public ActionResult _test_partial3(int id, string id2)
        {
            var res2 = Badjunto.all().ToList();
            if (id2 == "1")
            {
                res2 = res2.OrderBy(x => x.ID).ToList();
            }
            else
            {
                res2 = res2.OrderByDescending(x => x.ID).ToList();
            }

            ViewBag.res2 = res2;
            return PartialView();
        }

        public ActionResult _test_partial32(int id2)
        {
            var res2 = Badjunto.all().ToList();
            
            return PartialView();
        }



        public ActionResult Grid4()
        {
            var lay = testv.all2();
            var lay2 = testv.all3();

            ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
            //var res = Badjunto.all().Select(x=> new { x.Archivo, x.ID}).ToList();
            var res2 = lay.Single().layout.ToString();
            var res = Badjunto.all();

            ViewBag.res = res;
            ViewBag.res2 = res2;
            ViewBag.res3 = lay2.Single().head.ToString();

            //System.IO.File.WriteAllLines(@"C:\Users\Public\TestFolder\WriteLines.txt", lines);
            System.IO.File.WriteAllText(@"C:\Users\asoftware8\Documents\Visual Studio 2012\Projects\Bstrap2\Bstrap1\Views\Shared2\" + lay.Single().user.ToString() + ".cshtml", res2.ToString());

            return View(res);
        }

        //public ActionResult Grid4()
        //{
        //    var lay = testv.all2();

        //        ViewBag.Message = "Modify this template to jump-start your ASP.NET MVC application.";
        //        //var res = Badjunto.all().Select(x=> new { x.Archivo, x.ID}).ToList();
        //        var res2 = lay.Single().layout.ToString();
        //        var res = Badjunto.all();

        //        ViewBag.res = res;
        //        ViewBag.res2 = res2;

        //        //System.IO.File.WriteAllLines(@"C:\Users\Public\TestFolder\WriteLines.txt", lines);
        //        System.IO.File.WriteAllText(@"C:\Users\asoftware8\Documents\Visual Studio 2012\Projects\Bstrap2\Bstrap1\Views\Shared2\"+lay.Single().user.ToString()+".cshtml", res2.ToString());

        //        return View(res);
        //}
    }
}
