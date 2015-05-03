using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Serilog;
using Autofac;
using QuadShapeFinder.Services.BusinessLogic;
using QuadShapeFinder.Services.BusinessLogic.Enums;

namespace QuadShapeFinder.Services
{
    public class QuadrilateralShapeService : IQuadrilateralShapeService
    {
        private readonly ILogger _logger;


        public QuadrilateralShapeService(ILogger logger)
        {
            _logger = logger;
        }


        public QuadTypeEnum GetQuadrilateralType(double sideA, double sideB, double sideC, double sideD, int angleAB, int angleBC, int angleCD, int angleDA)
        {
            try
            {
                var q = new Quadrilateral(sideA, sideB, sideC, sideD, angleAB, angleBC, angleCD, angleDA);
                var t = new QuadrilateralIdentifier(q);

                return t.GetQuadrilateralType();

            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error finding quadrilateral type.");
                throw;
            }
        }

    }
}
