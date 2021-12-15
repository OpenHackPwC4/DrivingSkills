using Xunit;
using poi.Utility;

namespace UnitTests
{
    public class UtilityTests
    {
        [Fact]
        public void TestLoggingEvents()
        {
            Assert.Equal(10, LoggingEvents.Healthcheck);
            Assert.Equal(20, LoggingEvents.GetAllPOIs);
            Assert.Equal(20, LoggingEvents.GetPOIByID);
            Assert.Equal(20, LoggingEvents.GetPOIByTripID);
            throw new System.Exception("up");
        }
    }
}