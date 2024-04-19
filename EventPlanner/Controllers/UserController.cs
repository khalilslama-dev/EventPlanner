using EventPlanner.Models;
using EventPlanner.Services.interfaces;
using Microsoft.AspNetCore.Identity;
using Microsoft.AspNetCore.Mvc;
using System.Net;

// For more information on enabling Web API for empty projects, visit https://go.microsoft.com/fwlink/?LinkID=397860

namespace EventPlanner.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class UserController : ControllerBase
    {
        private readonly IUserService _userService;

        public UserController(IUserService userService)
        {
            _userService = userService;
        }


        //GET: api/<UserController>
        [HttpGet]
        public ActionResult<IEnumerable<User>> Get()
        {
            return Ok(_userService.getAllWithEvents());
        }

        // get api/<usercontroller>/5
        [HttpGet("{id}")]
        public ActionResult<User> Get(long id)
        {
            User user = _userService.GetId(id);
            if (user == null)
            {
                return NotFound();
            }
            return Ok(user);
        }

        // post api/<usercontroller>
        [HttpPost]
        public ActionResult Post([FromBody] User user)
        {
            _userService.Add(user);
            return CreatedAtAction("post", user);
        }

        // put api/<usercontroller>/5
        [HttpPut("{id}")]
        public ActionResult Put(long id, [FromBody] User user)
        {
            User? olduser = _userService.GetId(id);
            if (olduser == null)
            {
                return NotFound();
            }
            olduser.PhoneNumber = user.PhoneNumber;
            olduser.FirstName = user.FirstName;
            olduser.LastName = user.LastName;
            olduser.Email = user.Email;
            _userService.Update(olduser);
            return Ok(olduser);
        }

        // delete api/<usercontroller>/5
        [HttpDelete("{id}")]
        public ActionResult Delete(int id)
        {
            User? olduser = _userService.GetId(id);
            if (olduser == null)
            {
                return NotFound();
            }
            _userService.Remove(olduser);
            return Ok();
        }
    }
}
