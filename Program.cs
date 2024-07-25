using PrototypePattern.Prototype;

namespace PrototypePattern
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Create an original object
            var originalPerson = new Person("John Doe", 30);
            Console.WriteLine("Original Person: " + originalPerson);

            // Clone the original object
            var clonedPerson = originalPerson.Clone();
            Console.WriteLine("Cloned Person: " + clonedPerson);

            // Modify the clone
            clonedPerson.Name = "Jane Doe";
            clonedPerson.Age = 25;
            Console.WriteLine("Modified Cloned Person: " + clonedPerson);

            // Original object remains unchanged
            Console.WriteLine("Original Person after cloning: " + originalPerson);
        }
    }
}
