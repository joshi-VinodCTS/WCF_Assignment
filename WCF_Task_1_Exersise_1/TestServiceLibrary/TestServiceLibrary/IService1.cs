using System.ServiceModel;

namespace TestServiceLibrary
{
    [ServiceContract]
    public interface IService1
    {
        [OperationContract]
        string SayHello(string name);

        [OperationContract]
        string TodayProgram (string name);
    }
}
