using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Linq;
using System.Threading.Tasks;

namespace DataProcessor.Library.Tests
{
    [TestClass]
    public class DataParserTests
    {
        private DataParser GetParserWithFakeLogger()
        {
            var logger = new FakeLogger();
            return new DataParser(logger);
        }

        // Alternate expression
        //private DataParser GetParserWithFakeLogger() => new DataParser(new FakeLogger());

        [TestMethod]
        public async Task ParseData_WithMixedData_ReturnsGoodRecords()
        {
            // Arrange
            var logger = new FakeLogger();
            var parser = new DataParser(logger);

            // Act
            var records = await parser.ParseData(TestData.Data);

            // Assert
            Assert.AreEqual(9, records.Count());
        }

        [TestMethod]
        public async Task ParseData_WithGoodRecord_ReturnsOneRecord()
        {
            var parser = GetParserWithFakeLogger();

            var records = await parser.ParseData(TestData.GoodRecord);

            Assert.AreEqual(1, records.Count());
        }

        [TestMethod]
        public async Task ParseData_WithBadRecord_ReturnsZeroRecords()
        {
            var parser = GetParserWithFakeLogger();

            var records = await parser.ParseData(TestData.BadRecord);

            Assert.AreEqual(0, records.Count());
        }

        [TestMethod]
        public async Task ParseData_WithBadStartDate_ReturnsZeroRecords()
        {
            var parser = GetParserWithFakeLogger();

            var records = await parser.ParseData(TestData.BadStartDate);

            Assert.AreEqual(0, records.Count());
        }

        [TestMethod]
        public async Task ParseData_WithBadRating_ReturnsZeroRecords()
        {
            var parser = GetParserWithFakeLogger();

            var records = await parser.ParseData(TestData.BadRating);

            Assert.AreEqual(0, records.Count());
        }
    }
}