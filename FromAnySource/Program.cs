namespace FromAnySource
{
    record class Course(string Title);
    record class Student(string Name);
    internal class Program
    {
        static void Main(string[] args)
        {
            var courses = new List<Course>
            {
                new Course("C#"),
                new Course("Java")
            };

            var students = new List<Student>
            {
                new Student("Ali"),
                new Student("Vali")
            };

            var enrollments = from course in courses
                              from student in students
                              select new { Student = student.Name, Course = course.Title };

            foreach (var enrollment in enrollments)
                Console.WriteLine($"{ enrollment.Student } - { enrollment.Course }");
        }
    }
}