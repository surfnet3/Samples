using System;
using System.Linq;
using System.Activities;
using System.Activities.Statements;

namespace HelloWorkflow
{

    class Program
    {
        static void Main(string[] args)
        {
            WorkflowInvoker.Invoke(new SayHello());
        }
    }
}
