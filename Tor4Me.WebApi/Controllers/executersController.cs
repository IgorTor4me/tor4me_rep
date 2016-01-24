using Microsoft.AspNet.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;
using Tor4Me.Data;
using Tor4Me.services;
using Tor4Me.services.Services;


namespace Tor4Me.WebApi.Controllers
{
    [Authorize]
    [RoutePrefix("api/executers")]
    public class executersController : ApiController
    {
        private IExecuterService executerService = new ExecuterService();

        [Route("")]
        
        public IEnumerable<executers> Get()
        {
            return executerService.GetExecuters();
        }

      
        [Route("business/{busid}")]
        public IEnumerable<executers> GetByBusId(int busid)
        {
            return executerService.GetExecutersByBusId(busid);
        }



        public IHttpActionResult GetById(int id)
        {
            var executers = executerService.GetExecuter(id);
            if (executers == null)
                return NotFound();
            return Ok(executers);
        }

         [Route("post")]
        public IHttpActionResult Post(executers executer)   //Insert new executer
        {
            bool isSave = executerService.SaveExecuter(executer);
            if (isSave == true)
                return Ok();
            return BadRequest();
        }

         [Route("put")]
        public IHttpActionResult Put(executers executer)
        {
            bool isUpdated = executerService.UpdateExecuter(executer.exeid, executer);
            if (isUpdated == true)
                return Ok();
            return BadRequest();
        }

        public IHttpActionResult Delete(int id)
        {
            bool isDeleted = executerService.DeleteExecuter(id);
            if (isDeleted == true)
                return Ok();
            return BadRequest();
        }




    }


}
