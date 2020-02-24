using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Description;
using REST_P2.Models;

namespace REST_P2.Controllers
{
    public class SaleItemsController : ApiController
    {
        private Database1Entities1 db = new Database1Entities1();

        // GET: api/SaleItems
        public IHttpActionResult Get()
        {
            var x = db.SaleItem.Include(item => item.Good).ToArray();

            return Ok(x);
        }

        public IHttpActionResult Put(SaleItem sale)
        {
            var newsale = db.SaleItem.Add(sale);
            db.SaveChanges();
            return Ok(newsale);
        }
    }
}