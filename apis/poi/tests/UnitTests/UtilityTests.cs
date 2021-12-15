using Xunit;
using poi.Utility;

namespace UnitTests
{
    public class UtilityTests
    {
        [Fact]
        public void TestLoggingEvents()
        {
            Assert.Equal(100, LoggingEvents.Healthcheck);
            Assert.Equal(200, LoggingEvents.GetAllPOIs);
            Assert.Equal(200, LoggingEvents.GetPOIByID);
            Assert.Equal(200, LoggingEvents.GetPOIByTripID);
            throw new System.Exception("up");
        }
    }
}