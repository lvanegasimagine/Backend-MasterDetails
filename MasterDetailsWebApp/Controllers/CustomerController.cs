using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Cors;
using System.Web.Http.Description;
using MasterDetailsWebApp.Models;

namespace MasterDetailsWebApp.Controllers
{
    public class CustomerController : ApiController
    {
        private DBModel db = new DBModel();
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        // GET: api/Customer
        public IQueryable<Customer> GetCustomers()
        {
            return db.Customers;
        }

        protected override void Dispose(bool disposing)
        {
            if (disposing)
            {
                db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}