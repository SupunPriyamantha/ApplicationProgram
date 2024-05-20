using Autofac;
using MediatR;
using System.Reflection;

namespace ApplicationProgram.Api.AutofacModules
{
    public class MediatorModule : Autofac.Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            // Mediator itself.
            builder.RegisterType<Mediator>().As<IMediator>().InstancePerLifetimeScope();

            // Registered all application command and query handlers from here.
            builder.RegisterAssemblyTypes(typeof(Application.Handlers.BaseResponse).GetTypeInfo().Assembly)
                .AsClosedTypesOf(typeof(IRequestHandler<,>));
        }
    }
}
