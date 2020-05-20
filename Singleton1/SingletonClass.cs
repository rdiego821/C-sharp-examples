using System;
using System.Collections.Generic;
using System.Text;

namespace Singleton1
{
    sealed class SingletonClass
    {
        private static SingletonClass _instance = null;
        private static readonly object _lock = new object();

        private int edad;
        private string nombre;

        SingletonClass() 
        {
            nombre = "sin asignar";
            edad = -1;
        }

        public static SingletonClass SingleInstance
        {
            get
            {
                lock (_lock)
                {
                    if (_instance == null)
                    {
                        _instance = new SingletonClass();
                        Console.WriteLine("new instance");
                    }

                    return _instance;
                }
            }
        }

        public override string ToString()
        {
            return string.Format("Nueva instancia de objeto edad {0} y nombre {1}", edad, nombre);
        }
    }
}
