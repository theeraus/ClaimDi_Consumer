using ClaimDi.Intergration;
using ClaimDi.Intergration.APIObject;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Runtime.Serialization;
using System.Runtime.Serialization.Formatters;
using System.ServiceModel;
using System.ServiceModel.Web;
using System.Text;
using System.Xml;

namespace ClaimDi.WCF.Insurer
{
    // NOTE: You can use the "Rename" command on the "Refactor" menu to change the class name "Service1" in code, svc and config file together.
    // NOTE: In order to launch WCF Test Client for testing this service, please select Service1.svc or Service1.svc.cs at the Solution Explorer and start debugging.
    public class GetApi : IGetApi
    {
        public K4KResult getValue(PolicyRequest parametor_policy)
        {
            try
            {
                //BKI SOAP Service
                BKIService.BKI_KFK API = new BKIService.BKI_KFK();
                InsurerLogic insurer = new InsurerLogic(parametor_policy);

                var objResult = insurer.ValidatePolicy(API);

                return objResult;
            }
            catch (Exception ex)
            {
                throw new WebFaultException<string>(ex.ToString(), HttpStatusCode.InternalServerError);
            }

            return null;
        }
    }
}