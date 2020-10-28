using Microsoft.VisualStudio.TestTools.UnitTesting;
using TechJobsOO;

namespace TechJobTests
{
    [TestClass]
    public class JobTests
    {
        [TestMethod]
        public void TestSettingJobId()
        {
            Job testJobOne = new Job();
            Job testJobTwo = new Job();

            Assert.IsFalse(testJobOne.Equals(testJobTwo));
        }
    }
}
