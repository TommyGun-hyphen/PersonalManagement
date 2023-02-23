using PersonalManagement.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalManagement.Stores
{
    public class TodoStore
    {
        private List<Todo> todos;
        public IEnumerable<Todo> Todos => Todos;

        public event Action<Todo> TodoAdded;
        public event Action<Todo> TodoUpdated;
        public event Action<Guid> TodoDeleted;

        public TodoStore()
        {
            todos = new List<Todo>();
        }

        public async Task AddTodo(Todo todo)
        {
            todos.Add(todo);
            TodoAdded?.Invoke(todo);
        }
        public async Task DeleteTodo(Guid id)
        {
            Todo todo = todos.FirstOrDefault(t => t.Id == id);
            if(todo != null)
            {
                todos.Remove(todo);   
                TodoDeleted?.Invoke(id);
            }
        }
        public async Task UpdateTodo(Todo todo)
        {
            int index = todos.FindIndex(t => t.Id == todo.Id);
            if (index != -1)
            {
                todos[index] = todo;
                TodoUpdated?.Invoke(todo);
            }
        }

    }
}
