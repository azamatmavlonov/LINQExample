namespace UsingSelectExtentionMethod
{
    record class Person(string Name, int Age);
    internal class Program
    {
        static void Main(string[] args)
        {
            var people = new List<Person>
            {
                new Person("Ali", 18),
                new Person("Vali", 20),
                new Person("Abdu", 19),
                new Person("Abubakr", 48),
                new Person("Akmal", 11)
            };

            var names = people.Select(u => u.Name);

            // Using let
            var personel = from p in people
                           let name = $"Mr. { p.Name }"
                           let year = DateTime.Now.Year - p.Age
                           select new
                           {
                               Name = name,
                               Year = year
                           };

            /* The second variant
            var personel = people.Select(p => new
            {
                FirstName = p.Name,
                Year = DateTime.Now.Year - p.Age
            });
            */

            foreach (var p in personel)
                Console.WriteLine($"{ p.Name } - { p.Year }");
        }
    }
}