using System;
using System.Collections.Generic;
using System.ComponentModel.Composition.Hosting;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp7
{
    public class Host
    {
        public CompositionContainer Container
        {
            get
            {
                if (_container == null)
                {
                    var catalog = new DirectoryCatalog(".", "ConsoleApp7.*");
                    _container = new CompositionContainer(catalog);
                }
                return _container;
            }
        }
        private CompositionContainer _container = null;

    }
}
