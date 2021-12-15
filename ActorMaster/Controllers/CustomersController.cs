using ActorMaster.Data;
using ActorMaster.Data.Entities;
using Microsoft.AspNetCore.Mvc;

namespace ActorMaster.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class CustomersController : ControllerBase
    {
        private readonly ILogger<CustomersController> logger;
        public CustomersController(ILogger<CustomersController> logger )
        {
            this.logger = logger;
        }
        [HttpGet(Name = "GetAll")]
        public IEnumerable<CustomerDto> Get()
        {
            List<CustomerDto> dtos=new List<CustomerDto>();
            using (var context = new ActorMasterContext())
            {
                foreach (var actor in context.Actors.ToList())
                {
                    CustomerDto customer = new CustomerDto();
                    customer.ActorId = actor.Id;
                    customer.Name = actor.Name;
                    customer.CustomerNo = actor.CustomerNo;
                    dtos.Add(customer);
                }
            }
            return dtos;
        }

       
    }
}