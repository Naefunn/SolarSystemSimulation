using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;

namespace SolarSystemSimulation.Models
{
    public class SolarSystem
    {
        private List<Planet> _planets = new List<Planet>();
        public double TimeScale { get; set; } = 50000000; 
        public void AddPlanet(Planet planet)
        {
            _planets.Add(planet);
        }

        public void Render(Canvas canvas)
        {
            foreach (var planet in _planets)
            {
                planet.Render(canvas);
            }
        }

        public void Update()
        {
            double deltaTime = 1.0 / 60.0; // Simulate ~1/60th of a second per frame
            deltaTime *= TimeScale; // Scale the time to speed up the simulation

            foreach (var planet in _planets)
            {
                planet.UpdatePosition(deltaTime);
            }
        }
    }


}
