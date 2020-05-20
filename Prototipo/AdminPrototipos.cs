using System;
using System.Collections.Generic;
using System.Text;

namespace Prototipo
{
    class AdminPrototipos
    {
        private Dictionary<string, IPrototipo> prototipos = new Dictionary<string, IPrototipo>();

        public AdminPrototipos()
        {
            Persona persona = new Persona("Ciudadano", 18);
            prototipos.Add("Persona", persona);

            Valores valores = new Valores(1);
            prototipos.Add("Valores", valores);
        }

        public void AdicionaPrototipo(string pLlave, IPrototipo pPrototipo)
        {
            prototipos.Add(pLlave, pPrototipo);
        }

        public object ObtenPrototipos(string pLlave)
        {
            return prototipos[pLlave].Clonar();
        }
    }
}
