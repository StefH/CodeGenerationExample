using ExampleClassCodeGenerator;

namespace ExampleClassConsumer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var example = new ExampleClass
            {
                I1 = 1,
                I2 = 42,
                I3 = 0
            };
        }
    }
}