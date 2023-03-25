namespace ConsoleApp5._3._5_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 1, 2, 3 };
            BigDataOperation(arr);

            Console.WriteLine(arr[0]);

            static void BigDataOperation(in int[] arr)
            {
                arr[0] = 4;
            }
        }
    }
}