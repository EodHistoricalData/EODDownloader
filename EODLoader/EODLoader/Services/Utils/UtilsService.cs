using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Threading.Tasks;

namespace EODLoader.Services.Utils
{
    public class UtilsService : IUtilsService
    {
        public async Task CreateCVSFile<T>(IEnumerable<T> items, string path, bool isUpdate)
        {
            System.Threading.Thread.CurrentThread.CurrentCulture = new System.Globalization.CultureInfo("en-US");
            Type itemType = typeof(T);
            var props = itemType.GetProperties(BindingFlags.Public | BindingFlags.Instance);

            if (isUpdate)
            {
                using (var writer = new StreamWriter(File.Open(path, FileMode.Append)))
                {
                    writer.WriteLine("");

                    foreach (var item in items)
                    {
                        writer.WriteLine(string.Join(", ", props.Select(p => p.GetValue(item, null))));
                    }
                }
            }
            else
            {
                using (var writer = new StreamWriter(path))
                {
                    writer.WriteLine(string.Join(", ", props.Select(p => p.Name)));

                    foreach (var item in items)
                    {
                        writer.WriteLine(string.Join(", ", props.Select(p => p.GetValue(item, null))));
                    }
                }
            }
        }

        public bool RewriteDateBeforeLoad(string path, ref DateTime? startDate, ref DateTime? endDate)
        {
            //Проверка существует ли файл
            try
            {
                if (CVSFileIsExist(path))
                {
                    //Проверка не пустой ли файл
                    if (new FileInfo(path).Length < 2)
                    {
                        return false;
                    }

                    DateTime dateParse;

                    if (DateTime.TryParse(File.ReadLines(path).Last().Split(',')[0], out dateParse))
                    {
                        startDate = dateParse.AddDays(1);
                    }
                    else
                    {
                        return false;
                    }

                    endDate = DateTime.Now;

                    return true;
                }
                return false;
            }
            catch (Exception ex)
            {
                throw(ex);
            }
        }

        //Существует ли такой CSV
        private bool CVSFileIsExist(string path)
        {
            return File.Exists(path);
        }
    }
}
