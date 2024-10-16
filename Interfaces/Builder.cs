using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Lab1.Interfaces
{
    public abstract class Builder
    {
        public abstract void BuildPoint();

        public abstract void BuildCircle();

        public abstract void BuildLine();

        public abstract void GetResult();
    }
}
