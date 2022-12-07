using BLL.DTOs;
using BLL.Services;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace BirthCitificateManagement.Controllers
{
    public class HospitalController : ApiController
    {
        [Route("api/Hospital")]
        [HttpGet]

        public HttpResponseMessage Get()
        {
            var data = HospitalService.Get();
            return Request.CreateResponse(HttpStatusCode.OK, data);
        }
        [Route("api/Hospital/id")]
        public HttpResponseMessage Get(int id)
        {
            var data = HospitalService.Get(id); 
            return Request.CreateResponse(HttpStatusCode.OK, data); 
        }

        [Route("api/Hospitals/add")]
        [HttpPost]
        public HttpResponseMessage Add(HospitalDTO hospital)
        {
            var data = HospitalService.Add(hospital);
            if(data != null) {
                return Request.CreateResponse(HttpStatusCode.OK, data);
            }
            return Request.CreateResponse(HttpStatusCode.InternalServerError);
           
        }
    }

}
