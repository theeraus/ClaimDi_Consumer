using Anywhere2Go.DataAccess;
using System;
using System.Collections.Generic;
using System.Configuration;
using System.Linq;
using System.Text;

namespace ClaimDi.DataAccess.Object
{
    public static class Configurator
    {
        public static void Initialize()
        {
            GetLocalAppConfiguration();
        }

        #region Web.config private field

        private static string _crmSqlConnection;
        private static string _uriserviceBKI;
        private static string _uriserviceTNC;

        #endregion Web.config private field

        #region Web.config public field

        public static string CrmSqlConnection
        {
            get { return _crmSqlConnection; }
        }

        public static string UriServiceBKI
        {
            get { return _uriserviceBKI; }
        }

        public static string UriServiceTNC
        {
            get { return _uriserviceTNC; }
        }

        #endregion Web.config public field

        private static void GetLocalAppConfiguration()
        {
            _crmSqlConnection = ConfigurationManager.AppSettings["SqlConnection"];
            _uriserviceTNC = ConfigurationManager.AppSettings["_uriserviceTNC"];
            _uriserviceBKI = ConfigurationManager.AppSettings["_uriserviceBKI"];
        }

        public static class ContantsPage
        {
            public enum enumPage
            {
                Home = 1,
                Admin = 2,
                Insurer = 3,
                Account = 4,
                Role = 5,
                Permission = 6,
                Company = 7
            };
        }

        public static string SessionUserAuthen = "UserAuthen";
    }
}