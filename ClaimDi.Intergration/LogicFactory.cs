using Anywhere2Go.DataAccess;
using Autofac;
using ClaimDi.Intergration.Insurer;

namespace ClaimDi.Intergration
{
    public static class LogicFactory
    {
        public static IContainer Components(string ins_ID = null)
        {
            var builder = new ContainerBuilder();
            switch (ins_ID)
            {
                case Constant.InsurerConfig.Code.BKI:
                    builder.RegisterType<BKILogic>().As<IK4KLogic>();
                    break;

                case Constant.InsurerConfig.Code.TNC:
                    builder.RegisterType<ThanachartLogic>().As<IK4KLogic>();
                    break;

                default:
                    builder.RegisterType<ClaimdiLogic>().As<IK4KLogic>();
                    break;
            }

            return builder.Build();
        }
    }
}