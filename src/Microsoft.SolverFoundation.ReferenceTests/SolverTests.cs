using NUnit.Framework;

namespace Microsoft.SolverFoundation.ReferenceTests
{
    public class SolverTests
    {
        [SetUp]
        public void Setup()
        {
        }

        [Test]
        public void CanRunCustomModel()
        {
            var scenario = new CustomScenario();
            scenario.Create();
            scenario.Solve();
        }
    }
}