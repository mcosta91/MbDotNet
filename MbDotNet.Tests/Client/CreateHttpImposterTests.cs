using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace MbDotNet.Tests.Client
{
    [TestClass]
    public class CreateHttpImposterTests : MountebankClientTestBase
    {
        [TestMethod]
        public void ShouldNotAddNewImposterToCollection()
        {
            Client.CreateHttpImposter(123);
            Assert.AreEqual(0, Client.Imposters.Count);
        }
        
        [TestMethod]
        public void WithoutName_SetsNameToNull()
        {
            var imposter = Client.CreateHttpImposter(123);
            
            Assert.IsNotNull(imposter);
            Assert.IsNull(imposter.Name);
        }

        [TestMethod]
        public void WithName_SetsName()
        {
            const string expectedName = "Service";

            var imposter = Client.CreateHttpImposter(123, expectedName);
            
            Assert.IsNotNull(imposter);
            Assert.AreEqual(expectedName, imposter.Name);
        }

        [TestMethod]
        public void WithoutPortAndName_SetsPortAndNameToNull()
        {
            var imposter = Client.CreateHttpImposter();

            Assert.IsNotNull(imposter);
            Assert.AreEqual(default(int), imposter.Port);
            Assert.IsNull(imposter.Name);
        }
    }
}