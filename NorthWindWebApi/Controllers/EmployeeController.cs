using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using NorthWindWebApi.Models; 

namespace NorthWindWebApi.Controllers
{
    public class EmployeeController : BaseAPIController
    {
        private NorthwindDBEntities db = new NorthwindDBEntities();

        [HttpGet]
        public IQueryable<Employee> GetEmployees()
        {
            var emps = db.Employees;
            return emps;
        }

        [HttpGet]
        [ResponseType(typeof(Employee))]
        public IQueryable<Employee> GetEmployee(int? employeeid)
        {

            var employee = db.Employees.Where(c => c.EmployeeID == employeeid);
         
            //if (employee == null)
            //{
            //    hr = new HttpResponseMessage(HttpStatusCode.NotFound);
            //    return hr;
            //}

            return employee;
        }

    }
}
