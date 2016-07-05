using NUnit.Framework;

namespace TestProject
{
    [TestFixture]
    public class Tests
    {
        [Test]
        public void NUnit3_test_should_pass()
        {
            Assert.That(true, Is.True);
        }
    }
}
