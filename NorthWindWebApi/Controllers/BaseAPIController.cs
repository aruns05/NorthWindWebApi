using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Net;
using System.Net.Http;
using System.Web.Http;

using System.Text;
using Newtonsoft.Json;
using NorthWindWebApi.Models;

namespace NorthWindWebApi.Controllers
{
    public class BaseAPIController:ApiController
    {
        protected readonly NorthwindDBEntities db = new NorthwindDBEntities();

        protected HttpResponseMessage ToJson(dynamic obj)
        {
            var response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent(JsonConvert.SerializeObject(obj), Encoding.UTF8, "application/json");
            return response;
        }
    }
}