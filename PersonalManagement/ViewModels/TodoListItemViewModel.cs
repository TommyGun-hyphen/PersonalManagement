using PersonalManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonalManagement.ViewModels
{
    public class TodoListItemViewModel : BaseViewModel
    {
        public Todo Todo{ get; private set; }

        public string Title => Todo.Title;
        public bool IsDone => Todo.IsDone;
        public DateTime CreatedAt => Todo.CreatedAt;

        public TodoListItemViewModel(Todo todo)
        {
            this.Todo = todo;
        }

        public void Update(Todo todo)
        {
            Todo = todo;
        }
    }
}
