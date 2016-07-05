using BaseProject;
using NUnit.Framework;

namespace TestProject
{
    [TestFixture]
    public class DerivedTests : TestBase
    {
        [Test]
        public void NUnit3_test_derived_from_NUnit2_base_class_should_be_discovered()
        {
            Assert.That(true, Is.True);
        }
    }
}
