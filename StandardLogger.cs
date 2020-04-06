using System.ComponentModel.Composition;
using System;

namespace ConsoleApp7
{
    [Export(typeof(ILogger))]
    internal class StandardLogger : ILogger
    {
        public void Write(string message)
        {
            Console.WriteLine(DateTime.Now + message);
        }
    }
}