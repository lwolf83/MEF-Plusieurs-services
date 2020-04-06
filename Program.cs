using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.ComponentModel.Composition;
using System.ComponentModel.Composition.Hosting;

namespace ConsoleApp7
{
    class Program
    {
        private Host _host = null;

        [ImportMany(typeof(ILogger))]
        private IEnumerable<ILogger> _loggers;

        static void Main(string[] args)
        {
            var program = new Program();
            program.Run();
            Console.Read();
        }

        public Program()
        {
            _host = new Host();
            _loggers = _host.Container.GetExportedValues<ILogger>();
        }

        public void Run()
        {
            foreach(var logger in _loggers)
            {
                logger.Write("Hello");
            }
            
        }
    }
}
