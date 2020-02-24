using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace REST_P2.Controllers
{
    public class GoodController : ApiController
    {
        public IHttpActionResult Get()
        {
            try
            {
                return Ok();
            }
            catch (Exception error)
            {
                return InternalServerError(error);
            }
        }
    }
}
