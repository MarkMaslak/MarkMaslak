using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Pen
{
    public class Pen
    {

        /// <summary>
        /// Event informs that cana changed. Event of <see cref="Pen"/> class.
        /// </summary>
        public event EventHandler<PenEventArgs> CanaCambiada;


        protected virtual void OnCanaCambiada(int valorCana)
        {
            CanaCambiada.Raise(this, new PenEventArgs(valorCana)); 
        }



        private int _cana;


        public int Cana
        {
            get { return _cana; }
            set
            {
                if (value == _cana)
                    return;

                _cana = value;
                OnCanaCambiada(_cana);
            }
        }


    }

}
