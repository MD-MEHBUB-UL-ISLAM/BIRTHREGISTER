using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using BLL;
using BLL.DTOs;
using BLL.Services;

namespace BirthCitificateManagement.Controllers
{
    public class ChildController : ApiController
    {
        [Route("api/children")]
        [HttpGet]
        public HttpResponseMessage Get()
        {
            var data = ChildService.Get(default); 
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/children/{id}")]

        public HttpResponseMessage Get(int id)
        {
            var data = ChildService.Get(id);
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }

        [Route("api/children//add")]
        [HttpPost]

        public HttpResponseMessage Post(ChildinfoDTO group)
        {
            var resp = ChildService.Add(group);
            if(resp ) 
                {
                return Request.CreateResponse(HttpStatusCode.OK, new { Msg = "Inserted", data= group });
                } 
            else 
                return Request.CreateResponse(HttpStatusCode.InternalServerError);

        }
            

    }
}
