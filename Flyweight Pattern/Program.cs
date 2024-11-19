namespace Flyweight_Pattern
{
    class Program
    {
        static void Main(string[] args)
        {
            var factory = new Character.CharacterFactory();

            // создаем перса и если такого персонажа нет фабрика создаст его  

            var her1 = factory.GetCharacter("g", "zloi", "bledno.png");

            // фабрика должна вернуть тот же объект что и her1
            var her2 = factory.GetCharacter("g", "zloi", "hihihi.png"); // Этот персонаж будет тем же самым

            Console.WriteLine($"перс 1: {her1.Name}, Type: {her1.Type}, Image: {her1.Image}");

            Console.WriteLine($"перс 2: {her2.Name}, Type: {her2.Type}, Image: {her2.Image}");

        }
    }
}