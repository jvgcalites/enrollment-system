using System.Collections.Generic;

namespace EnrollmentSystem_DomainLayer
{
    interface IStudent
    {
        List<Course> CourseLoad { get; set; }
        List<Course> CoursePassed { get; set; }
        string Email { get; set; }
        string FirstName { get; set; }
        string LastName { get; set; }
        string MiddleName { get; set; }
        string Password { get; set; }
        string Program { get; set; }
        int StudentId { get; set; }
    }
}