using SimUDuck.Strategies.FlyBehaviour;
using SimUDuck.Strategies.QuackBehaviour;

namespace SimUDuck.Domain;

public class RocketDuck : Duck
{
    public RocketDuck()
    {
        SetFlyBehaviour(new FlyWithRockets());
        SetQuackBehaviour(new RegularQuack());
    }
    
    public override void Display()
    {
        System.Console.WriteLine("I'm a Rocket Duck!");
    }
}