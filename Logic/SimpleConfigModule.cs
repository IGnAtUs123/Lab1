using bus;
using DataAccessLayer;
using Ninject.Modules;

namespace Logic
{
    public class SimpleConfigModule : NinjectModule
    {
        public override void Load()
        {
            // EF как Singleton
            Bind<AppDbContext>().ToSelf().InSingletonScope();
            Bind<IRepository<Student>>().To<EfRepository>().InSingletonScope();

            // Для переключения на Dapper:
            // Bind<IRepository<Student>>().To<DapperRepository>().InSingletonScope();
        }
    }
}
