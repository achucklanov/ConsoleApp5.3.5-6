namespace ConsoleApp5._3._5_6
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var arr = new int[] { 1, 2, 3 };
            var data = 5;

            BigDataOperation(arr, ref data);

            Console.WriteLine("arr[0] = {0}", arr[0]);

            Console.WriteLine("data = {0}", data);

            static void BigDataOperation(in int[] arr, ref int data)
            {
                data = 4;
                arr[0] = data;
            }
        }
    }
}