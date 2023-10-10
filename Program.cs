namespace ConsoleApp12
{
    internal class Program
    {
        static void Main(string[] args)
        {
            CustomString customString = new CustomString();
            Console.WriteLine(CustomString.Remove("xjsnjhijoklj ", 4));
            string[] words = { "saaslm", "sdldsfld", "sagol" };
            Console.WriteLine(CustomString.Join('/'  , words));

        }
    }
}