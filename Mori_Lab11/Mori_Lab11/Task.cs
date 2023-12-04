using System;
using System.Collections.Generic;
using System.Text;

namespace Mori_Lab11
{
    public class Task
    {
        public int Id { get; set; }
        public string Title { get; set; }
        public string Description { get; set; }
        public bool IsCompleted { get; set; }

        public Task() { }

        public Task(int Id, string Title, string Description, bool IsCompleted) 
        { 
            this.Id = Id;
            this.Title = Title;
            this.Description = Description;
            this.IsCompleted = IsCompleted;
        }
    }
}
