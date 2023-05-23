namespace Abstracción.Abstraction
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Person person = new Person();
            person.Name = "Juan Camilo";
            person.Age = 18;
            person.Alive = true;
            Console.WriteLine(person.Name);
        }
    }
}