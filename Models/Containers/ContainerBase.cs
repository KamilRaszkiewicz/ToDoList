
using System.ComponentModel.DataAnnotations;

namespace ToDoList.Models.Containers
{
    public abstract class ContainerBase
    {
        [Key]
        public int ContainerId { get; set; }
        public string Name { get; set; }
        public bool IsChecked { get; set; }
        public ToDoSpace Space { get; set; }
    }
}
