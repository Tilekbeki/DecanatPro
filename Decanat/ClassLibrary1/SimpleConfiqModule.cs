using DataAccessLayer;
using Model2;
using Ninject.Modules;

namespace SimpleConfiqModuleNamespace
{
    public class SimpleConfiqModule : NinjectModule
    {
        public override void Load()
        {
            //    Bind<IRepository<Student>>().To<EntityFrameworkRepository<Student>>().InSingletonScope();
            Bind<IRepository<Student>>().To<DapperRepository<Student>>().InSingletonScope();



        }
    }
}
