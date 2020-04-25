using System;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace EODLoader.Services.Utils
{
    public interface IUtilsService
    {
        Task CreateCVSFile<T>(IEnumerable<T> items, string path, bool isUpdate);
        bool RewriteDateBeforeLoad(string path, ref DateTime? startDate, ref DateTime? endDate);
    }
}
