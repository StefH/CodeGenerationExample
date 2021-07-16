using System;

namespace HelloWorldConsumer
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var helloWorldInstance = new HelloWorld();
            helloWorldInstance.SayHello();
        }
    }
}