
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
    
public partial class admin_Login
{

    public int LoginID { get; set; }

    public int EmpID { get; set; }

    public string UserName { get; set; }

    public string Password { get; set; }

    public Nullable<int> RoleType { get; set; }

    public string Notes { get; set; }



    public virtual admin_Employee admin_Employee { get; set; }

    public virtual Role Role { get; set; }

}

}
