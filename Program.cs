using ReflectorAccountCustomer.models;

namespace ReflectorAccountCustomer
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Reflection reflection = new Reflection();

            reflection.ShowDetails(typeof(Account));
            reflection.ShowDetails(typeof(Customer));

            reflection.ShowDetails(typeof(object));

        }
    }
}
