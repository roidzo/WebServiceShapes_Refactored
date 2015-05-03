using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;
using Serilog;
using QuadShapeFinder.WebService;
using QuadShapeFinder.Services.Helpers;
using QuadShapeFinder.Services;
using QuadShapeFinder.Services.BusinessLogic.Enums;

namespace QuadShapeFinder.Tests
{
    [TestClass]
    public class UnitTestEndToEnd
    {
        private Mock<ILogger> _logger;
        private QuadShapeFinder.WebService.IIdentifyQuadrilateral _webService;

        [TestInitialize]
        public void StartUp()
        {
            _logger = new Mock<ILogger>();
            _webService = new IdentifyQuadrilateral(_logger.Object, new QuadrilateralShapeService(_logger.Object));
        }


        [TestMethod]
        public void TestEndToEndParallelogram()
        {
            //Arrange

            //Act
            var result = _webService.GetQuadrilateralType(2, 3, 2, 3, 45, 135, 45, 135);

            //Assert
            Assert.AreEqual(result, EnumHelper.GetEnumDescription(QuadTypeEnum.Parallelogram));
        }
    }
}
