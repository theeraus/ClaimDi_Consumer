using ClaimDi.Intergration.APIObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimDi.Intergration.Insurer
{
    public class BKILogic : IK4KLogic
    {
        public K4KResult ValidatePolicy(PolicyRequest policy, dynamic service = null)
        {
            var insurerData = service.PolicyValidation(policy.carLicenseNo, policy.carLicenseProvinceShort, policy.ownerFirstName, policy.ownerLastName, policy.ownerMobileNo);
            K4KResult objResult = new K4KResult();
            objResult.result = new Result { message = insurerData.result.message, success = insurerData.result.success };
            objResult.policyResult = new PolicyResult
            {
                policyNo = insurerData.policy.policy_no,
                carLicenseNo = insurerData.policy.car_license_no,
                carLicenseProvince = insurerData.policy.car_license_province,
                ownerFirstName = insurerData.policy.owner_first_name,
                ownerLastName = insurerData.policy.owner_last_name,
                ownerMobileNo = insurerData.policy.owner_mobile_no,
                policyEffective = insurerData.policy.policy_effective,
                policyRiskNo = insurerData.policy.policy_risk_no
            };
            return objResult;
        }
    }
}