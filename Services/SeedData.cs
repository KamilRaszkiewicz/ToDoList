using ToDoList.Models;
using ToDoList.Models.Containers;
namespace ToDoList.Services
{
    public class SeedData
    {
        public static void Seed(IServiceProvider sp)
        {
            var ctx = sp.GetService<ToDoContext>();

            ctx.Database.EnsureCreated();
            if (ctx.Users.Any()) return;


            ctx.Users.AddRange(new[] {
                new User
                {
                    Name = "Walter",
                    Email = "walt@white.com",
                    ToDoSpaces = new List<ToDoSpace>
                    {
                        new ToDoSpace
                        {
                            Name = "Space1",
                            Containers = new List<ContainerBase>
                            {
                                new Note
                                {
                                    Name="Doctor visit",
                                    Content = "Don't forget to visit doctor on thursday at 2 pm",
                                    IsChecked=false
                                },
                                new CheckList
                                {
                                    Name = "Grocery shopping",
                                    IsChecked=false,
                                    ListElements = new List<CheckedListElement>
                                    {
                                        new CheckedListElement
                                        {
                                            IsChecked = false,
                                            Content = "Milk"
                                        },
                                        new CheckedListElement
                                        {
                                            IsChecked = false,
                                            Content = "Water"
                                        },
                                        new CheckedListElement
                                        {
                                            IsChecked = false,
                                            Content = "Bread"
                                        }
                                    }
                                }
                            }
                        }
                    }
                },new User
                {
                    Name = "Gregory",
                    Email = "myemail123@example.com",
                    ToDoSpaces = new List<ToDoSpace>
                    {
                        new ToDoSpace
                        {
                            Name = "someName",
                            Containers = new List<ContainerBase>
                            {
                                new CheckList
                                {
                                    Name = "Pharmacy",
                                    IsChecked=false,
                                    ListElements = new List<CheckedListElement>
                                    {
                                        new CheckedListElement
                                        {
                                            IsChecked = false,
                                            Content = "Some paracetamol"
                                        },
                                        new CheckedListElement
                                        {
                                            IsChecked = false,
                                            Content = "Aspirine"
                                        },
                                        new CheckedListElement
                                        {
                                            IsChecked = true,
                                            Content = "Wounds plasters"
                                        }
                                    }
                                },
                                new CheckList
                                {
                                    Name = "Duties",
                                    IsChecked=false,
                                    ListElements = new List<CheckedListElement>
                                    {
                                        new CheckedListElement
                                        {
                                            IsChecked = false,
                                            Content = "Take son from school"
                                        },
                                        new CheckedListElement
                                        {
                                            IsChecked = false,
                                            Content = "Go to the post office"
                                        },
                                    }
                                }
                            }
                        }
                    }
                }
            });


            ctx.SaveChanges();
        }
    }
}
