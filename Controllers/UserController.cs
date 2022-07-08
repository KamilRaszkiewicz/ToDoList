using Microsoft.AspNetCore.Mvc;
using ToDoList.Models;
using Microsoft.EntityFrameworkCore;
using ToDoList.Controllers.Requests;
using System.ComponentModel.DataAnnotations;

namespace ToDoList.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class UserController : ControllerBase
    {
        private ToDoContext _ctx;
        public UserController(ToDoContext context)
        {
            this._ctx = context;
        }

        [HttpGet]
        [Route("/[Controller]/Get/{id?}")]
        public string Get(int? id)
        {
            return $"chuj {id}";
        }

        [HttpPost]
        [Route("/[Controller]/GetUserById")]
        public JsonResult GetUsersById([FromBody] GetUsersJsonRequest req)
        {
            List<User> users = _ctx.Users.Where(u => u.UserId == req.Id).Include(u => u.ToDoSpaces).ToList();
            if (users.Any())
            {
                return new JsonResult(users);
            } 
            else
            {
                return new JsonResult("User not found!")
                {
                    StatusCode = StatusCodes.Status404NotFound
                };
            }
           
        }
        
        
        [HttpPost]
        [Route("/[Controller]/RegisterUser")]
        public JsonResult RegisterUser([FromBody] RegisterUserJsonRequest req)
        {
            var validationContext = new ValidationContext(req, null);
            var validationResults = new List<ValidationResult>();
            if(Validator.TryValidateObject(req, validationContext, validationResults))
            {
                return new JsonResult("OK");
            } else
            {
                return new JsonResult(validationResults) { StatusCode = StatusCodes.Status400BadRequest};
            }
        }

    }
}
