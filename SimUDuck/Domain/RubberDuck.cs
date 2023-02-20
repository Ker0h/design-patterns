using SimUDuck.Strategies.FlyBehaviour;
using SimUDuck.Strategies.QuackBehaviour;

namespace SimUDuck.Domain;

public class RubberDuck : Duck
{
    public RubberDuck()
    {
        SetFlyBehaviour(new NoFly());
        SetQuackBehaviour(new Squeak());
    }
    
    public override void Display()
    {
        System.Console.WriteLine("I'm a Rubber Duck!");
    }
}