using Microsoft.AspNetCore.Mvc;
using Rentocam.Domain;
using Rentocam.Infra.Repositories;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace Rentocam.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CameraController : ControllerBase
    {
        private readonly IRepository<CameraDetails> cameraDetailsRepository;

        public CameraController(IRepository<CameraDetails> cameraDetailsRepository)
        {
            this.cameraDetailsRepository = cameraDetailsRepository;
        }
        // GET: api/<CameraController>
        [HttpGet]
        public IEnumerable<CameraDetails> Get()
        {
            return cameraDetailsRepository.GetAll();
        }

        // GET api/<CameraController>/5
        [HttpGet("{id}")]
        public CameraDetails Get(Guid id)
        {
            return cameraDetailsRepository.Get(id);
        }

        // POST api/<CameraController>
        [HttpPost]
        public void Post([FromBody] string value)
        {
        }

        // PUT api/<CameraController>/5
        [HttpPut("{id}")]
        public void Put(int id, [FromBody] string value)
        {
        }

        // DELETE api/<CameraController>/5
        [HttpDelete("{id}")]
        public void Delete(int id)
        {
        }
    }
}
