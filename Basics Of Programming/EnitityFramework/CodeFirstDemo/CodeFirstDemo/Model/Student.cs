using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo.Model
{
    public class Student
    {
        [Key]
        [DatabaseGenerated(DatabaseGeneratedOption.Identity)]
        public int StudentId { set; get; }

        [Required]
        public string Name { set; get; }

        public string FathersName { set; get; }

        [Required]
        public int Standard { set; get; }

        public string Comments { set; get; }

    }
}
