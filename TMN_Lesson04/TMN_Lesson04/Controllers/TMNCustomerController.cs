using TMN_Lesson04.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace TMN_Lesson04.Controllers
{
    public class TMNCustomerController : Controller
    {
        // GET: LHLCustomer
        public ActionResult Index()
        {
            return View();
        }

        //Action: TMNCustomerDetails
        public ActionResult TMNCustomerDetails()
        {
            //tạo đối tượng trong dữ liệu 
            var customer = new TMNCustomer()
            {
                CustomerID = 1,
                FirstName = "Lê Hoàng",
                LastName = "Long",
                Address = "K22CNT3",
                YearOfBirth = "2004"
            };
            ViewBag.customer = customer;
            return View();
        }
        public ActionResult  TMNlistCustomer()
        {
            var list = new List<TMNCustomer>()
            {
                new TMNCustomer()
                {
                     CustomerID = 1,
                     FirstName = "Trần Minh",
                     LastName = "Nam",
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
                new TMNCustomer()
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
                     FirstName = "Trịnh Hữu",
                     LastName = "Phúc",
                     Address = "K22CNT3",
                     YearOfBirth = "2004"
                },
            };
            ViewBag.list = list;
            return View();
        }
    }
}