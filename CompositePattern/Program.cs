using System.Collections.Generic;

namespace CompositePattern
{
    internal static class Program
    {
        private static void Main(string[] args)
        {
            var tasks = new List<ITodo>
            {
                new Task("Wake up"),
                new Task("Shower"),
                new Project("Breakfast", new List<ITodo>
                {
                    new Task("Drink coffee"),
                    new Task("Eat pancakes"),
                    new Project("Clean kitchen", new List<ITodo>
                    {
                        new Task("Wash dishes"),
                        new Task("Clean table")
                    })
                })
            };
            
            var thisWeek = CreateProject("This week", new List<ITodo>
            {
                CreateProject("Monday", tasks),
                CreateProject("Tuesday", tasks),
                CreateProject("Wednesday", tasks),
                CreateProject("Thursday", tasks),
                CreateProject("Friday", tasks)
            });
            
            thisWeek.PrintTodo();
        }

        private static Project CreateProject(string projectName, List<ITodo> tasks)
        {
            return new Project(projectName, tasks);
        }
    }
}