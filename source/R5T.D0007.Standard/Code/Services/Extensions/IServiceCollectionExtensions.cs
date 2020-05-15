using System;

using Microsoft.Extensions.DependencyInjection;

using R5T.Dacia;

using R5T.D0007.D0005;


namespace R5T.D0007.Standard
{
    public static class IServiceCollectionExtensions
    {
        /// <summary>
        /// Adds the <see cref="IProgramNameDirectoryNameProvider"/> service.
        /// </summary>
        public static IServiceCollection AddProgramNameDirectoryNameProvider(this IServiceCollection services)
        {
            services.AddD0005ProgramNameDirectoryNameProvider();

            return services;
        }

        /// <summary>
        /// Adds the <see cref="IProgramNameDirectoryNameProvider"/> service.
        /// </summary>
        public static ServiceAction<IProgramNameDirectoryNameProvider> AddProgramNameDirectoryNameProviderAction(this IServiceCollection services)
        {
            var serviceAction = ServiceAction<IProgramNameDirectoryNameProvider>.New(() => services.AddD0005ProgramNameDirectoryNameProvider());
            return serviceAction;
        }
    }
}
