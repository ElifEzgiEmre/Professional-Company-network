using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Proje1.DataProvider.IDataProvider;
using Proje1.Models;
using X.PagedList;

namespace Proje1.Controllers
{
    public class PersonController : Controller
    {
        IPersonDataProvider _personDataProvider;


        public PersonController(IPersonDataProvider personDataProvider)
        {
            _personDataProvider = personDataProvider;
        }
   
        public IActionResult List(string searchDepartment, string searchName, string searchLocation,int page=1)
        {
            var result = _personDataProvider.GetSearchResult(searchDepartment, searchName, searchLocation).ToPagedList(page,4);
         
            return View(result);
        }

        public IActionResult GetPerson(int id)
        {
            var result = _personDataProvider.Get(id);
            var _edu = _personDataProvider.EduList(id);
            var _exp = _personDataProvider.ExpList(id);

            Person p = new Person()
            {
                PersonId = result.PersonId,
                Name = result.Name,
                Department = result.Department,
                Address = result.Address,
                ImageUrl=result.ImageUrl,
                Email =result.Email,
                Phone=result.Phone,
                Website=result.Website,
                Twitter=result.Twitter,

            };

            ViewBag.educations = _edu;
            ViewBag.experiences = _exp;

            return View(p);
        }

    }
}