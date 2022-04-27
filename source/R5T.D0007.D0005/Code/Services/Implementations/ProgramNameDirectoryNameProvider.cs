using System;
using System.Threading.Tasks;

using R5T.D0005;using R5T.T0064;


namespace R5T.D0007.D0005
{[ServiceImplementationMarker]
    public class ProgramNameDirectoryNameProvider : IProgramNameDirectoryNameProvider,IServiceImplementation
    {
        private IProgramNameProvider ProgramNameProvider { get; }


        public ProgramNameDirectoryNameProvider(IProgramNameProvider programNameProvider)
        {
            this.ProgramNameProvider = programNameProvider;
        }

        public async Task<string> GetProgramNameDirectoryName()
        {
            var programName = await this.ProgramNameProvider.GetProgramNameAsync();

            var programNameDirectoryName = programName; // Assume program name requires no changes to be the program name directory name.
            return programNameDirectoryName;
        }
    }
}
