using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Anywhere2Go.DataAccess
{
    public class Constant
    {
        public class Format
        {
            public const string ApiDateFormat = "yyyy-MM-dd HH:mm:ss";
        }

        public class MimeType
        {
            public const string PDF = "application/pdf";
            public const string JPEG = "image/jpeg";
            public const string PNG = "image/png";
            public const string MSWORD = "application/msword";
            public const string MSEXCEL = "application/excel";
        }

        public class FileExtension
        {
            public const string Jpg = ".jpg";
            public const string Jpeg = ".jpeg";
            public const string Png = ".png";
            public const string Bmp = ".bmp";
            public const string Pdf = ".pdf";
            public const string Xls = ".xls";
            public const string Xlsx = ".xlsx";
            public const string Doc = ".doc";
            public const string Docx = ".docx";
        }

        public class ServerPath
        {
            public const string Temp = "/TempUpload";
            public const string ImageInspectionPath = "ImageInspection/";
            public const string ImageClaimPath = "ImageClaim/";
            public const string ImageAccount = "/images/accounts/";
        }

        public class WaterMark
        {
            public const string KWatermarkDefaultFileName = "Watermark/watermark_default_v2.png";
        }

        public class Country
        {
            public class Label
            {
                public const string Malaysia = "Malaysia";
                public const string Thailand = "Thailand";
            }

            public class Value
            {
                public const int Thailand = 1001;
                public const int Malaysia = 1002;
            }

            public class Code
            {
                public const string MY = "my";
                public const string TH = "th";
            }
        }

        public class ErrorCode
        {
            public const string DuplicateData = "400";
            public const string Unauthorized = "401";
            public const string ExistingData = "403";
            public const string RequiredData = "405";
            public const string InvalidData = "406";
            public const string WorkflowInvalid = "407";
            public const string AcceptTaskInvalid = "408";
            public const string ForceUpdate = "409";
            public const string SystemError = "500";
            public const string ThirdPartyError = "501";
        }

        public class ErrorMessage
        {
            public const string SystemError = "กรุณาติดต่อผู้ดูแลระบบ";
            public const string DuplicateData = "ข้อมูลซ้ำกรุณากรอกข้อมูลใหม่อีกครั้ง";
            public const string ExistingData = "ไม่พบข้อมูลนี้ในระบบกรุณาลองใหม่อีกครั้ง";
            public const string InvalidData = "ข้อมูลไม่ถูกต้อง";
            public const string Unauthorized = "ไม่สามารถอนุญาติให้ใช้งานในระบบ กรุณารับรองสิทธิ์ก่อนการใช้งาน";
            public const string RequiredData = "กรุณากรอกข้อมูลให้ครบถ้วน";
            public const string WorkflowInvalid = "ลำดับการทำงานไม่ถูกต้อง";
            public const string AcceptTaskInvalid = "ไม่สามารถรับงานได้";
            public const string ForceUpdate = "กรุณาอัพเดทโปรแกรม";
            public const string UnauthorizedTask = "ไม่มีงานนี้ในระบบ";
            public const string noApproveImageTask = "งานนี้ยังไม่ถูกตรวจสอบรูป";
        }

        public class TitleMessage
        {
            public const string AccpetTask = "";
            public const string FinishTask = "ขอขอบคุณเป็นอย่างสูง";
        }

        public class BodyMessage
        {
            public const string AccpetTask = "ท่านสามารถดูงานที่ท่านได้เลือกได้ที่เมนู \"นัดหมาย\" และเลือกแถบเมนูย่อย \"คิวนัดหมายที่รออยู่\" ";
            public const string FinishTask = "ข้อมูลการทำงานของท่านได้ถูกบันทึกเรียบร้อยแล้วท่านสามารถปฏิบัติงานต่อไปได้";
        }

        public class Permission
        {
            public const int SystemAdmin = 1;
            public const int Admin = 100;
            public const int RoleClaimdiBike = 103;

            public const int Claimdi_Member = 2;
            public const int Call_Center = 3;
            public const int Surveyor = 4;
            public const int Guest_Member = 99;
            public const int SurveyorOS = 107;
            public const int Supervisor = 110;
        }

        public class PicturePartCode
        {
            public const string TypeST04 = "PT04";
            public const string TypeOT01 = "PT01";
            public const string TypeOT06 = "PT06";
            public const string TypeDM02 = "PT02";
            public const string TypeDM03 = "PT03";
            public const string TypeDM05 = "PT05";
        }

        public class PictureType
        {
            public const string AroundCar = "PT04";
            public const string Accessory = "PT01";
            public const string InsDoc = "PT06";
            public const string Doc = "PT02";
            public const string Damage = "PT03";
            public const string Sign = "PT05";
        }

        public class ReportConts
        {
            public const string AddressClaimDi = "<strong style='font-size: 11pt;'>บริษัท เอพลัส เคลม เซอร์วิส จำกัด</strong> "
                                + "<br>69/9 ซอยราชวิถี 1 ถนนรางน้ำ แขวงถนนพญาไท"
                                + "<br>เขตราชเทวี กรุงเทพฯ 10400"
                                + "<br>โทร: +66 (0) 2642-4711-2"
                                + "<br>อีเมล: support @anywheretogo.com";

            public const string Sign = "<br /><br />.....................................................<br />"
                        + "ขอแสดงความนับถือ<br />"
                        + "หัวหน้าแผนกอุบัติเหตุรถยนต์<br />"
                        + "บริษัท เอพลัส เคลม เซอร์วิส จำกัด<br />"
                        + "ผู้มีอำนาจลงนาม";
        }

        public class InsurerConfig
        {
            public class Name
            {
                public const string BangkokInsurance = "กรุงเทพประกันภัย จำกัด (มหาชน)";
                public const string ThanachartInsurance = "ธนชาตประกันภัย";
            }

            public class Code
            {
                public const string BKI = "IN0001";
                public const string TNC = "IN0033";
            }
        }
    }
}