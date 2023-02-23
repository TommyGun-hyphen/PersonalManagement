using PersonalManagement.Commands;
using PersonalManagement.Models;
using PersonalManagement.Stores;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace PersonalManagement.ViewModels
{
    public class TodoListViewModel : BaseViewModel
    {
        private readonly ObservableCollection<TodoListItemViewModel> todos;
        private readonly TodoStore todoStore;
        private string newTodoTitle;

        public string NewTodoTitle {
            get { return newTodoTitle; } 
            set { 
                newTodoTitle = value;
                OnPropertyChanged(nameof(NewTodoTitle));
                OnPropertyChanged(nameof(CanAddTodo));
            }
        }
        //public bool CanAddTodo => !string.IsNullOrEmpty(NewTodoTitle);
        public bool CanAddTodo { get
            {
                return !string.IsNullOrEmpty(NewTodoTitle);
            }
        }

        public IEnumerable<TodoListItemViewModel> Todos => todos;

        public ICommand AddTodoCommand { get; }

        public TodoListViewModel(TodoStore todoStore)
        {
            this.todoStore = todoStore;
            todos = new ObservableCollection<TodoListItemViewModel>();

            AddTodoCommand = new AddTodoCommand(todoStore, this);

            AddTodo(new Todo("do stuff", false, DateTime.Now));

            todoStore.TodoAdded += TodoStore_TodoAdded;
            todoStore.TodoDeleted += TodoStore_TodoDeleted;
        }

        private void TodoStore_TodoDeleted(Guid obj)
        {
            throw new NotImplementedException();
        }

        private void TodoStore_TodoAdded(Todo todo)
        {
            AddTodo(todo);
        }

        public void AddTodo(Todo todo)
        {
            todos.Add(new TodoListItemViewModel(todo));
        }
        public void DeleteTodo(Guid id)
        {
            TodoListItemViewModel todo = todos.FirstOrDefault(t => t.Todo.Id == id);
            if(todo != null)
            {
                todos.Remove(todo);
            }
        }
        public void UpdateTodo(Todo todo)
        {
            TodoListItemViewModel oldTodo = todos.FirstOrDefault(t => t.Todo.Id == todo.Id);
            if (oldTodo != null)
            {
                oldTodo.Update(todo);
            }
        }
    }
}
