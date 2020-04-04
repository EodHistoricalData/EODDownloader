using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EODLoader.Services.SymbolFile
{
    public interface ISymbolFileService
    {
        string[] OpenFile(string filePatch);
    }
}
