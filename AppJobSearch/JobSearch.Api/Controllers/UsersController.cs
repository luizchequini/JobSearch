using JobSearch.Api.Database;
using JobSearch.Domain.Models;
using Microsoft.AspNetCore.Mvc;
using System.Linq;

namespace JobSearch.Api.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UsersController : ControllerBase
    {
        private JobSearchContext _jobSearchContext;

        public UsersController(JobSearchContext jobSearchContext)
        {
            _jobSearchContext = jobSearchContext;
        }

        [HttpGet]
        public IActionResult GetUser(string email, string password)
        {
            var userDb = _jobSearchContext.Users.FirstOrDefault(u => u.Email.Equals(email) && u.Password.Equals(password));

            if (userDb == null)
            {
                return NotFound();
            }

            return new JsonResult(userDb);
        }

        [HttpPost]
        public IActionResult AddUser(User user)
        {
            _jobSearchContext.Add(user);
            _jobSearchContext.SaveChanges();

            return CreatedAtAction(nameof(GetUser), new { email = user.Email, password = user.Password }, user);
        }
    }
}
