namespace BootCamp.Chapter1
{
    class Program
    {
        static void Main(string[] args)
        {
            CheckAndResetWindowSize();
            int[] numbers = new int[10];
            numbers[0] = 2;
            numbers[1] = 4;
            numbers[2] = 8;
            numbers[3] = 16;
            numbers[4] = 32;
            numbers[5] = 64;
            numbers[6] = 128;
            numbers[7] = 256;
            numbers[8] = 512;
            numbers[9] = 1048;
            for (int i = 0; i < numbers.Length; i++)
            {
                Console.WriteLine(numbers[i]);
            }
        }
        private static void CheckAndResetWindowSize()
        {
            if (Console.WindowHeight != 300 || Console.WindowWidth != 500)
            {
                Console.SetWindowSize(120, 40);
            }
        }
    }
}
