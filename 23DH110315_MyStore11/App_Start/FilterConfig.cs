﻿using System.Web;
using System.Web.Mvc;

namespace _23DH110315_MyStore11
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
