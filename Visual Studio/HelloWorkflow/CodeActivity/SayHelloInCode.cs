using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Activities;

namespace HelloWorkflow
{

    public sealed class SayHelloInCode : CodeActivity
    {
        protected override void Execute(CodeActivityContext context)
        {
            Console.WriteLine("Say Hello Workflow 4 in code");
        }
    }
}
