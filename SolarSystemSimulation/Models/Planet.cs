using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Media;
using System.Windows.Shapes;


namespace SolarSystemSimulation.Models
{
    public class Planet
    {
        public string Name { get; }
        public double OrbitalRadius { get; }
        public double OrbitalPeriod { get; } // Orbital period in Earth years
        public double Size { get; }
        public Ellipse Shape { get; private set; }

        private Point _sunPosition;
        private double _currentAngle; // Current angle of the planet in radians

        public Planet(string name, double orbitalRadius, double orbitalPeriod, double size, Brush color, Point sunPosition)
        {
            Name = name;
            OrbitalRadius = orbitalRadius;
            OrbitalPeriod = orbitalPeriod;
            Size = size;
            _sunPosition = sunPosition;

            Shape = new Ellipse
            {
                Width = size,
                Height = size,
                Fill = color
            };
        }

        public void Render(Canvas canvas)
        {
            canvas.Children.Add(Shape);
        }

        public void UpdatePosition(double deltaTime)
        {
            // Orbital speed (angle per second in radians)
            double angularSpeed = 2 * Math.PI / (OrbitalPeriod * 365.25 * 24 * 3600); // radians per second
            _currentAngle += angularSpeed * deltaTime;

            // Calculate the new position
            double x = _sunPosition.X + OrbitalRadius * Math.Cos(_currentAngle);
            double y = _sunPosition.Y + OrbitalRadius * Math.Sin(_currentAngle);

            // Update position on canvas
            Canvas.SetLeft(Shape, x - Size / 2);
            Canvas.SetTop(Shape, y - Size / 2);
        }
    }


}
