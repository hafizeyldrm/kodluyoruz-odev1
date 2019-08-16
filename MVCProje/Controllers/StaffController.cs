using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using MVCProje.Models;

namespace MVCProje.Controllers
{
    public class StaffController : Controller
    {
        public static List<Staff> StaffList;
        public IActionResult Index()
        {
            List<Staff> staffList = Staff.GetSampleData();
            if(StaffList!=null && StaffList.Any())
            {
                staffList.AddRange(StaffList);
            }
            return View(staffList);
        }
        public IActionResult Detail(int id)
        {
            List<Staff> staffList = Staff.GetSampleData();
            if(StaffList!=null && StaffList.Any())
            {
                staffList.AddRange(StaffList);
            }
            Staff staff = staffList.Where(x => x.Id == id).FirstOrDefault();
            return View(staff);

        }
        public IActionResult Create()
        {
            return View();
        }
        [HttpPost]
        public IActionResult Create(Staff model)
        {
            if (ModelState.IsValid)
            {
                if (StaffList == null)
                {
                    StaffList = new List<Staff>();
                }
                StaffList.Add(model);
                return RedirectToAction("Detail", new { id = model.Id });
               
            }
            return View(model);
        }
    }
}
