using API_CRUD_April_101224.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Web;
using System.Web.Http.Results;
using System.Web.Mvc;

namespace API_CRUD_April_101224.Controllers
{
    public class StudentMVCController : Controller
    {
        // GET: StudentMVC
        public ActionResult Index()
        {
            HttpClient client = new HttpClient();

            client.BaseAddress = new Uri("https://localhost:44333/API/studentapi");

            var response = client.GetAsync("studentapi");
            response.Wait();
            var test=response.Result;
            if (test.IsSuccessStatusCode)
            {
                var display = test.Content.ReadAsAsync<List<tblStudent>>();
                display.Wait();
                var temp=display.Result;
                return View(temp);
            }

            return View();
        }
    }
}