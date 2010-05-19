﻿using System.CodeDom.Compiler;
using System.ServiceModel;
using System.ServiceModel.Channels;
using System.Diagnostics;
//
namespace FirstWcfService
{
    [GeneratedCode("System.ServiceModel", "4.0.0.0")]
    [ServiceContract(Namespace = "FirstWcfService", ConfigurationName = "FirstWcfService.ICalculator")]
    public interface ICalculator
    {
        [OperationContract(Action = "FirstWcfService/ICalculator/Add", ReplyAction = "FirstWcfService/ICalculator/AddResponse")]
        double Add(double n1, double n2);
        [OperationContract(Action = "FirstWcfService/ICalculator/Subtract", ReplyAction = "FirstWcfService/ICalculator/SubtractResponse")]
        double Subtract(double n1, double n2);
        [OperationContract(Action = "FirstWcfService/ICalculator/Multiply", ReplyAction = "FirstWcfService/ICalculator/MultiplyResponse")]
        double Multiply(double n1, double n2);
        [OperationContract(Action = "FirstWcfService/ICalculator/Divide", ReplyAction = "FirstWcfService/ICalculator/DivideResponse")]
        double Divide(double n1, double n2);
    }
    [GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public interface ICalculatorChannel : ICalculator, IClientChannel
    {
    }
    [DebuggerStepThrough()]
    [GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public partial class CalculatorClient : ClientBase<ICalculator>, ICalculator
    {
        public CalculatorClient()
        {
        }
        public CalculatorClient(string endpointConfigurationName) : 
                base(endpointConfigurationName)
        {
        }
        public CalculatorClient(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        public CalculatorClient(string endpointConfigurationName, EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress)
        {
        }
        public CalculatorClient(Binding binding, EndpointAddress remoteAddress) : 
                base(binding, remoteAddress)
        {
        }
        //
        //
        //
        public double Add(double n1, double n2)
        {
            return base.Channel.Add(n1, n2);
        }
        public double Subtract(double n1, double n2)
        {
            return base.Channel.Subtract(n1, n2);
        }
        public double Multiply(double n1, double n2)
        {
            return base.Channel.Multiply(n1, n2);
        }
        public double Divide(double n1, double n2)
        {
            return base.Channel.Divide(n1, n2);
        }
    }
}