﻿using System.Web;
using System.Web.Mvc;

namespace Pk2_RSUPwapp
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}