﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WoodCarvingCamp.Services.Data.Interfaces
{
    public interface ICategoryService
    {
        Task<IEnumerable<string>> AllCategoryNamesAsync();
    }
}
