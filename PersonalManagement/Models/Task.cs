using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonalManagement.Models
{
    internal class Task
    {
        public Guid Id { get; }
        public string Title { get; }
        public bool IsDone { get; }
        public DateTime CreatedAt { get; }

        public Task(string title, bool isDone, DateTime createdAt)
        {
            Id = new Guid();
            Title = title;
            IsDone = isDone;
            CreatedAt = createdAt;
        }
    }
}
