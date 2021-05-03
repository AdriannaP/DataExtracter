using System.Collections.Generic;

namespace DataExtractor.Interfaces
{
    public interface IPrinterService
    {
        void WriteToConsole(IEnumerable<IUsersProvider> usersProviders);
    }
}
