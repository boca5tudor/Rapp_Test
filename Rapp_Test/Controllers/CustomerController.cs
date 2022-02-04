using Microsoft.AspNetCore.Mvc;
using Rapp_Test.Data;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Rapp_Test.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomerController : Controller
    {
        private readonly IDataRepository _repository;

        //public IActionResult Index()
        //{
        //    return View();
        //}

        public CustomerController(IDataRepository repository)
        {
            _repository = repository;
        }

        [HttpGet]
        public ActionResult<IEnumerable<Customer>> Get()
        {
            try
            {
                var result = _repository.GetAllCustomers();

                return Ok(result);
            }
            catch (Exception ex)
            {
                return BadRequest("Failed to get all customers");
            }
        }

        [HttpPost]
        public IActionResult Post([FromBody] Customer model)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _repository.AddEntity(model);

                   return Created($"/customer/{model.Id}", model);
                }
                else
                {
                    return BadRequest($"Failed to create new customer:{model.Id} ");
                }
            }
            catch (Exception ex)
            {
                return BadRequest($"Failed to create new customer");
            }
        }
    }
}
