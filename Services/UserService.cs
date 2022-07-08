using ToDoList.Models;

namespace ToDoList.Services
{
    public class UserService
    {
        private ToDoContext ctx;

        public UserService(ToDoContext ctx)
        {
            this.ctx = ctx;
        }

        public void RegisterNewUser(User u)
        {
            
        }

    }
}
