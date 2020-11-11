using Api.Model;
using Api.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;

namespace Api.Controllers
{
    [ApiController]
    [Route("api/[Controller]")]
    public class CategoryController : ControllerBase
    {
        private readonly IService _services;
        public CategoryController(IService services)
        {
            _services = services;
        }
        [HttpGet]
        public ActionResult<List<Category>> GetCategory()
        {
            return _services.CategoryRepository.GetCategory().ToList();
        }
        [HttpGet("{id}", Name = "ObterCategoria")]
        public ActionResult<Category> GetCategoryId(int id)
        {
            var category = _services.CategoryRepository.GetById(p => p.CategoryId == id);

            if (category == null)
            {
                return NotFound();
            }
            return category;
        }
        [HttpPost]
        public ActionResult PostCategory([FromBody] Category category)
        {
            _services.CategoryRepository.Add(category);
            _services.Commit();

            return new CreatedAtRouteResult("ObterCategoria",
              new { id = category.CategoryId }, category);
        }
        [HttpPut("{id}")]
        public ActionResult PutCategory(int id, [FromBody] Category category)
        {
            if (id != category.CategoryId)
            {
                return BadRequest();
            }

            _services.CategoryRepository.Update(category);
            _services.Commit();
            return Ok();
        }
        [HttpDelete("{id}")]
        public ActionResult<Category> Delete(int id)
        {
            var category = _services.CategoryRepository.GetById(p => p.CategoryId == id);

            if (category == null)
            {
                return StatusCode(200, "Id not exists!");
            }
            _services.CategoryRepository.Delete(category);
            _services.Commit();
            return category;
        }
    }
}
