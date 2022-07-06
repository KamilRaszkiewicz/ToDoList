namespace ToDoList.Models.Containers
{
    public class CheckList : ContainerBase
    {
        public List<CheckedListElement> ListElements { get; set; }
    }
}
