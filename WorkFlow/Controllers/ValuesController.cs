using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web;
using System.Web.Http;

namespace WorkFlow.Controllers
{
    public class ValuesController : ApiController
    {
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        // GET api/values/5
        public string Get(string id)
        {
            string folder = HttpRuntime.AppDomainAppPath;
            string fileName = folder + "App_Data\\" + "bpmj" + ".json";
            if (!File.Exists(fileName)) return string.Empty;
            string result = File.ReadAllText(fileName);
            return result;
        }

        // POST api/values
        [HttpPost]
        public void Post([FromBody]dynamic value)
        {
            if (value == null) return;
            string result = value.ToString();
            
            //save file
            string folder = HttpRuntime.AppDomainAppPath;
            string fileName = folder +"App_Data\\" + "bpmj.json";
            File.WriteAllText(fileName,result,Encoding.UTF8);
        }

        // PUT api/values/5
        public void Put(int id, [FromBody]string value)
        {

        }

        // DELETE api/values/5
        public void Delete(int id)
        {

        }
    }
}
