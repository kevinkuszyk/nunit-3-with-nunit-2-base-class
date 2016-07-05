using System;
using NUnit.Framework;

namespace BaseProject
{
    public abstract class TestBase
    {
        [SetUp]
        public void Setup()
        {
            Console.WriteLine("Do some setup");
        }
    }
}
