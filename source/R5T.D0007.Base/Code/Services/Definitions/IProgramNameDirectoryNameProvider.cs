using System;
using System.Threading.Tasks;

using R5T.T0064;


namespace R5T.D0007
{
    [ServiceDefinitionMarker]
    public interface IProgramNameDirectoryNameProvider : IServiceDefinition
    {
        Task<string> GetProgramNameDirectoryName();
    }
}
