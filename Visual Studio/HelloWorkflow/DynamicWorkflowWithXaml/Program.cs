using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;
//
// Add using
//
using System.Activities.XamlIntegration;

namespace HelloWorkflow
{

    class Program
    {
        static void Main(string[] args)
        {
            //
            // Modify File Properties of "SayHelloWithXaml.xaml":
            // 1) Build Action: Content
            // 2) Copy to Output Directory: Copy always
            // 3) Custom Tool: <Empty>
            //
            WorkflowInvoker.Invoke(ActivityXamlServices.Load("SayHelloWithXaml.xaml"));
            Console.ReadKey(false);
        }
    }
}
