namespace DataMonitoring
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

            var names = from p in people select p.Name;

            foreach (string n in names)
                Console.WriteLine(n);
        }
    }
}