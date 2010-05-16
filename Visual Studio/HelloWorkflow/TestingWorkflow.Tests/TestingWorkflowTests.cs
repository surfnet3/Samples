using System;
using System.Text;
using System.Collections.Generic;
using System.Linq;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Activities;

namespace HelloWorkflow.Tests
{
    [TestClass]
    public class TestingWorkflowTests
    {
        [TestMethod]
        public void ShouldReturnGreetingWithName()
        {
            IDictionary<string, object> output;
            output = WorkflowInvoker.Invoke
            (
                new SayHello()
                {
                    Username = "Test"
                }
            );

            Assert.AreEqual("Hello Test from Workflow 4", output["Greeting"]);
        }
    }
}
