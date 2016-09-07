using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimDi.Intergration.APIObject
{
    public class APIK4K
    {
        public int userID { get; set; }
        public string firstName { get; set; }
        public string LastName { get; set; }
        public string picture { get; set; }
        public string location { get; set; }
        public string latitude { get; set; }
        public string longitude { get; set; }
        public Guid token { get; set; }
        public DateTime updateDate { get; set; }
        public string carInfo { get; set; }
    }
}