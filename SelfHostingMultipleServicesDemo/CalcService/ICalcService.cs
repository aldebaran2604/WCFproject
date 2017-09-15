using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace CalcServiceLibrary
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface ICalcService
    {
        [OperationContract]
        int Multiply(MyNumbers obj);

        [OperationContract]
        int Divide(MyNumbers obj);

        // TODO: agregue aquí sus operaciones de servicio
    }

    // Utilice un contrato de datos, como se ilustra en el ejemplo siguiente, para agregar tipos compuestos a las operaciones de servicio.
    // Puede agregar archivos XSD al proyecto. Después de compilar el proyecto, puede usar directamente los tipos de datos definidos aquí, con el espacio de nombres "CalcService.ContractType".
    [DataContract]
    public class MyNumbers
    {
        [DataMember]
        public int Number1 { get; set; }

        [DataMember]
        public int Number2 { get; set; }
    }
}
