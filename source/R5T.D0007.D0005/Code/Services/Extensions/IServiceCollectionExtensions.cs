using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.D0005;
using R5T.Dacia;


namespace R5T.D0007.D0005
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="ProgramNameDirectoryNameProvider"/> implementation of <see cref="IProgramNameDirectoryNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static IServiceCollection AddD0005ProgramNameDirectoryNameProvider(this IServiceCollection services,
            IServiceAction<IProgramNameProvider> programNameProvider)
        {
            services
                .AddSingleton<IProgramNameDirectoryNameProvider, ProgramNameDirectoryNameProvider>()
                .Run(programNameProvider)
                ;

            return services;
        }

        /// <summary>
        /// Adds the <see cref="ProgramNameDirectoryNameProvider"/> implementation of <see cref="IProgramNameDirectoryNameProvider"/> as a <see cref="ServiceLifetime.Singleton"/>.
        /// </summary>
        public static ServiceAction<IProgramNameDirectoryNameProvider> AddD0005ProgramNameDirectoryNameProviderAction(this IServiceCollection services,
            IServiceAction<IProgramNameProvider> programNameProvider)
        {
            var serviceAction = ServiceAction<IProgramNameDirectoryNameProvider>.New(() => services.AddD0005ProgramNameDirectoryNameProvider(
                programNameProvider));
            return serviceAction;
        }
    }
}
