using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EODLoader.Services.SymbolFile
{
    public class SymbolFileService : ISymbolFileService
    {
        public string[] OpenFile(string filePatch)
        {
            string fileText = System.IO.File.ReadAllText(filePatch);

            fileText = fileText.Replace(" ", string.Empty);

            fileText = fileText.Trim(',');

            if (fileText.Contains("\r\n"))
            {
                fileText = fileText.Replace("\r\n", ",");
            }

            return fileText.Split(',');
        }
    }
}
