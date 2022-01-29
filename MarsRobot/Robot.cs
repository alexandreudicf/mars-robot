namespace MarsRobot
{
    public class Robot
    {
        private int x = 1;
        private int y = 1;
        private int cardinalPointer = 0;

        /// <summary>
        /// Returns final position of robot based on the grid and commands.
        /// </summary>
        /// <param name="grid">size of grid.</param>
        /// <param name="commands">list of commands. Valid Comands: 'L': Left, 'R': Right and 'F': Forward.</param>
        /// <returns>Final position</returns>
        public (int x, int y, string cardinalDirection) MyPosition(int[] grid, char[] commands)
        {

            foreach (char command in commands)
            {
                switch (command)
                {
                    // Infinite circle incrementation.
                    case 'L':
                        cardinalPointer = MathHelper.Mod(cardinalPointer - 1, 4);
                        break;
                    case 'R':
                        cardinalPointer = MathHelper.Mod(cardinalPointer + 1, 4);
                        break;
                    case 'F':
                        // 0: North, 2: South
                        int newY = cardinalPointer == 0 ? y + 1 : cardinalPointer == 2 ? y - 1 : y;
                        // 1: East, 3: West
                        int newX = cardinalPointer == 1 ? x + 1 : cardinalPointer == 3 ? x - 1 : x;
                        // out of bounds validation 
                        if (newX > 0 && newX <= grid[0])
                            x = newX;
                        if (newY > 0 && newY <= grid[1])
                            y = newY;
                        break;
                    default:
                        break;
                }
            }

            string[] cardinalDirection = { "North", "East", "South", "West" };

            return (x, y, cardinalDirection[cardinalPointer]);
        }
    }
}
