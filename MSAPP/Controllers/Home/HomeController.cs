using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using MSAPP.Models;

using System.ComponentModel.DataAnnotations;
using Microsoft.AspNetCore.Authorization;

namespace TestApp.Controllers.Home
{
    [AllowAnonymous]
    public class HomeController : Controller
    {


            private IEmployeeRepository _IEmployeeRepository;

            public HomeController(IEmployeeRepository employeeRepository)
            {
                _IEmployeeRepository = employeeRepository;
            }

        public ViewResult Index()
            {
                var model = _IEmployeeRepository.GetAllEmployees();
                return View(model);
            }



            public IActionResult Insert()
            {
                return View();
            }

            [HttpPost]
            public IActionResult Insert(Employee emp)
            {

            if (ModelState.IsValid)
            {
                _IEmployeeRepository.Add(emp);
                return RedirectToAction("Index");
            }
           
            return View(emp);
          
        }

            public IActionResult Update(int id)
            {
                Employee emp = _IEmployeeRepository.GetEmployee(id);

                return View(emp);
            }

            [HttpPost]
        public IActionResult Update(Employee em)
        {
            
            //_IEmployeeRepository.Update(em);

            return RedirectToAction("Index");
        }

        public IActionResult Delete(int id)
        {
                Employee emp = _IEmployeeRepository.GetEmployee(id);

                return View(emp);
         }
        

            [HttpPost]
            public IActionResult ConfirmDelete(int id)
            {

                _IEmployeeRepository.Delete(id);

                return RedirectToAction("Index");

            }

     
    }
}
