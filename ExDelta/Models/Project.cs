using System;
using System.Collections.ObjectModel;
using System.ComponentModel.DataAnnotations;

namespace ExDelta.Models
{
    public class Project
    {
        [Key]
        public int Id { get; set; }
        public string Name { get; set; }
        public Collection<Task> Tasks { get; set; }
        public Collection<Milestone> Milestones { get; set; }
        public DateTime Start { get; set; }
        public DateTime End { get; set; }
    }
}
