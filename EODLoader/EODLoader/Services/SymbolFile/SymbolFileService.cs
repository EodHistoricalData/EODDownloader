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
