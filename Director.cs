using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Lab1.Interfaces;

namespace Patterns.Lab1
{
    public class Director
    {
        private readonly Builder _builder;

        public Director(Builder builder)
        {
            _builder = builder;
        }

        public void Construct()
        {
            _builder.BuildPoint();
            _builder.BuildLine();
            _builder.BuildCircle();
        }
    }
}
