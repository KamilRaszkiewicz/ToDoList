using System.ComponentModel.DataAnnotations;

namespace ToDoList.Controllers.Requests
{
    public class GetUsersJsonRequest
    {
        [Required]
        public int Id { get; set; }
    }
}
