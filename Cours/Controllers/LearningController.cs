using Cours.Entity;
using Course.Services;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace Course.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LearningController : ControllerBase
    {
        private readonly ILearning services;

        public LearningController(ILearning services)
        {
            this.services = services;
        }
        [HttpGet]
        public async Task<IActionResult> Gets()
        {
            var json = await services.Gets();
            return Ok(json);
        }
        [HttpGet("/id")]
        public async Task<IActionResult> Get(Guid id)
        {
            var json = await services.Get(id);
            return Ok(json);
        }
        [HttpPost]
        public async Task<IActionResult> Create(Learning newLearning)
        {
            var json = await services.CreateCourse(newLearning);
            return Ok(json);
        }
        [HttpPut]
        public async Task<IActionResult> Update(Learning learning)
        {
            var json = await services.UpdateCourse(learning);
            return Ok(json);
        }
        [HttpDelete]
        public IActionResult Delete(Guid id)
        {
            services.DeleteCourse(id);
            return Ok();
        }
    }
}
