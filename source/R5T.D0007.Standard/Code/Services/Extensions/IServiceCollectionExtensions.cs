using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.D0005;
using R5T.D0005.Standard;
using R5T.Dacia;

using R5T.D0007.D0005;


namespace R5T.D0007.Standard
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="IProgramNameDirectoryNameProvider"/> service.
        /// </summary>
        public static IServiceCollection AddProgramNameDirectoryNameProvider(this IServiceCollection services,
            IServiceAction<IProgramNameProvider> programNameProvider)
        {
            services.AddD0005ProgramNameDirectoryNameProvider(
                programNameProvider);

            return services;
        }

        /// <summary>
        /// Adds the <see cref="IProgramNameDirectoryNameProvider"/> service.
        /// </summary>
        public static IServiceCollection AddProgramNameDirectoryNameProvider(this IServiceCollection services)
        {
            services.AddD0005ProgramNameDirectoryNameProvider(
                services.AddProgramNameProviderAction());

            return services;
        }

        /// <summary>
        /// Adds the <see cref="IProgramNameDirectoryNameProvider"/> service.
        /// </summary>
        public static IServiceAction<IProgramNameDirectoryNameProvider> AddProgramNameDirectoryNameProviderAction(this IServiceCollection services,
            IServiceAction<IProgramNameProvider> programNameProvider)
        {
            var serviceAction = ServiceAction<IProgramNameDirectoryNameProvider>.New(() => services.AddProgramNameDirectoryNameProvider(
                programNameProvider));
            return serviceAction;
        }

        /// <summary>
        /// Adds the <see cref="IProgramNameDirectoryNameProvider"/> service.
        /// </summary>
        public static (
            IServiceAction<IProgramNameDirectoryNameProvider> programNameDirectoryNameProviderAction,
            IServiceAction<IProgramNameProvider> programNameProvider) AddProgramNameDirectoryNameProviderAction(this IServiceCollection services)
        {
            var output = (
                programNameDirectoryNameProviderAction: ServiceAction<IProgramNameDirectoryNameProvider>.New(() => services.AddProgramNameDirectoryNameProvider()),
                programNameProvider: ServiceAction<IProgramNameProvider>.AlreadyAdded);
            return output;
        }
    }
}
