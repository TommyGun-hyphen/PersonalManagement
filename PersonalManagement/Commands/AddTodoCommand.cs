using PersonalManagement.Models;
using PersonalManagement.Stores;
using PersonalManagement.ViewModels;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalManagement.Commands
{
    public class AddTodoCommand : BaseCommand
    {
        private readonly TodoStore todoStore;
        private readonly TodoListViewModel todoListViewModel;

        public override void Execute(object? parameter)
        {
            todoStore.AddTodo(new Todo(todoListViewModel.NewTodoTitle, false, DateTime.Now));
        }

        public AddTodoCommand(TodoStore todoStore, TodoListViewModel todoListViewModel)
        {
            this.todoStore = todoStore;
            this.todoListViewModel = todoListViewModel;
        }
    }
}
