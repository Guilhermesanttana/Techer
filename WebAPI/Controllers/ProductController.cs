using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class ProductController : ApiController
    {

        // Parameter Binding
        // Get - single primitive parameter, multiple primitive parameters
        // Post - multiple primitive parameters, complex parameter, mixed parameters (primitive & complex parameters)
        // [FromUri]
        // [FromBody]

        // Action Return Type
        // Void
        // Primitive and complex types
        // HttpResponseMessage
        // IHttpActionResult

        // Request response data formats (Postman)
        // Headers - Content type and accept (Postman)


        [Route("api/product")]
        public List<string> GetFormatters()
        {
            IList<string> formatters = new List<string>();

            foreach (var formatter in GlobalConfiguration.Configuration.Formatters)
            {
                formatters.Add(formatter.ToString());
            }

            return formatters.ToList();
        }


        [Route("api/product")]
        public string Get(int productId, string productName, bool isAvailable)
        {
            return "laptop";
        }

        [Route("api/product")]
        public string Post(int productId, string productName, bool isAvailable)
        {
            //logic here
            
            return $"Success, ID:{productId} Name:{productName} Is Available:{isAvailable}";
        }


        [Route("api/product")]
        public IHttpActionResult Post(int empAge, Employee emp)
        {
            //logic here
            //return "Success!";

            //return Request.CreateResponse(HttpStatusCode.Created, emp);

            return Ok(emp);
        }

        // Get - Primitive and complex parameters will be extracted query string of the incoming request
        // Post - Primitive parameter from query string, complex from body
        // Put - Primitive paramter from query string, complex from body
        // Delete - Primitive and complex parameters will be extracted query string fo the incoming request

    }

    public class Employee
    {
        public int EmpId { get; set; }
        public string EmpName { get; set; }

    }
}
