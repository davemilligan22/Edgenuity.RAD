using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Edgenuity.RAD.Domain.Models;
using Edgenuity.RAD.Domain.Logic;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Edgenuity.RAD.WebAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ClassController : ControllerBase
    {
        private readonly ClassService _classService = null; // TODO: Make an interface

        public ClassController()
        {
            _classService = new ClassService(); // TODO: Inject instance 
        }

        // GET: api/<ClassController>
        [HttpGet("[action]/{ownerId}")]
        public IEnumerable<Class> GetClasses(int ownerId)
        {
            var classes = _classService.GetClasses(ownerId);
            return classes;
        }

        // GET api/<ClassController>/5
        [HttpGet("[action]/{id}")]
        public Class GetClass(int id)
        {
            var cls = _classService.GetClass(id);
            return cls;
        }
    }
}
