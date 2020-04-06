using System;
using System.Collections.Generic;
using System.ComponentModel.Composition;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    [Export(typeof(ILogger))]
    class ToFileLogger : ILogger
    {
        public void Write(string message)
        {
            File.AppendAllText("./log.txt", DateTime.Now + " : Hello");
        }

    }
}
