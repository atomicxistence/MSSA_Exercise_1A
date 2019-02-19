using System;

namespace MathmaticalEquations
{
    public class Circle
    {
        public double Area { get; private set; }
        public double Circumference { get; private set; }

        private double radius;

        public Circle(double radius)
        {
            this.radius = radius;

            SetArea();
            SetCircumference();
        }

        private void SetArea()
        {
            Area = Math.PI * (radius * radius);
        }

        private void SetCircumference()
        {
            Circumference = 2 * Math.PI * radius;
        }
    }
}
