namespace SimUDuck.Strategies.FlyBehaviour;

public class NoFly : IFlyBehaviour
{
    public void Fly()
    {
        System.Console.WriteLine("I can't fly!");
    }
}