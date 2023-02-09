using DesignPattern_Strategy;

namespace DesignPattern_Strategy
{
    class Program
    {
        static void Main(string[] args)
        {
            var context = new Context();

            Console.WriteLine("Client: Normal sorting.");
            context.SetStrategy(new ConcreteStrategyA());
            context.DoSomeBusinessLogic();

            Console.WriteLine("-");

            Console.WriteLine("Client: Reverse sorting.");
            context.SetStrategy(new ConcreteStrategyB());
            context.DoSomeBusinessLogic();

            Console.WriteLine("-");

            Console.WriteLine("Client: Some other business logic");
            context.SetStrategy(new ConcreteStrategyC());
            context.DoSomeBusinessLogic();
        }
    }
}