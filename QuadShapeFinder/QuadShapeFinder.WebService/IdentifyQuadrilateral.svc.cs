using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;
using Serilog;
using QuadShapeFinder.Services;
using QuadShapeFinder.Services.Infrastructure;
using QuadShapeFinder.Services.Helpers;


namespace QuadShapeFinder.WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "IdentifyQuadrilateral" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select IdentifyQuadrilateral.svc or IdentifyQuadrilateral.svc.cs at the Solution Explorer and start debugging.
    public class IdentifyQuadrilateral : IIdentifyQuadrilateral
    {
        private readonly ILogger _logger;
        private readonly IQuadrilateralShapeService _quadrilateralService;

        public IdentifyQuadrilateral(ILogger logger, IQuadrilateralShapeService quadrilateralService)
        {
            _logger = logger;
            _quadrilateralService = quadrilateralService;
        }


        public string GetQuadrilateralType(int sideA, int sideB, int sideC, int sideD, int angleAB, int angleBC, int angleCD, int angleDA)
        {
            return EnumHelper.GetEnumDescription(_quadrilateralService.GetQuadrilateralType(sideA, sideB, sideC, sideD, angleAB, angleBC, angleCD, angleDA));
        }
     
    }
}
