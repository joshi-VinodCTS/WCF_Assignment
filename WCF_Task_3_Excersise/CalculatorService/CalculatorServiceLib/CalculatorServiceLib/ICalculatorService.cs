using System.ServiceModel;

namespace CalculatorServiceLib
{

    [ServiceContract]
    public interface ICalculatorService
    {
        [OperationContract]
        int AddTwoNumbers(int n1, int n2);

        [OperationContract]
        int SubtractTwoNumbers(int n1, int n2);

        [OperationContract]
        int MultiplyTwoNumbers(int n1, int n2);

        [OperationContract]
        int DivideTwoNumbers(int n1, int n2);
    }

}
