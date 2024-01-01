namespace CSharp.LINQ.Model
{
    public class Student
    {
        public int StudentId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string Class { get; set; }

        public static List<Student> GetAll()
        {
            return new List<Student>()
            {
                new Student
                {
                    StudentId = 1,
                    FirstName = "John",
                    LastName = "Doe",
                    DateOfBirth = new DateTime(2000, 5, 15),
                    Email = "john.doe@example.com",
                    PhoneNumber = "123-456-7890",
                    Class = "A"
                },
                new Student
                {
                    StudentId = 2,
                    FirstName = "Jane",
                    LastName = "Smith",
                    DateOfBirth = new DateTime(2001, 8, 20),
                    Email = "jane.smith@example.com",
                    PhoneNumber = "987-654-3210",
                    Class = "B"
                },
                new Student
                {
                    StudentId = 3,
                    FirstName = "Alice",
                    LastName = "Johnson",
                    DateOfBirth = new DateTime(2002, 3, 10),
                    Email = "alice.johnson@example.com",
                    PhoneNumber = "555-555-5555",
                    Class = "A"
                },
                new Student
                {
                    StudentId = 4,
                    FirstName = "Michael",
                    LastName = "Williams",
                    DateOfBirth = new DateTime(2000, 9, 2),
                    Email = "michael.williams@example.com",
                    PhoneNumber = "111-222-3333",
                    Class = "C"
                },
                new Student
                {
                    StudentId = 5,
                    FirstName = "Emily",
                    LastName = "Brown",
                    DateOfBirth = new DateTime(2001, 6, 25),
                    Email = "emily.brown@example.com",
                    PhoneNumber = "777-888-9999",
                    Class = "D"
                },
                new Student
                {
                    StudentId = 6,
                    FirstName = "Sarah",
                    LastName = "Miller",
                    DateOfBirth = new DateTime(2003, 2, 12),
                    Email = "sarah.miller@email.com",
                    PhoneNumber = "555-555-5560",
                    Class = "A"
                },
                new Student
                {
                    StudentId = 7,
                    FirstName = "Matthew",
                    LastName = "Anderson",
                    DateOfBirth = new DateTime(2000, 9, 8),
                    Email = "matthew.anderson@email.com",
                    PhoneNumber = "555-555-5561",
                    Class = "B"
                },
                new Student
                {
                    StudentId = 8,
                    FirstName = "Olivia",
                    LastName = "Davis",
                    DateOfBirth = new DateTime(2004, 4, 18),
                    Email = "olivia.davis@email.com",
                    PhoneNumber = "555-555-5562",
                    Class = "B"
                }
            };
        } 
    }
}
