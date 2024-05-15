using TMN_Lesson04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TMN_Lesson04.Controllers
{
    public class TMNCustomerScaffDingController : Controller
    {

        private static List<TMNCustomer> listCustomer = new List<TMNCustomer>()
            {
                new TMNCustomer()
                {
                     CustomerID = 1,
                     FirstName = "Lê Hoàng",
                     LastName = "Long",
                     Address = "K22CNT3",
                     YearOfBirth = "2004"
                },
                new TMNCustomer()
                {
                     CustomerID = 2,
                     FirstName = "Ngô Hoàng",
                     LastName = "Minh",
                     Address = "K22CNT3",
                     YearOfBirth = "2004"
                },
                new  TMNCustomer()
                {
                     CustomerID = 2,
                     FirstName = "Lê Trần Khánh",
                     LastName = "Duy",
                     Address = "K22CNT3",
                     YearOfBirth = "2004"
                },
                new TMNCustomer()
                {
                     CustomerID = 2,
                     FirstName = "Trần Minh",
                     LastName = "Nam",
                     Address = "K22CNT3",
                     YearOfBirth = "2004"
                },
            };
        // GET: TMNCustomerScaffDing
        // listCustomer
        public ActionResult Index()
        {
            return View(listCustomer);
        }
        [HttpGet]
        public ActionResult TMNCreate()
        {
            var model = new TMNCustomer();
            return View(model);
        }
        [HttpPost]
        public ActionResult LHLCreate(TMNCustomer model)
        {
            listCustomer.Add(model);
            //return View();
            return RedirectToAction("Index");
        }
        public ActionResult LHLEdit(int id)
        {
            var customer = listCustomer.FirstOrDefault(x=>x.CustomerID==id);
            return View(customer);
        }
    }
}