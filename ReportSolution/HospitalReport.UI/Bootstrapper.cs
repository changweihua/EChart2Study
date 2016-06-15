using System.Web.Mvc;
using Microsoft.Practices.Unity;
using Unity.Mvc3;
using HospitalReport.IService;
using HospitalReport.IDBAccess;
using HospitalReport.Service;
using HospitalReport.DBAccess.Accesses;
//HospitalReport.DBAccess.Accesses

namespace HospitalReport.UI
{
    public static class Bootstrapper
    {
        public static void Initialise()
        {
            var container = BuildUnityContainer();

            DependencyResolver.SetResolver(new UnityDependencyResolver(container));
        }

        private static IUnityContainer BuildUnityContainer()
        {
            var container = new UnityContainer();

            // register all your components with the container here
            // it is NOT necessary to register your controllers
            container.RegisterType<IDemoService, DemoService>();
            container.RegisterType<IDemoAccess, DemoAccess>();
            // e.g. container.RegisterType<ITestService, TestService>();            

            return container;
        }

        public static T Resolve<T>()
        {
            return DependencyResolver.Current.GetService<T>();
        }
    }
}