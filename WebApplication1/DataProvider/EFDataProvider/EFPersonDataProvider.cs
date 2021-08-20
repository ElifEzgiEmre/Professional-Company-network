using Microsoft.EntityFrameworkCore;
using Proje1.Context;
using Proje1.DataProvider.IDataProvider;
using Proje1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Proje1.DataProvider.EFDataProvider
{
    public class EFPersonDataProvider : IPersonDataProvider
    {
        public List<Person> GetList()
        {
            using (var mcontext = new MyContext())
            {
                var result = mcontext.Persons.ToList();
                return result;
            }
        }
        //public List<Education> EduList()
        //{
        //    using (var mcontext = new MyContext())
        //    {
        //        var result = mcontext.Education.ToList();
        //        return result;
        //    }
        //}
        public List<Education> EduList(int id)
        {
            using (var mcontext = new MyContext())
            {
                var _educations = mcontext.Education.AsQueryable();

                var result = _educations.Where(i => i.PersonId == id).ToList();


                return result;
            }
        }

        public List<Experience> ExpList(int id)
        {
            using (var mcontext = new MyContext())
            {
                var _experience = mcontext.Experiences.AsQueryable();

                var result = _experience.Where(i => i.PersonId == id).ToList();


                return result;
            }
        }

        public List<Person> GetSearchResult(string searchDepartment, string searchName, string searchLocation)
        {
            using (var mcontext = new MyContext())
            {


                    return mcontext.Persons.Where(x => (x.Department.Contains(searchDepartment) && x.Address.Contains(searchLocation) && x.Name.Contains(searchName))  && (x.Department.Contains(searchDepartment) || x.Address.Contains(searchLocation) || x.Name.Contains(searchName)) || (searchName == null && searchLocation == null && searchDepartment == null)).ToList();
                
            
                  
            }
        }
      

        public Person Get(int id)
        {
            using (var mcontext = new MyContext())
            {
                var result = mcontext.Persons.Find(id);
                return result;
            }
        }

        
    }
}
