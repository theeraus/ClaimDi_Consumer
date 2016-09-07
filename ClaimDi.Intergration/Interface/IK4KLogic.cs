using ClaimDi.Intergration.APIObject;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClaimDi.Intergration
{
    public interface IK4KLogic
    {
        K4KResult ValidatePolicy(PolicyRequest policy, dynamic service = null);
    }
}