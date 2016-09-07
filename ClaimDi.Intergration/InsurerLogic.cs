using Autofac;
using ClaimDi.Intergration;
using ClaimDi.Intergration.APIObject;

namespace ClaimDi.Intergration
{
    public class InsurerLogic
    {
        // public IK4KLogic _k4kLogic { get; set; }
        private PolicyRequest _policy;

        private static IContainer _container { get; set; }

        public InsurerLogic(PolicyRequest policy)
        {
            _policy = policy;
            _container = LogicFactory.Components(_policy.InsurerID);
        }

        public K4KResult ValidatePolicy(dynamic service = null)
        {
            var insureFunc = _container.Resolve<IK4KLogic>();
            var objResult = insureFunc.ValidatePolicy(_policy, service);
            return objResult;
        }
    }
}