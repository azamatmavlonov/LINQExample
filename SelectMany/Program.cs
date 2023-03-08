namespace SelectMany
{
    record class Company(string Name, List<Person> Staff);
    record class Person(string Name);
    internal class Program
    {
        static void Main(string[] args)
        {
            var companies = new List<Company>
            {
                new Company("Microsoft", new List<Person> { new Person("Ali"), new Person("Vali")}),
                new Company("Google", new List<Person> { new Person("Gani"), new Person("Sher")})
            };

            var employees = companies.SelectMany(c => c.Staff,
                                                (c, emp) => new { Name = emp.Name, Company = c.Name });

            /* Second variant
            var employees = from c in companies
                            from emp in c.Staff
                            select emp;
            */
            foreach (var employee in employees)
                Console.WriteLine($"{employee.Name} - {employee.Company}");
        }
    }
}