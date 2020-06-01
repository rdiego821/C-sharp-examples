using System;
using System.Collections.Generic;
using System.Text;

namespace Mediador01
{
    interface IColega
    {
        void Recibir(string emisor, string mensaje);
        void Enviar(string mensaje);
    }
}
