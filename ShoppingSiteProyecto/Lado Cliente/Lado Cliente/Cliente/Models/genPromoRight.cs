
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
    
public partial class genPromoRight
{

    public int PromoRightID { get; set; }

    public int CategoryID { get; set; }

    public string ImageURL { get; set; }

    public string AltText { get; set; }

    public string OfferTag { get; set; }

    public string Title { get; set; }

    public Nullable<bool> isDeleted { get; set; }



    public virtual Category Category { get; set; }

}

}
