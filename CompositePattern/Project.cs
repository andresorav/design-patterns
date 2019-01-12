using System;
using System.Collections.Generic;

namespace CompositePattern
{
    public class Project : ITodo
    {
        private readonly string _title;
        private readonly List<ITodo> _toDos;

        public Project(string title, List<ITodo> toDos)
        {
            _title = title;
            _toDos = toDos;
        }

        public void PrintTodo(string space = "")
        {
            Console.WriteLine("{0}# Project: {1}", space, _title);
            foreach (var todo in _toDos)
            {
                todo.PrintTodo(space + "  ");
            }
        }
    }
}