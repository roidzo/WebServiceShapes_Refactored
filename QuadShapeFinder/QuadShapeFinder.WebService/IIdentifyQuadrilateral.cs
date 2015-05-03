using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

namespace QuadShapeFinder.WebService
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the interface name "IIdentifyQuadrilateral" in both code and config file together.
    [ServiceContract]
    public interface IIdentifyQuadrilateral
    {
        [OperationContract]
        string GetQuadrilateralType(int sideA, int sideB, int sideC, int sideD, int angleAB, int angleBC, int angleCD, int angleDA);
    }
}
