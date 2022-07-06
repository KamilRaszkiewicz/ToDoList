using ToDoList.Models.Containers;
using System.ComponentModel.DataAnnotations;
namespace ToDoList.Models
{
    public class ToDoSpace
    {
        [Key]
        public int SpaceId { get; set; }
        public string Name { get; set; }
        public List<ContainerBase> Containers { get; set; }

        public User User { get; set; }
    }
}
