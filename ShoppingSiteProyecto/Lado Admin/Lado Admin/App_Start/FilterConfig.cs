﻿using System.Web;
using System.Web.Mvc;

namespace Proyecto_Ecom_v01
{
    public class FilterConfig
    {
        public static void RegisterGlobalFilters(GlobalFilterCollection filters)
        {
            filters.Add(new HandleErrorAttribute());
        }
    }
}
