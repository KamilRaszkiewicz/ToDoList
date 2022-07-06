
using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models.Containers
{
    public abstract class ContainerBase
    {
        [Key]
        public int ContainerId { get; set; }
        public string Name { get; set; }
        public bool IsChecked { get; set; }

        [System.Text.Json.Serialization.JsonIgnore]
        public virtual ToDoSpace Space { get; set; }
    }
}
