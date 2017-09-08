using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MathServiceLibrary
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "Service1" en el código y en el archivo de configuración a la vez.
    public class MathService : IMathService
    {
        public int Add(MyNumbers obj)
        {
            return obj.Number1 + obj.Number2;
        }

        public int Subtract(MyNumbers obj)
        {
            return obj.Number1 - obj.Number2;
        }
    }
}
