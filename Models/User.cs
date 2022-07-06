using System.ComponentModel.DataAnnotations;
namespace ToDoList.Models
{
    public class User
    {
        [Key]
        public int UserId { get; set; }
        public string Name { get; set; }
        public string Email { get; set; }
        public virtual List<ToDoSpace> ToDoSpaces { get; set; }
    }
}
