using WebPageGenerator.Pages;

namespace WebPageGenerator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Text text = new Text();

            Console.WriteLine(text.GetType().FullName);
        }
    }
}
