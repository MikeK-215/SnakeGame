SnakeGame

A classic Snake game built with C# and WPF, targeting .NET 9.

Features

•	Responsive keyboard controls
•	Growing snake and collectible food
•	Game over on collision with walls or self
•	Score tracking
•	Customizable graphics via the Assets folder

Requirements

•	.NET 9 SDK
•	Visual Studio 2022 or later (Windows only, due to WPF)

Getting Started

1.	Clone the repository:
2.	Open the solution in Visual Studio.
3.	Build the solution using Build > Build Solution.
4.	Run the game by setting SnakeGame as the startup project and pressing F5.

Running Tests

•	Open the Test Explorer in Visual Studio.
•	Click Run All to execute unit tests in the SnakeGameTest project.

Project Structure

•	SnakeGame/ – Main WPF application
•	MainWindow.xaml – Game UI
•	GameState.cs – Game logic
•	Images.cs – Image management
•	Assets/ – Game images (snake, food, etc.)
•	SnakeGameTest/ – MSTest unit tests

Customization

•	Replace images in the Assets folder to change the appearance of the snake or food.
•	Adjust grid size or game speed in the code for a different challenge.

License

This project is for educational purposes.
