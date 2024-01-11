using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using opencvNode.BaseTool;

namespace UnitTestProject1
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void TestMethod1()
        {
            string name = "huang2.hong+5<=6";
            Tokenizer tokenizer = new Tokenizer();
            var k=tokenizer.TokenArithmetic(name);

            Console.WriteLine(k);
        }

        [TestMethod]
        public void TestMethod2()
        {
            
        }

    }
}
