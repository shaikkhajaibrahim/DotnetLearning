using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFirstDemo.Model
{
    public class SportsEvent
    {
        [Key]
        public string EventName { set; get; }

        public DateTime EventDate { set; get; }

        public string EventVenue { set; get; }
        public IList<Student> ParticipatingStudents { set; get; }
        
    }
}
