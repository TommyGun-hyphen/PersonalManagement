using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace PersonalManagement.Models
{
    public class Todo
    {
        public Guid Id { get; }
        public string Title { get; }
        public bool IsDone { get; }
        public DateTime CreatedAt { get; }

        public Todo(string title, bool isDone, DateTime createdAt)
        {
            Id = new Guid();
            Title = title;
            IsDone = isDone;
            CreatedAt = createdAt;
        }
    }
}
