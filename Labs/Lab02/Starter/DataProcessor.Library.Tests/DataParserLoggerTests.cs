﻿using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using System.Threading.Tasks;

namespace DataProcessor.Library.Tests
{
    [TestClass]
    public class DataParserLoggerTests
    {
        [TestMethod]
        public void ParseData_WithBadRecord_LoggerIsCalledOnce()
        {
            // Arrange
            var mockLogger = new Mock<ILogger>();
            var parser = new DataParser(mockLogger.Object);

            // Act
            parser.ParseData(TestData.BadRecord);

            // Assert
            mockLogger.Verify(m =>
                m.LogMessage(It.IsAny<string>(), TestData.BadRecord[0]),
                Times.Once());
        }

        [TestMethod]
        public void ParseData_WithGoodRecord_LoggerIsNotCalled()
        {
            var mockLogger = new Mock<ILogger>();
            var parser = new DataParser(mockLogger.Object);

            parser.ParseData(TestData.GoodRecord);

            mockLogger.Verify(m =>
                m.LogMessage(It.IsAny<string>(), TestData.GoodRecord[0]),
                Times.Never());
        }

        [TestMethod]
        public void ParseData_WithBadStartDate_LoggerIsCalledOnce()
        {
            var mockLogger = new Mock<ILogger>();
            var parser = new DataParser(mockLogger.Object);

            parser .ParseData(TestData.BadStartDate);

            mockLogger.Verify(m =>
                m.LogMessage(It.IsAny<string>(), TestData.BadStartDate[0]),
                Times.Once());
        }

        [TestMethod]
        public void ParseData_WithBadRating_LoggerIsCalledOnce()
        {
            var mockLogger = new Mock<ILogger>();
            var parser = new DataParser(mockLogger.Object);

            parser.ParseData(TestData.BadRating);

            mockLogger.Verify(m =>
                m.LogMessage(It.IsAny<string>(), TestData.BadRating[0]),
                Times.Once());
        }
    }
}
