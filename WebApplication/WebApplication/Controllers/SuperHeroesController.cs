using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using WebApplication.DataAccess;
using WebApplication.Models;

namespace WebApplication.Controllers
{
    [Route("superheroes")]
    [ApiController]
    public class SuperHeroesController : ControllerBase
    {
        // GET api/values
        [HttpGet("get-all")]
        public ActionResult<IEnumerable<Superhero>> GetAll()
        {
            return Repository.Instance.GetAll();
        }

        // GET api/values/5
        [HttpGet("get/{id}")]
        public object Get(int id)
        {
            var model = Repository.Instance.Get(id);
            if (model != null)
            {
                return model;
            }
            else
            {
                return NotFound();
            }
        }

        // POST api/values
        [HttpPost]
        public object Post([FromBody] Superhero model)
        {
            if (model == null)
            {
                return BadRequest();
            }

            if (model.Id == 0)
            {
                return new StatusCodeResult(StatusCodes.Status422UnprocessableEntity);
            }
            var result = Repository.Instance.InsertSuperHero(model);

            return model.Id;
        }

        // PUT api/values/5
        [HttpPut("put{id}")]
        public object Put(int id, [FromBody] Superhero model)
        {
            if (model == null)
            {
                return BadRequest("null model");
            }
            if (model.Id == 0)
            {
                return new StatusCodeResult(StatusCodes.Status422UnprocessableEntity);
            }
            var updated = Repository.Instance.UpdateSuperhero(model);

            if (updated)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
        }

        // DELETE api/values/5
        [HttpDelete("delete/{id}")]
        public object Delete(int id)
        {
            var deleted = Repository.Instance.Remove(id);

            if (deleted)
            {
                return Ok();
            }
            else
            {
                return NotFound();
            }
            //var result = _models.RemoveAll(x => x.Id == id);
        }
    }
}
