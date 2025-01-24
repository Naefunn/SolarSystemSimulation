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
   ```bash
   git clone https://github.com/yourusername/SolarSystemSimulation.git
