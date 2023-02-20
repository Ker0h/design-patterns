using SimUDuck.Strategies.FlyBehaviour;
using SimUDuck.Strategies.QuackBehaviour;

namespace SimUDuck.Domain;

public class MallardDuck : Duck
{
    public MallardDuck()
    {
        SetFlyBehaviour(new FlyWithWings());
        SetQuackBehaviour(new RegularQuack());
    }

    public override void Display()
    {
        System.Console.WriteLine("I'm a Mallard Duck!");
    }
}