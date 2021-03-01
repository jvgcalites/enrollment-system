using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EnrollmentSystem_DomainLayer
{
    class Course
    {
        public int CourseId { get; set; }
        public string CourseCode { get; set; }
        public string CourseTitle { get; set; }
        public int Unit { get; set; }
        public Section Section { get; set; }
    }
}
