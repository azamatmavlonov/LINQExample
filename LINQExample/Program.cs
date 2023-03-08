using System.Collections.Immutable;

namespace WithExtentionMethod
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] people = { "Ali", "Ali", "Vali", "Abdu", "Dilshod", "Ravshan", "Mukhriddin", "Abubakr"};

            var selectedPeople = from p in people
                                 where p.ToUpper().StartsWith("D")
                                 orderby p
                                 select p;

            foreach (string person in selectedPeople)
                Console.WriteLine(person);

            var selectedPeopleWithExtentionMethods = people.Where(p=>p.ToUpper().StartsWith("A")).OrderByDescending(p=>p).Distinct().Concat(selectedPeople);

            foreach (string person in selectedPeopleWithExtentionMethods)
                Console.WriteLine(person);
        }
    }
}