﻿namespace BaseballStat.Web.ViewModels.Category
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class CategoriesListViewModel
    {
        public IEnumerable<CategoryViewModel> Categories { get; set; }
    }
}
