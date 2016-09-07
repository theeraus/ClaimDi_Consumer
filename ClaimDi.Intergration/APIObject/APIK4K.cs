using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text;
using System.Threading.Tasks;

namespace ClaimDi.Intergration.APIObject
{
    #region K4KReauest

    [DataContract]
    public class K4KRequestData
    {
        [DataMember(Name = "policy_no")]
        public PolicyOwner policyOwner { get; set; }

        [DataMember(Name = "third_party")]
        public ThirdParty thirdParty { get; set; }

        [DataMember(Name = "location")]
        public Location Location { get; set; }
    }

    [DataContract]
    public class PolicyOwner
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

        [DataMember(Name = "driver_first_name")]
        public string driverFirstName { get; set; }

        [DataMember(Name = "driver_last_name")]
        public string driverLastName { get; set; }

        [DataMember(Name = "driver_mobile_no")]
        public string driverMobileNo { get; set; }

        [DataMember(Name = "case_number")]
        public string caseNumber { get; set; }

        [DataMember(Name = "case_result")]
        public string caseResult { get; set; }

        [DataMember(Name = "case_datetime")]
        public DateTime caseDatetime { get; set; }
    }

    [DataContract]
    public class ThirdParty
    {
        [DataMember(Name = "case_number")]
        public string caseNumber { get; set; }

        [DataMember(Name = "policy_no")]
        public string policyNo { get; set; }

        [DataMember(Name = "insurer_code")]
        public string insurerCode { get; set; }

        [DataMember(Name = "insurer_name")]
        public string insurerName { get; set; }

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

        [DataMember(Name = "driver_first_name")]
        public string driverFirstName { get; set; }

        [DataMember(Name = "driver_last_name")]
        public string driverLastName { get; set; }

        [DataMember(Name = "driver_mobile_no")]
        public string driverMobileNo { get; set; }
    }

    [DataContract]
    public class Location
    {
        [DataMember(Name = "case_number")]
        public string caseNumber { get; set; }

        [DataMember(Name = "place")]
        public string place { get; set; }

        [DataMember(Name = "latitude")]
        public string latitude { get; set; }

        [DataMember(Name = "longitude")]
        public string longitude { get; set; }
    }

    #endregion K4KReauest

    #region K4KResult

    [DataContract]
    public class K4KResult
    {
        [DataMember(Name = "result")]
        public Result result { get; set; }

        [DataMember(Name = "policy_result")]
        public PolicyResult policyResult { get; set; }
    }

    public class PolicyResult
    {
        [DataMember(Name = "policy_no")]
        public string policyNo { get; set; }

        [DataMember(Name = "policy_effective")]
        public string policyEffective { get; set; }

        [DataMember(Name = "policy_expire")]
        public string policyExpire { get; set; }

        [DataMember(Name = "policy_risk_no")]
        public string policyRiskNo { get; set; }

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
    }

    public class Result
    {
        [DataMember(Name = "success")]
        public string success { get; set; }

        [DataMember(Name = "message")]
        public string message { get; set; }
    }

    #endregion K4KResult
}