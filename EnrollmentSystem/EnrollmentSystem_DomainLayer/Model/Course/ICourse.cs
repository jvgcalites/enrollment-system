namespace EnrollmentSystem_DomainLayer
{
    interface ICourse
    {
        string CourseCode { get; set; }
        int CourseId { get; set; }
        string CourseTitle { get; set; }
        Section Section { get; set; }
        int Unit { get; set; }
    }
}