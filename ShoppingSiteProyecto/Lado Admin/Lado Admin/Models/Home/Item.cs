using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto_Ecom_v01.DAL;

namespace Proyecto_Ecom_v01.Models.Home
{
    public class Item
    {
        public Tbl_Product Product { get; set; }
        public int Quantity { get; set; }
    }
}
