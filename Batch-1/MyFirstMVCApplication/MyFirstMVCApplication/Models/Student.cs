namespace MyFirstMVCApplication.Models
{
    using System;
    using System.Collections.Generic;
    using System.ComponentModel.DataAnnotations;
    using System.ComponentModel.DataAnnotations.Schema;
    using System.Data.Entity.Spatial;

    public partial class Student
    {
        public int StudentId { get; set; }

        [Required]
        public string Name { get; set; }

        public string FathersName { get; set; }

        public int Standard { get; set; }

        public string Comments { get; set; }

        public int? Teacher_TeacherId { get; set; }

        [StringLength(128)]
        public string SportsEvent_EventName { get; set; }

        public virtual SportsEvent SportsEvent { get; set; }

        public virtual Teacher Teacher { get; set; }
    }
}
