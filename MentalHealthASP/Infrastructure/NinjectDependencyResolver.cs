using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using Ninject;
using MentalHealthASP.Abstract;
using MentalHealthASP.Models;
using MentalHealthASP.Concrete;


namespace MentalHealthASP.Infrastructure
{
    public class NinjectDependencyResolver : IDependencyResolver
    {
        private IKernel kernel;

        public NinjectDependencyResolver(IKernel kernelParam)
        {
            kernel = kernelParam;
            AddBindings();
        }

        public object GetService(Type serviceType)
        {
            return kernel.TryGet(serviceType);
        }

        public IEnumerable<object> GetServices(Type serviceType)
        {
            return kernel.GetAll(serviceType);
        }

        private void AddBindings()
        {

            kernel.Bind<IAnxietyRepository>().To<EFAnxietyRepository>();
            kernel.Bind<IDepressionRepository>().To<EFDepressionRepository>();

        }

        private static void RegisterServices(IKernel kernel)
        {
            System.Web.Mvc.DependencyResolver.SetResolver(new MentalHealthASP.Infrastructure.NinjectDependencyResolver(kernel));
        }
    }
}