﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EODLoader.Services.Utils
{
    public interface IUtilsService
    {
        void CreateCVSFile<T>(IEnumerable<T> items, string path);
    }
}
