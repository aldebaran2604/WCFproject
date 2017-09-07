using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;

namespace MathService
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de clase "MathService" en el código, en svc y en el archivo de configuración.
    // NOTE: para iniciar el Cliente de prueba WCF para probar este servicio, seleccione MathService.svc o MathService.svc.cs en el Explorador de soluciones e inicie la depuración.
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
