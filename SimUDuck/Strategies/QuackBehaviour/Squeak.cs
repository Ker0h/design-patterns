namespace SimUDuck.Strategies.QuackBehaviour;

public class Squeak : IQuackBehaviour
{
    public void Quack()
    {
        System.Console.WriteLine("Squeak!");
    }
}