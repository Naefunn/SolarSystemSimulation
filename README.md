# Solar System Simulation

This project is a real-time, interactive solar system simulation built using **C#** and **WPF** (Windows Presentation Foundation). The goal of the simulation is to visualise the motion of celestial bodies (planets) around a central star (the Sun) while maintaining basic physical principles like gravity and orbital mechanics.

## Features

- **Realistic Orbital Mechanics**: The planets orbit around the Sun with positions calculated based on basic laws of gravity and orbital motion. The simulation includes proportional speeds, distances, and orbital radii.
  
- **Interactive Planets**: Each planet can be clicked on, and additional information about the planet (such as its name and facts) is displayed dynamically.

- **Time Scale Control**: The simulation allows you to control the speed of the orbits with a slider, adjusting the time scale from thousands to millions of times faster than real life, enabling users to experience the simulation at various speeds.

- **Animated Orbits**: The planets orbit around the Sun with smooth animations that visually represent the motion, giving users an engaging experience.

## Technologies Used

- **C#** – The core programming language used to implement the simulation and orbital mechanics.
- **WPF (Windows Presentation Foundation)** – Used for creating the graphical user interface (GUI) and rendering the planets and Sun on the screen.
- **MVVM Pattern** – The project is structured using the MVVM (Model-View-ViewModel) pattern for clear separation of concerns.
- **DispatcherTimer** – Used for updating the simulation at a fixed interval, creating a smooth animation loop.

## Installation

1. **Clone the Repository**:
   `git clone https://github.com/yourusername/SolarSystemSimulation.git`

2. **Open the Project**:
   - Open the project in **Visual Studio**.

3. **Run the Application**:
   - Press `F5` or click **Start** in Visual Studio to launch the simulation.


## How It Works

- The simulation starts with a Sun and two planets, Earth and Mars, initialized in orbit.
- Each planet is represented by a circle (Ellipse) and moves in an elliptical orbit around the Sun.
- The time scale can be adjusted via a slider to simulate real-time orbital motion or speed up the simulation.
- Planets are clickable, showing additional information when selected.

## Future Improvements

- **Enhanced Visuals**: Plan to improve the visuals by adding 3D graphics, textures, and more accurate representations of planets.
- **More Celestial Bodies**: Plan to add more planets, moons, and perhaps other solar systems.
- **Realistic Physics**: Implement more realistic orbital mechanics, including gravitational forces from other planets and effects like eccentric orbits.
- **User Interface**: Enhance the UI with additional information and controls for a better user experience.

