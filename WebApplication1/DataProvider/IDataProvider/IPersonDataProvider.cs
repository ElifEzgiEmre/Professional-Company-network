using Proje1.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Proje1.DataProvider.IDataProvider
{
    public interface IPersonDataProvider
    {
        List<Person> GetList();

        List<Person> GetSearchResult(string searchDepartment, string searchName ,string searchLocation);

        Person Get(int id);

        List<Education> EduList(int id);

        List<Experience> ExpList(int id);


    }
}
