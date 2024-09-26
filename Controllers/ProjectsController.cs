using DevFreela.Api.models;
using Microsoft.AspNetCore.Mvc;

namespace DevFreela.Api.Controllers

{
  [Route("api/projects")]
  public class ProjectsController: ControllerBase
  {

    [HttpGet]
    public IActionResult Get(string query)
    {
      return Ok();
    }

    //api/projects/1
    [HttpGet("{id}")]
    public IActionResult GetById(int id)
    {
      return Ok();
    }

    [HttpPost]
    public IActionResult Post([FromBody] CreateProjectModel createProject)
    {
      if(createProject.Title.Length > 50)
      {
        return BadRequest();
      }

      return CreatedAtAction(nameof(GetById), new {id = createProject.Id}, createProject);
    }

    [HttpPut("{id}")]
    public IActionResult Put(int id, [FromBody] UpdateProjectModel updateProjectModel)
    {
      if(updateProjectModel.Description.Length > 200)
      {
        return BadRequest();
      }

      return NoContent();
    }

    [HttpDelete("{id}")]
    public IActionResult Delete(int id)
    {
      return NoContent();
    }
  }
}
