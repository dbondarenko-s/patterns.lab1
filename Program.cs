using Patterns.Lab1.Interfaces;

namespace Patterns.Lab1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Builder builder = new ConcreteBuilder();

            Director director = new Director(builder);

            director.Construct();

            builder.GetResult();

            builder = new MemoryBuilder();

            director = new Director(builder);

            director.Construct();

            builder.GetResult();
        }
    }
}
