using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pen
{

    public class Coche
    {
        public event EventHandler<EventArgs> NueumaticoCambiado;

        public void CambioNeumatico()
        {
            NueumaticoCambiado.Raise(this, new EventArgs());
        }
    }
}
