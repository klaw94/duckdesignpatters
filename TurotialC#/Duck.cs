using TurotialC_.FlyBehaviors;
using TurotialC_.QuackBehaviour;

public abstract class Duck
{
    protected IFlyBehavior flyBehavior;
    protected IQuackBehavior quackBehavior;
    public Duck()
    {

    }

    public abstract void Display();
    public void PerformFly()
    {
        flyBehavior.Fly();
    }

    public void PerformQuack()
    {
        quackBehavior.Quack();
    }

    public void Swim()
    {
        Console.WriteLine("All ducks float");
    }


}
