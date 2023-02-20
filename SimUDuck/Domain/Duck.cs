using SimUDuck.Strategies.FlyBehaviour;
using SimUDuck.Strategies.QuackBehaviour;

namespace SimUDuck.Domain;

public abstract class Duck
{
    private IFlyBehaviour _flyBehaviour;
    private IQuackBehaviour _quackBehaviour;
    
    public abstract void Display();
    
    public void PerformFly()
    {
        _flyBehaviour.Fly();
    }
    
    public void SetFlyBehaviour(IFlyBehaviour flyBehaviour)
    {
        _flyBehaviour = flyBehaviour;
    }
    
    public void PerformQuack()
    {
        _quackBehaviour.Quack();
    }
    
    public void SetQuackBehaviour(IQuackBehaviour quackBehaviour)
    {
        _quackBehaviour = quackBehaviour;
    }
}
    
