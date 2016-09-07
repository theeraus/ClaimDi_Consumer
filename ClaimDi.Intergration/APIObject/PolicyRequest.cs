using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClaimDi.Intergration.APIObject
{
    [DataContract]
    public class PolicyRequest
    {
        [DataMember(Name = "policy_no")]
        public string policyNo { get; set; }

        [DataMember(Name = "policy_effective")]
        public string policyEffective { get; set; }

        [DataMember(Name = "car_license_no")]
        public string carLicenseNo { get; set; }

        [DataMember(Name = "car_license_province")]
        public string carLicenseProvince { get; set; }

        [DataMember(Name = "car_license_province_short")]
        public string carLicenseProvinceShort { get; set; }

        [DataMember(Name = "owner_first_name")]
        public string ownerFirstName { get; set; }

        [DataMember(Name = "owner_last_name")]
        public string ownerLastName { get; set; }

        [DataMember(Name = "owner_mobile_no")]
        public string ownerMobileNo { get; set; }

        [DataMember(Name = "inserer_id")]
        public string InsurerID { get; set; }
    }
}