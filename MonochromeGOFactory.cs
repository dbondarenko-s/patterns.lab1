using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Patterns.Lab1.Interfaces;
using Patterns.Lab1.Objects;

namespace Patterns.Lab1
{
    public class MonochromeGOFactory : AbstractGOFactory
    {
        public override Circle CreateCircle()
        {
            var item = new Circle(0, 0, 1);

            OnCreate(item);

            return item;
        }

        public override Line CreateLine()
        {
            var item = new Line(0, 0, 1, 1);

            OnCreate(item);

            return item;
        }

        public override Point CreatePoint()
        {
            var item = new Point(0, 0);

            OnCreate(item);

            return item;
        }

        protected void OnCreate(GraphObject item)
        {
            if (item.Color.Equals(GraphObject.DefaultColor) == true)
            {
                Scene.GetInstance().Add(item);
            }
        }
    }
}
