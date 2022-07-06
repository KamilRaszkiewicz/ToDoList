using ToDoList.Models.Containers;
using System.ComponentModel.DataAnnotations;
namespace ToDoList.Models
{
    public class ToDoSpace
    {
        [Key]
        public int SpaceId { get; set; }
        public string Name { get; set; }
        public virtual List<ContainerBase> Containers { get; set; }

        [System.Text.Json.Serialization.JsonIgnore]
        public virtual User User { get; set; }
    }
}
