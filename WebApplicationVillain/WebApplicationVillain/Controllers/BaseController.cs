using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WebApplicationVillain.Infrastructures;

namespace WebApplicationVillain.Controllers
{
    public class BaseController : Controller
    {
        
        protected void CheckInput()
        {
            if (!ModelState.IsValid)
            {
                var errors = ModelState
                    .SelectMany(x => x.Value
                        .Errors
                        .Select(y => y.ErrorMessage));

                var errorMessage = string.Join("; ", errors);

                throw new InvalidInputException(errorMessage);
            }
        }
    }
}
