using System;

namespace CompositePattern
{
    public class Task : ITodo
    {
        private readonly string _title;

        public Task(string title)
        {
            this._title = title;
        }

        public void PrintTodo(string space = "")
        {
            Console.WriteLine("{0}* Task: {1}", space,_title);
        }
    }
}