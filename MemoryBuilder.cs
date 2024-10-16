using Patterns.Lab1.Interfaces;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters.Binary;
using System.Text;
using System.Threading.Tasks;

namespace Patterns.Lab1
{
    public class MemoryBuilder : Interfaces.Builder
    {
        private decimal _value;

        private readonly AbstractGOFactory _colorGOFactory;

        public MemoryBuilder()
        {
            _colorGOFactory = new ColorGOFactory();

            _value = 0m;
        }

        public override void BuildCircle()
        {
            var item = _colorGOFactory.CreateCircle();

            _value += GetObjectSize(item);
        }

        public override void BuildLine()
        {
            var item = _colorGOFactory.CreateLine();

            _value += GetObjectSize(item);
        }

        public override void BuildPoint()
        {
            var item = _colorGOFactory.CreatePoint();

            _value += GetObjectSize(item);
        }

        public override void GetResult()
        {
            Console.WriteLine($"Занимает памяти: {_value} байт.");
        }

        private long GetObjectSize(GraphObject item)
        {
            return new Random().Next(100);
        }
    }
}
