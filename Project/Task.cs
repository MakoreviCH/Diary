using System;
using System.Collections.Generic;


namespace Project
{
    public class Task
    {
        public string Name { get; set; }
        public DateTime Date { get; set; }
        public DateTime Time { get; set; }
        public bool Complete { get; set; }
        
        public string Place { get; set; }
        public string Group { get; set; }

        public Task(string name, DateTime date, DateTime time, bool complete, string group, string place) {
            this.Name = name;
            this.Date = date;
            this.Time = time;
            this.Complete = complete;
            this.Group = group;
            this.Place = place;
        }

    }
    public class TaskComparer : IComparer<Task>
    {
        public int Compare(Task first, Task second)
        {
            return DateTime.Compare(first.Date, second.Date);
        }
    }
}
