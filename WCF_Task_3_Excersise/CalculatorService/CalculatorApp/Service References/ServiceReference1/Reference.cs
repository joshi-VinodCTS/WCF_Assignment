﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace CalculatorApp.ServiceReference1 {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServiceReference1.ICalculatorService")]
    public interface ICalculatorService {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/AddTwoNumbers", ReplyAction="http://tempuri.org/ICalculatorService/AddTwoNumbersResponse")]
        int AddTwoNumbers(int n1, int n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/AddTwoNumbers", ReplyAction="http://tempuri.org/ICalculatorService/AddTwoNumbersResponse")]
        System.Threading.Tasks.Task<int> AddTwoNumbersAsync(int n1, int n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/SubtractTwoNumbers", ReplyAction="http://tempuri.org/ICalculatorService/SubtractTwoNumbersResponse")]
        int SubtractTwoNumbers(int n1, int n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/SubtractTwoNumbers", ReplyAction="http://tempuri.org/ICalculatorService/SubtractTwoNumbersResponse")]
        System.Threading.Tasks.Task<int> SubtractTwoNumbersAsync(int n1, int n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/MultiplyTwoNumbers", ReplyAction="http://tempuri.org/ICalculatorService/MultiplyTwoNumbersResponse")]
        int MultiplyTwoNumbers(int n1, int n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/MultiplyTwoNumbers", ReplyAction="http://tempuri.org/ICalculatorService/MultiplyTwoNumbersResponse")]
        System.Threading.Tasks.Task<int> MultiplyTwoNumbersAsync(int n1, int n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/DivideTwoNumbers", ReplyAction="http://tempuri.org/ICalculatorService/DivideTwoNumbersResponse")]
        int DivideTwoNumbers(int n1, int n2);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/ICalculatorService/DivideTwoNumbers", ReplyAction="http://tempuri.org/ICalculatorService/DivideTwoNumbersResponse")]
        System.Threading.Tasks.Task<int> DivideTwoNumbersAsync(int n1, int n2);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface ICalculatorServiceChannel : CalculatorApp.ServiceReference1.ICalculatorService, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorServiceClient : System.ServiceModel.ClientBase<CalculatorApp.ServiceReference1.ICalculatorService>, CalculatorApp.ServiceReference1.ICalculatorService {
        
        public CalculatorServiceClient() {
        }
        
        public CalculatorServiceClient(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public CalculatorServiceClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorServiceClient(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public CalculatorServiceClient(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public int AddTwoNumbers(int n1, int n2) {
            return base.Channel.AddTwoNumbers(n1, n2);
        }
        
        public System.Threading.Tasks.Task<int> AddTwoNumbersAsync(int n1, int n2) {
            return base.Channel.AddTwoNumbersAsync(n1, n2);
        }
        
        public int SubtractTwoNumbers(int n1, int n2) {
            return base.Channel.SubtractTwoNumbers(n1, n2);
        }
        
        public System.Threading.Tasks.Task<int> SubtractTwoNumbersAsync(int n1, int n2) {
            return base.Channel.SubtractTwoNumbersAsync(n1, n2);
        }
        
        public int MultiplyTwoNumbers(int n1, int n2) {
            return base.Channel.MultiplyTwoNumbers(n1, n2);
        }
        
        public System.Threading.Tasks.Task<int> MultiplyTwoNumbersAsync(int n1, int n2) {
            return base.Channel.MultiplyTwoNumbersAsync(n1, n2);
        }
        
        public int DivideTwoNumbers(int n1, int n2) {
            return base.Channel.DivideTwoNumbers(n1, n2);
        }
        
        public System.Threading.Tasks.Task<int> DivideTwoNumbersAsync(int n1, int n2) {
            return base.Channel.DivideTwoNumbersAsync(n1, n2);
        }
    }
}
