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
    public class ItemController : ApiController
    {

        private DBModel db = new DBModel();
        [EnableCors(origins: "*", headers: "*", methods: "*")]
        // GET: api/Item
        public IQueryable<Item> GetItems()
        {
            return db.Items;
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