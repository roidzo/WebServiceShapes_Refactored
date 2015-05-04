﻿using System;
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
        private readonly IQuadrilateralIdentifier _quadrilateralIdentifier;


        public QuadrilateralShapeService(ILogger logger, IQuadrilateralIdentifier quadrilateralIdentifier)
        {
            _logger = logger;
            _quadrilateralIdentifier = quadrilateralIdentifier;
        }


        public QuadTypeEnum GetQuadrilateralType(double sideA, double sideB, double sideC, double sideD, int angleAB, int angleBC, int angleCD, int angleDA)
        {
            try
            {
                var q = new Quadrilateral(sideA, sideB, sideC, sideD, angleAB, angleBC, angleCD, angleDA);

                return _quadrilateralIdentifier.GetQuadrilateralType(q);
            }
            catch (Exception ex)
            {
                _logger.Error(ex, "Error finding quadrilateral type.");
                throw;
            }
        }

    }
}
