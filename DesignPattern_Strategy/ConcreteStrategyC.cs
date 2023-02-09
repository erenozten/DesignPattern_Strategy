namespace DesignPattern_Strategy
{
    class ConcreteStrategyC : IStrategy
    {
        public object DoAlgorithm(object data)
        {
            var list = data as List<string>;
            list.Add("y");
            list.Add("z");
            list.Add("x");
            list.Sort();

            return list;
        }
    }
}
