using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Week11
{
    enum StudentField
    {
        
        STUDENT_ID,
        FIRST_NAME,
        LAST_NAME,
        NUM_OF_FIELDS
      
    }
    public class StudentClass
    {
       
        public string studentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
    }
}
