using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Microsoft.VisualBasic;
using MVC1.Models;
namespace MVC1.Controllers
{
    public class MyController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }


        // action result is a return datatype
        public ActionResult welcome()
        {
            return View();
        }

        public string welc()
        {
            return "welcome to my controller";
        }

        public ActionResult GetName()
        {
            ViewData["name"] = "saritha";
            return View();
        }

        public ActionResult MyData()
        {
            ViewData["name"] = "Giri Babu M";
            ViewData["email"] = "GiriBabu.M@lntinfotech.com";
            ViewData["phone"] = 9390812962;
            ViewData["DOB"] = "5-6-2001";
            ViewData["date"] = DateAndTime.Now;
            return View();

        }

        public ActionResult studet()
        {
            Student s=new Student(){ id=1,firstname="Giri",lastname="Babu",marks=90};

            ViewData["studentData"] = s;

            return View();
        }

        public ActionResult MyViewBag()
        {

            List<Student> studentlist = new List<Student>()
            {
                new Student{id=1,firstname="giri",lastname="babu",marks=56},
                new Student{id=2,firstname="hari",lastname="prasad",marks=76},
                new Student{id=3,firstname="vamsi",lastname="gonne",marks=96},
                new Student{id=4,firstname="mouni",lastname="p",marks=90},
                new Student{id=5,firstname="cherry",lastname="kolandhi",marks=98}
            };
            ViewBag.Students = studentlist;
            return View();
        }

        public ActionResult MyBook()
        {
            List<Book> booklist = new List<Book>()
            {
                new Book{id=1,bookName="storybook",author="Vamsi",price=78.89},
                new Book{id=2,bookName="Fictionbook",author="Giri",price=789},
                new Book{id=3,bookName="lovestorybook",author="mouni",price=59.89},
                new Book{id=4,bookName="kidsbook",author="krithika",price=755.9},


                
            };
            ViewBag.books = booklist;

            return View();
        }

        public ActionResult myviewdata()
        {
            List<Book> booklist = new List<Book>()
            {
                new Book{id=1,bookName="storybook",author="Vamsi",price=78.89},
                new Book{id=2,bookName="Fictionbook",author="Giri",price=789},
                new Book{id=3,bookName="lovestorybook",author="mouni",price=59.89},
                new Book{id=4,bookName="kidsbook",author="krithika",price=755.9},



            };
            ViewData["books"] = booklist;
            return View();


        }
    }
}
