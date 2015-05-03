using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Serilog;
using Moq;
using QuadShapeFinder.Services.BusinessLogic;
using QuadShapeFinder.Services.BusinessLogic.Enums;

using QuadShapeFinder.Tests.Core;
using QuadShapeFinder.WebService;
using QuadShapeFinder.Services.Helpers;
using QuadShapeFinder.Services;

namespace QuadShapeFinder.Tests
{
    [TestClass]
    public class UnitTestQuadrilateralService
    {
        private Mock<IIdentifyQuadrilateral> _mockWebService;
        private Mock<IQuadrilateralShapeService> _mockService;
        private Mock<ILogger> _logger;
        private IIdentifyQuadrilateral _webService;

        [TestInitialize]
        public void StartUp()
        {
            _mockService = new Mock<IQuadrilateralShapeService>();
            _logger = new Mock<ILogger>();

            _webService = new IdentifyQuadrilateral(_logger.Object, _mockService.Object);
        }

        [TestMethod]
        public void TestGetQuadrilateralTypeService()
        {
            //Arrange
            //_quadrilateralTypeService.Setup(m => m.GetQuadrilateralType(It.IsAny<int>(),It.IsAny<int>(),It.IsAny<int>(),It.IsAny<int>(),It.IsAny<int>(),It.IsAny<int>(),It.IsAny<int>(),It.IsAny<int>())).Returns(Helper.GetEnumDescription(QuadrilateralTypeEnum.Parallelogram));
            //_quadrilateralService.Setup(m => m.GetQuadrilateralType(It.IsAny<int>(),It.IsAny<int>(),It.IsAny<int>(),It.IsAny<int>(),It.IsAny<int>(),It.IsAny<int>(),It.IsAny<int>(),It.IsAny<int>())).Returns(QuadrilateralTypeEnum.Parallelogram);

            //Act
            var quadFinderService = new QuadrilateralShapeService(_logger.Object);
            var result = quadFinderService.GetQuadrilateralType(1, 1, 1, 1, 2, 2, 2, 2);

            //Assert
            Assert.AreEqual(result, QuadTypeEnum.IsoscelesTrapezoid);
        }
    }
}
