using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace Cumulative3.Controllers
{
    public class teacherdataController : Controller
    {
        private List<string> teachers = new List<string>();

        // GET 
        public IEnumerable<string> Get()
        {
            return teachers;
        }

        // GET 
        public string Get(int id)
        {
            return teachers[id];
        }

        // POST 
        public void Post(string value)
        {
            teachers.Add(value);
        }

        // PUT 
        public void Put(int id, string value)
        {
            teachers[id] = value;
        }

        // DELETE 
        public void Delete(int id)
        {
            teachers.RemoveAt(id);
        }

        internal IEnumerable<Teacher> Listteachers()
        {
            throw new NotImplementedException();
        }

        internal Teacher FindTeacher(int id)
        {
            throw new NotImplementedException();
        }
    }
}