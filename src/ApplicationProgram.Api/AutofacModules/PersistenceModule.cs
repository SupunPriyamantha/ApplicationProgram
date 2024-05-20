using ApplicationProgram.Infrastructure.Repositories;
using Autofac;

namespace ApplicationProgram.Api.AutofacModules
{
    public class PersistenceModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterAssemblyTypes(typeof(ProgramFormRepository).Assembly).AsImplementedInterfaces().InstancePerLifetimeScope();
        }
    }
}
