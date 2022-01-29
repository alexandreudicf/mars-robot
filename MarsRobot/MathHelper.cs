namespace MarsRobot
{
    internal class MathHelper
    {
        public static int Mod(int x, int m) => (x % m + m) % m;
    }
}
