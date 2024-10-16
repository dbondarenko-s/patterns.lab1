using Patterns.Lab1.Objects;

namespace Patterns.Lab1.Interfaces
{
    public abstract class AbstractGOFactory
    {
        public abstract Point CreatePoint();

        public abstract Circle CreateCircle();

        public abstract Line CreateLine();
    }
}
