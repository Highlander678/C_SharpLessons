using System;
using System.ServiceModel;

namespace WCF_Служба
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to...
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        String ВводИмени(String Имя);
    }
}
