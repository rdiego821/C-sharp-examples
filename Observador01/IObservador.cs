using System;
using System.Collections.Generic;
using System.Text;

namespace Observador01
{
    interface IObservador
    {
        void Update(string mensaje);
        void UpdatePull();
    }
}
