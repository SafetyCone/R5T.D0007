using System;
using System.Threading.Tasks;

using R5T.D0005;


namespace R5T.D0007.D0005
{
    public class ProgramNameDirectoryNameProvider : IProgramNameDirectoryNameProvider
    {
        private IProgramNameProvider ProgramNameProvider { get; }


        public ProgramNameDirectoryNameProvider(IProgramNameProvider programNameProvider)
        {
            this.ProgramNameProvider = programNameProvider;
        }

        public async Task<string> GetProgramNameDirectoryNameAsync()
        {
            var programName = await this.ProgramNameProvider.GetProgramNameAsync();

            var programNameDirectoryName = programName; // Assume program name requires no changes to be the program name directory name.
            return programNameDirectoryName;
        }
    }
}
