using System;
using System.Threading.Tasks;


namespace R5T.D0007
{
    public interface IProgramNameDirectoryNameProvider
    {
        Task<string> GetProgramNameDirectoryName();
    }
}
