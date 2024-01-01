namespace CSharp.LINQ.Model
{
    public class Grade
    {
        public string Id { get; set; }
        public string Name { get; set; }

        public static List<Grade> GetAll()
        {
            return new List<Grade> { 
                new Grade { Id = "A", Name = "Class A" }, 
                new Grade { Id = "B", Name = "Class B" },
                new Grade { Id = "C", Name = "Class C" },
                new Grade { Id = "D", Name = "Class D" },
                new Grade { Id = "E", Name = "Class E" }
            };
        }
    }
}
