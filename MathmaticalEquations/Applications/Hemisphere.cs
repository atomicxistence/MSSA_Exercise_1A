using System;
namespace MathmaticalEquations
{
    public class Hemisphere
    {
        public double Volume { get; private set; }

        private double radius;

        public Hemisphere(double radius)
        {
            this.radius = radius;
            SetVolume();
        }

        private void SetVolume()
        {
            Volume = (4.0 / 3.0 * Math.PI * Math.Pow(radius, 3) / 2.0);
        }
    }
}
