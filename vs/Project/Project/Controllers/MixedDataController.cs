using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Project.Models;
using System.Web.Http.Cors;

namespace Project.Controllers
{
    [EnableCors(origins: "*", headers: "*", methods: "*")]

    public class MixedDataController : ApiController
    {
        MixedDataBL mixedDataBL = new MixedDataBL();
        // GET: api/MixedData
        public IEnumerable<MixedData> Get()
        {
            return mixedDataBL.GetMixedDatas();
        }

        // GET: api/MixedData/5
        public string Get(int id)
        {
            return "Nothing";
        }

        // POST: api/MixedData
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/MixedData/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/MixedData/5
        public void Delete(int id)
        {
        }
    }
}
