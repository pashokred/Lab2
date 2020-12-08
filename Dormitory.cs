namespace Lab2
{
    public class Student
    {
        public Student()
        {
            FirstName = "";
            LastName = "";
            Faculty = "";
            Specialization = "";
            Course = "";
            Room = "";
            WhenCheckedInto = "";
        }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Faculty { get; set; }
        public string Specialization { get; set; }
        public string Course { get; set; }
        public string Room { get; set; }
        public string WhenCheckedInto { get; set; }
    }
}