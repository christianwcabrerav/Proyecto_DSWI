
//------------------------------------------------------------------------------
// <auto-generated>
//    Este código se generó a partir de una plantilla.
//
//    Los cambios manuales en este archivo pueden causar un comportamiento inesperado de la aplicación.
//    Los cambios manuales en este archivo se sobrescribirán si se regenera el código.
// </auto-generated>
//------------------------------------------------------------------------------


namespace LadoUsuario.Models
{

using System;
    using System.Collections.Generic;
    
public partial class OrderDetail
{

    public int OrderDetailsID { get; set; }

    public int OrderID { get; set; }

    public int ProductID { get; set; }

    public Nullable<decimal> UnitPrice { get; set; }

    public Nullable<int> Quantity { get; set; }

    public Nullable<decimal> Discount { get; set; }

    public Nullable<decimal> TotalAmount { get; set; }

    public Nullable<System.DateTime> OrderDate { get; set; }



    public virtual Order Order { get; set; }

    public virtual Product Product { get; set; }

}

}
