using System.ServiceModel;
using System.ServiceModel.Channels;
using System.CodeDom.Compiler;
using System.Diagnostics;
//
namespace FirstWcfClient
{
    [GeneratedCode("System.ServiceModel", "4.0.0.0")]
    [ServiceContract(Namespace = "http://www.sevenpi.com", ConfigurationName = "FirstWcfService.ICalculator")]
    public interface ICalculator
    {
        [OperationContract(Action = "http://www.sevenpi.com/ICalculator/Add", ReplyAction = "http://www.sevenpi.com/ICalculator/AddResponse")]
        double Add(double n1, double n2);
        [OperationContract(Action = "http://www.sevenpi.com/ICalculator/Subtract", ReplyAction = "http://www.sevenpi.com/ICalculator/SubtractResponse")]
        double Subtract(double n1, double n2);
        [OperationContract(Action = "http://www.sevenpi.com/ICalculator/Multiply", ReplyAction = "http://www.sevenpi.com/ICalculator/MultiplyResponse")]
        double Multiply(double n1, double n2);
        [OperationContract(Action = "http://www.sevenpi.com/ICalculator/Divide", ReplyAction = "http://www.sevenpi.com/ICalculator/DivideResponse")]
        double Divide(double n1, double n2);
    }
    [GeneratedCode("System.ServiceModel", "4.0.0.0")]
    public interface ICalculatorChannel : ICalculator, System.ServiceModel.IClientChannel
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