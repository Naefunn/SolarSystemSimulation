using System.Windows;
using System.Windows.Controls;
using System.Windows.Shapes;
using System.Windows.Threading;
using SolarSystemSimulation.Models;

namespace SolarSystemSimulation
{
    public partial class MainWindow : Window
    {
        private SolarSystem _solarSystem;
        private DispatcherTimer _timer;

        public MainWindow()
        {
            InitializeComponent();

            _solarSystem = new SolarSystem();
            _timer = new DispatcherTimer();

            InitializeSolarSystem();
            StartAnimation();
        }

        private void InitializeSolarSystem()
        {
            _solarSystem = new SolarSystem();

            Point sunPosition = new Point(400, 225);

            // Create and add the Sun
            Ellipse sun = new Ellipse
            {
                Width = 50,
                Height = 50,
                Fill = System.Windows.Media.Brushes.Yellow
            };
            Canvas.SetLeft(sun, sunPosition.X - 25);
            Canvas.SetTop(sun, sunPosition.Y - 25);
            SolarSystemCanvas.Children.Add(sun);

            // Add planets with real-world orbital radii (scaled) and periods
            _solarSystem.AddPlanet(new Planet("Earth", 100, 1, 20, System.Windows.Media.Brushes.Blue, sunPosition));
            _solarSystem.AddPlanet(new Planet("Mars", 150, 1.88, 15, System.Windows.Media.Brushes.Red, sunPosition));

            // Render planets on the canvas
            _solarSystem.Render(SolarSystemCanvas);
        }


        private void StartAnimation()
        {
            _timer = new DispatcherTimer();
            _timer.Interval = TimeSpan.FromMilliseconds(16); // ~60 FPS
            _timer.Tick += (sender, e) =>
            {
                // Update the TimeScale from the slider
                _solarSystem.TimeScale = TimeScaleSlider.Value;
                _solarSystem.Update();
            };
            _timer.Start();
        }


    }
}
