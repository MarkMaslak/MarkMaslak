using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pen
{

    /// <summary>
    /// Pen event arguments. Inherits from <see cref="EventArgs"/> class.
    /// </summary>
    public class PenEventArgs : EventArgs
    {
        /// <summary>
        /// Pen event arguments. Inherits from <see cref="EventArgs"/> class.
        /// </summary>
        /// <param name="cana"></param>
        public PenEventArgs(int cana)
        {
            Cana = cana;
        }

        public readonly int Cana;
    }

}
