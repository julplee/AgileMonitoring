using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace AgileMonitoring.WebApi.Controllers
{
    public class TimeController : ApiController
    {
        // GET api/default2
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/default2/5
        public string Get(int id)
        {
            string msg;
            switch (id)
            {
                case 1:
                    msg = "Format 1 " + DateTime.Now.ToString("hh:mm:ss");
                    break;
                case 2:
                    msg = "Format 2 " + DateTime.Now.ToString("HH:MM:SS");
                    break;
                default:
                    msg = "Default " + DateTime.Now;
                    break;
            }
            return msg;
        }

        // POST api/default2
        public void Post([FromBody]string value)
        {
        }

        // PUT api/default2/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE api/default2/5
        public void Delete(int id)
        {
        }
    }
}
