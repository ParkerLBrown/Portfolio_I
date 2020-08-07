using Microsoft.AspNetCore.Mvc;
namespace Portfolio_I
{
  public class FirstController : Controller
  {
    [HttpGet("")]
    public string Index()
    {
      return "This is my Index";
    }

    [HttpGet("projects")]
    public string MyProjects()
    {
      return "These are my projects";
    }

    [HttpGet("contact")]
    public string MyContact()
    {
      return "This is my Contact!";
    }
  }
}