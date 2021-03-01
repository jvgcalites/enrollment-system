namespace EnrollmentSystem_DomainLayer
{
    interface ISection
    {
        int AvailableSlot { get; set; }
        int Capacity { get; set; }
        string Day { get; set; }
        int SectionId { get; set; }
        string SectionName { get; set; }
        string Time { get; set; }
    }
}