
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
    
public partial class Payment
{

    public Payment()
    {

        this.Orders = new HashSet<Order>();

    }


    public int PaymentID { get; set; }

    public int Type { get; set; }

    public Nullable<decimal> CreditAmount { get; set; }

    public Nullable<decimal> DebitAmount { get; set; }

    public Nullable<decimal> Balance { get; set; }

    public Nullable<System.DateTime> PaymentDateTime { get; set; }



    public virtual ICollection<Order> Orders { get; set; }

    public virtual PaymentType PaymentType { get; set; }

}

}