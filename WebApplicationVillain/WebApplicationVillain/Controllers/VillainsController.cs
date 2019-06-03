using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationVillain.DataAccess;
using WebApplicationVillain.Infrastructures;
using WebApplicationVillain.Models;

namespace WebApplicationVillain.Controllers
{
    [Route("villains")]
    [ApiController]
    public class VillainsController : ControllerBase
    {
        // GET api/values
        [HttpGet("get-all")]
        public ActionResult<IEnumerable<Villain>> GetAll()
        {
            return Repository.Instance.GetAllVillains();
        }

        // GET api/values/5
        [HttpGet("get/{id}")]
        public Villain Get(int id)
        {
            return Repository.Instance.GetVillain(id);
        }

        // POST api/values
        [HttpPost("post")]
        public int Post([FromBody] Villain model)
        {
            CheckInput();
            var newId = Repository.Instance.InsertVillain(model);
            return newId;
        }

        // PUT api/values/5
        [HttpPut("put/{id}")]
        public void Put(int id, [FromBody] Villain model)
        {
            CheckInput();
            Repository.Instance.UpdateSuperhero(id, model);
        }

        // DELETE api/values/5
        [HttpDelete("delete/{id}")]
        public void Delete(int id)
        {
            Repository.Instance.RemoveVillain(id);
        }

        
    }
}
