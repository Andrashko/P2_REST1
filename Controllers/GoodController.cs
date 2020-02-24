using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using REST_P2.Models;


namespace REST_P2.Controllers
{   
  
    public class GoodController : ApiController
    {
        private Database1Entities1 db = new Database1Entities1();
        public IHttpActionResult Get()
        {
            try
            {
                return Ok(db.Good.ToArray());
            }
            catch (Exception error)
            {
                return InternalServerError(error);
            }
        }
        public IHttpActionResult Get(int Id)
        {
            try
            {
                var good = db.Good.Find(Id);
                if (good == null)
                    return NotFound();
                return Ok(good);
            }
            catch (Exception error)
            {
                return InternalServerError(error);
            }
        }

        public IHttpActionResult Post([FromBody] Good good)
        {
            try
            {
                var newGood = db.Good.Add(good);
                db.SaveChanges();
                return Ok(newGood);
            }
            catch (Exception error)
            {
                return InternalServerError(error);
            }
        }
    }
}
