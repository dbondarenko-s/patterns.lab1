﻿namespace Patterns.Lab1.Objects
{
    using System;
    using Patterns.Lab1.Interfaces;

    public class Point : GraphObject
    {
        public Coordinates Coordinates { get; private set; }

        public Point(Point point) : this(point.Coordinates.X, point.Coordinates.Y, point.Color)
        {
        }

        public Point(int x, int y) : this(x, y, DefaultColor)
        {
        }

        public Point(int x, int y, string color) : base(color)
        {
            Coordinates = new Coordinates(x, y);
        }

        public override void Draw()
        {
            Console.WriteLine($"Point. Coordinates: X={Coordinates.X}, Y={Coordinates.Y}. Color: {Color}.");
        }

        public override Point Clone()
        {
            return new Point(this);
        }
    }
}
