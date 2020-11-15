using Api.Model;
using Api.Services.Interface;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Linq;
using Microsoft.AspNetCore.Cors;

namespace Api.Controllers
{
    [ApiConventionType(typeof(DefaultApiConventions))]
    [Produces("application/json")]
    [ApiController]
    [Route("api/[Controller]")]
    [EnableCors("PermitirApiRequest")]
    public class AssignmentContoller : ControllerBase
    {
        private readonly IService _services; 
        public AssignmentContoller(IService services)
        {
            _services = services;
        }
        [HttpGet]
        public ActionResult<List<Assignment>> GetAssignment()
        {
            return _services.AssignmentRepository.GetAssignment().ToList();
        }
        [HttpGet("{id}", Name = "ObterProduto")]
        public ActionResult<Assignment> GetAssignmentId(int id)
        {
            var assignment = _services.AssignmentRepository.GetById(a => a.AssignmentId == id);

            if (assignment == null)
            {
                return NotFound();
            }
            return assignment;
        }
        [HttpPost]
        public ActionResult PostAssignment([FromBody] Assignment assignment)
        {
            _services.AssignmentRepository.Add(assignment);
            _services.Commit();

            return new CreatedAtRouteResult("ObterCategoria",
              new { id = assignment.CategoryId }, assignment);
        }
        [HttpPut("{id}")]
        public ActionResult PutAssignment(int id, [FromBody] Assignment assignment)
        {
            if (id != assignment.AssignmentId)
            {
                return BadRequest();
            }

            _services.AssignmentRepository.Update(assignment);
            _services.Commit();

            return Ok();
        }
        [HttpDelete("{id}")]
        public ActionResult<Assignment> Delete(int id)
        {
            var assignment = _services.AssignmentRepository.GetById(a => a.AssignmentId == id);

            if (assignment == null)
            {
                return NotFound();
            }
            _services.AssignmentRepository.Delete(assignment);
            _services.Commit();
            return assignment;
        }

    }
}
