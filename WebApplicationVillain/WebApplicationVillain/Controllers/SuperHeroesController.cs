using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using WebApplicationVillain.DataAccess;
using WebApplicationVillain.Models;

namespace WebApplicationVillain.Controllers
{

    [Route("superheroes")]
    [ApiController]
    public class SuperheroesController : Controller
    {
        [HttpGet("get-all")]
        public ActionResult<IEnumerable<Superhero>> GetAll()
        {
            return Repository.Instance.GetAllSuperheroes();
        }

        [HttpGet("get/{id}")]
        public Superhero Get(int id)
        {
            return Repository.Instance.GetSuperhero(id);
        }

        [HttpPost("post")]
        public int Post([FromBody]Superhero model)
        {
            CheckInput();
            var newId = Repository.Instance.InsertSuperhero(model);
            return newId;
        }

        [HttpPut("put/{id}")]
        public void Put(int id, [FromBody]Superhero model)
        {
            CheckInput();
            Repository.Instance.UpdateSuperhero(id, model);
        }

        [HttpDelete("delete/{id}")]
        public void Delete(int id)
        {
            Repository.Instance.RemoveSuperhero(id);
        }

        
    }

}
