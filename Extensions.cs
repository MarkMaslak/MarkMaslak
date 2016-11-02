using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pen
{

    public static class Extensions
    {
        public static void Raise<T>(this System.EventHandler<T> evento, object sender, T args) where T : EventArgs
        {
            var handler = evento;

            if (handler != null)
                handler(sender, args);
        }
    }


}
