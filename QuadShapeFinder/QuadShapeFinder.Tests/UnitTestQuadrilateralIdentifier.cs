using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Serilog;
using QuadShapeFinder.Services.BusinessLogic;
using QuadShapeFinder.Services.BusinessLogic.Enums;
using Moq;
using QuadShapeFinder.Tests.Core;

namespace QuadShapeFinder.Tests
{
    [TestClass]
    public class UnitTestQuadrilateralIdentifier
    {
        private Mock<IQuadrilateral> _quadrilateral;
        private Mock<ILogger> _logger;
        private QuadrilateralBuilder _quadBuilder;

        [TestInitialize]
        public void StartUp()
        {
            _quadrilateral = new Mock<IQuadrilateral>();
            _logger = new Mock<ILogger>();
            _quadBuilder = new QuadrilateralBuilder();
        }


        //#region Test QuadrilateralIdentifier
        //[TestMethod]
        //public void TestQuadrilateralIdentifierReturns()
        //{
        //    //Arrange
        //    IQuadrilateral quad = new Quadrilateral(2, 3, 4, 2, 45, 135, 135, 45);

        //    //Act
        //    var quadIdentifier = new QuadrilateralIdentifier(quad);
        //    var result = quadIdentifier.GetQuadrilateralType();

        //    //Assert
        //    Assert.AreEqual(result, QuadTypeEnum.IsoscelesTrapezoid);
        //}

        //#endregion

        #region Test quadrilateral recognition


        [TestMethod]
        public void TestQuadrilateralIdentifierValid_Sqaure()
        {
            //Arrange
            var quad = _quadBuilder.Build(QuadTypeEnum.Square);

            //Act
            var quadIdentifier = new QuadrilateralIdentifier(quad);
            var result = quadIdentifier.GetQuadrilateralType();

            //Assert
            Assert.AreEqual(result, QuadTypeEnum.Square);
        }

        [TestMethod]
        public void TestQuadrilateralIdentifierValid_Quadrilateral()
        {
            //Arrange
            var quad = _quadBuilder.Build(QuadTypeEnum.Quadrilateral);

            //Act
            var quadIdentifier = new QuadrilateralIdentifier(quad);
            var result = quadIdentifier.GetQuadrilateralType();

            //Assert
            Assert.AreEqual(result, QuadTypeEnum.Quadrilateral);
        }


        [TestMethod]
        public void TestQuadrilateralIdentifierValid_Parallelogram()
        {
            //Arrange
            var quad = _quadBuilder.Build(QuadTypeEnum.Parallelogram);

            //Act
            var quadIdentifier = new QuadrilateralIdentifier(quad);
            var result = quadIdentifier.GetQuadrilateralType();

            //Assert
            Assert.AreEqual(result, QuadTypeEnum.Parallelogram);
        }


        [TestMethod]
        public void TestQuadrilateralIdentifierValid_Trapazoid()
        {
            //Arrange
            var quad = _quadBuilder.Build(QuadTypeEnum.Trapezoid);

            //Act
            var quadIdentifier = new QuadrilateralIdentifier(quad);
            var result = quadIdentifier.GetQuadrilateralType();

            //Assert
            Assert.AreEqual(result, QuadTypeEnum.Trapezoid);
        }


        [TestMethod]
        public void TestQuadrilateralIdentifierValid_IsoscelesTrapazoid()
        {
            //Arrange
            var quad = _quadBuilder.Build(QuadTypeEnum.IsoscelesTrapezoid);

            //Act
            var quadIdentifier = new QuadrilateralIdentifier(quad);
            var result = quadIdentifier.GetQuadrilateralType();

            //Assert
            Assert.AreEqual(result, QuadTypeEnum.IsoscelesTrapezoid);
        }

        [TestMethod]
        public void TestQuadrilateralIdentifierValid_Rectangle()
        {
            //Arrange
            var quad = _quadBuilder.Build(QuadTypeEnum.Rectangle);

            //Act
            var quadIdentifier = new QuadrilateralIdentifier(quad);
            var result = quadIdentifier.GetQuadrilateralType();

            //Assert
            Assert.AreEqual(result, QuadTypeEnum.Rectangle);
        }


        [TestMethod]
        public void TestQuadrilateralIdentifierValid_Rhombus()
        {
            //Arrange
            var quad = _quadBuilder.Build(QuadTypeEnum.Rhombus);

            //Act
            var quadIdentifier = new QuadrilateralIdentifier(quad);
            var result = quadIdentifier.GetQuadrilateralType();

            //Assert
            Assert.AreEqual(result, QuadTypeEnum.Rhombus);
        }


        [TestMethod]
        public void TestQuadrilateralIdentifierValid_Kite()
        {
            //Arrange
            var quad = _quadBuilder.Build(QuadTypeEnum.Kite);

            //Act
            var quadIdentifier = new QuadrilateralIdentifier(quad);
            var result = quadIdentifier.GetQuadrilateralType();

            //Assert
            Assert.AreEqual(result, QuadTypeEnum.Kite);
        }

        #endregion
    }
}
