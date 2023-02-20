namespace SimUDuck.Strategies.QuackBehaviour;

public class RegularQuack : IQuackBehaviour
{
    public void Quack()
    {
        System.Console.WriteLine("Quack!");
    }
}