using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace MathServiceLibrary
{
    // NOTA: puede usar el comando "Rename" del menú "Refactorizar" para cambiar el nombre de interfaz "IService1" en el código y en el archivo de configuración a la vez.
    [ServiceContract]
    public interface IMathService
    {
        [OperationContract]
        int Add(MyNumbers obj);

        [OperationContract]
        int Subtract(MyNumbers obj);
    }

    [DataContract]
    public class MyNumbers
    {
        [DataMember]
        public int Number1 { get; set; }
        
        [DataMember]
        public int Number2 { get; set; }
    }
}
