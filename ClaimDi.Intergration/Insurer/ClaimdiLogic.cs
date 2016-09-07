using ClaimDi.Intergration.APIObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimDi.Intergration.Insurer
{
    public class ClaimdiLogic : IK4KLogic
    {
        public K4KResult ValidatePolicy(PolicyRequest policy, dynamic service = null)
        {
            K4KResult objResult = new K4KResult();
            objResult.policyResult = new PolicyResult
            {
                policyNo = null,
                carLicenseNo = null,
                carLicenseProvince = null,
                ownerFirstName = null,
                ownerLastName = null,
                ownerMobileNo = null,
                policyEffective = null,
                policyRiskNo = null
            };
            objResult.result = new Result
            {
                success = "false",
                message = "ไม่พบข้อมูลกรม"
            };
            return objResult;
        }
    }
}