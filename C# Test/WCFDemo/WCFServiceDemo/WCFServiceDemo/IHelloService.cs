using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ServiceModel;
using System.Data;


namespace WCFServiceDemo
{

    [ServiceContract]
    public interface IHelloService
    {
        [OperationContract]
        DateTime getSysdate();

        [OperationContract]
        DataTable GetUserInfo();
 
    }
}
