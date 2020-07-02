using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Proyecto_Ecom_v01.DAL;
using Proyecto_Ecom_v01.Repositorio;
using System.Data.SqlClient;
using System.Web.Mvc;


namespace Proyecto_Ecom_v01.Models.Home
{
    public class HomeIndexViewModel
    {
        public UnidadDeTrabajoGenerico _unitOfWork = new UnidadDeTrabajoGenerico();
        dbMyOnlineShoppingEntities context = new dbMyOnlineShoppingEntities();
        // public IPagedList<Tbl_Product> ListOfProducts { get; set; }

        public IEnumerable<Tbl_Product> ListOfProducts { get; set; }
        public HomeIndexViewModel CreateModel(string search, int pageSize, int? page)
        {
            SqlParameter[] param = new SqlParameter[]{
                new SqlParameter("@search",search??(object)DBNull.Value)
            };
            //IPagedList<Tbl_Product> data = context.Database.SqlQuery<Tbl_Product>("GetBySearch @search", param).ToList().ToPagedList(page ?? 1, pageSize);
            IEnumerable<Tbl_Product> data = context.Database.SqlQuery<Tbl_Product>("GetBySearch @search", param).ToList();

            return new HomeIndexViewModel
            {
                ListOfProducts = data
            };
        }
        
    }
}