namespace SimUDuck.Strategies.QuackBehaviour;

public class Mute : IQuackBehaviour
{
    public void Quack()
    {
        System.Console.WriteLine("<< Silence >>");
    }
}