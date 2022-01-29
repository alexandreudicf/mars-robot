
using MarsRobot;

// Input.
string? inputGrid = Console.ReadLine();
string? inputCommand = Console.ReadLine();

//convert string to int.
int[] grid = inputGrid!.Split('x').Select(i => int.Parse(i)).ToArray();
char[] commands = inputCommand!.ToCharArray();

(int x, int y, string cardinalDirection) = new Robot().MyPosition(grid, commands);

// Display result.
Console.WriteLine($"{x},{y},{cardinalDirection}");