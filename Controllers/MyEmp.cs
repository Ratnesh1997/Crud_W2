using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplication2.Models;
using Microsoft.EntityFrameworkCore;
namespace WebApplication2.Controllers
{
    public class MyEmp : Controller
    {
        private readonly EmplContext _myDependency;

        public MyEmp(EmplContext myDependency)
        {
            _myDependency = myDependency;
        }
        public IActionResult Index()
        {
            var data = _myDependency.Empls.ToList();
            return View(data);

        }
        public IActionResult Create()
        {

            return View();

        }

        [HttpPost]
        public IActionResult Create(Empl M)
        {
            _myDependency.Empls.Add(M);
            _myDependency.SaveChanges();
            return RedirectToAction("Index");


        }
        public IActionResult Delete( int Id)
        {

            if (Id == 0)
            {
                return NotFound();
            }
            var data = _myDependency.Empls.SingleOrDefault(x => x.id == Id);
            _myDependency.Empls.Remove(data);
            _myDependency.SaveChanges();
            return RedirectToAction("Index");

        }

        public IActionResult Update(int Id)
        {
             if (Id == 0)
            {
                return NotFound();
            }
            var data = _myDependency.Empls.SingleOrDefault(x => x.id == Id);
            return View(data);


        }

        public IActionResult UpdateD(Empl M)
        {
            if (M == null)
            {
                return NotFound();
            }

            _myDependency.Empls.Update(M);
            _myDependency.SaveChanges();
            return RedirectToAction("Index");


        }



    }

}