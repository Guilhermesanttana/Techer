using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using System.Web.Http.Controllers;
using System.Web.Http.Filters;

namespace WebAPI.Controllers
{
    public class ValuesController : ApiController
    {
        [HttpGet]
        [Log]
        // GET api/values
        public IEnumerable<string> Get()
        {
            return new string[] { "value1", "value2" };
        }

        [HttpGet]
        [Log]
        // GET api/values/5
        public string SecondMethod(int id)
        {
            return "value";
        }

        // POST api/values
        public string Post([FromBody]string value)
        {
            return "Success";
        }

        // PUT api/values/5
        public string Put(int id, [FromBody]string value)
        { 
            return "Done";
        }

        // DELETE api/values/5
        public string Delete(int id)
        {
            return "Deleted";
        }
    }

    public class LogAttribute : ActionFilterAttribute
    {
        public LogAttribute()
        {
        }

        public override void OnActionExecuting(HttpActionContext actionContext)
        {
            Trace.WriteLine("Action method executing: " + actionContext.ActionDescriptor.ActionName);
        }

        public override void OnActionExecuted(HttpActionExecutedContext actionExecutedContext)
        {
            Trace.WriteLine("Action method executed: " + actionExecutedContext.ActionContext.ActionDescriptor.ActionName);
        }

    }
}
