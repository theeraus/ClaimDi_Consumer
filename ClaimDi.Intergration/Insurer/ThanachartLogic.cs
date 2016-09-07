using ClaimDi.DataAccess.Object;
using ClaimDi.Intergration.APIObject;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;
using System.Web.Script.Serialization;

namespace ClaimDi.Intergration.Insurer
{
    public class ThanachartLogic : IK4KLogic
    {
        public K4KResult ValidatePolicy(PolicyRequest policy, dynamic service = null)
        {
            var json = new JavaScriptSerializer().Serialize(policy);
            K4KResult objResult = new K4KResult();

            string requestUrl = Configurator.UriServiceTNC;
            HttpWebRequest webRequest = WebRequest.Create(requestUrl) as HttpWebRequest;
            webRequest.Method = "POST";
            webRequest.Timeout = 12000;
            webRequest.ContentType = "application/json";
            webRequest.ContentLength = json.Length;
            ServicePointManager.ServerCertificateValidationCallback = delegate { return true; };
            using (var streamWriter = new StreamWriter(webRequest.GetRequestStream()))
            {
                streamWriter.Write(json);
            }

            try
            {
                WebResponse webResponse = webRequest.GetResponse();
                using (Stream webStream = webResponse.GetResponseStream())
                {
                    if (webStream != null)
                    {
                        using (StreamReader responseReader = new StreamReader(webStream))
                        {
                            string response = responseReader.ReadToEnd();
                            JavaScriptSerializer json_serializer = new JavaScriptSerializer();
                            objResult = (K4KResult)json_serializer.DeserializeObject(response);
                            Console.Out.WriteLine(response);
                        }
                    }
                }
            }
            catch (Exception e)
            {
                Console.Out.WriteLine("-----------------");
                Console.Out.WriteLine(e.Message);
            }

            return objResult;
        }
    }
}