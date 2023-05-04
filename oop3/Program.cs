namespace oop3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double weight = int.Parse(Console.ReadLine());

            double gravityOfMoon = 1.62;

            double gravityOfEarth = 9.807;


            // facem instanta dupa un constructor 

            Gravitation gravitation = new Gravitation(weight, gravityOfMoon, gravityOfEarth);

            Console.WriteLine($"The weight {weight} on the moon is {gravitation.GravitationOnTheMoon()}");
        }
    }
}