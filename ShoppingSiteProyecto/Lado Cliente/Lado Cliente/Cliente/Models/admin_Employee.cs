
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
    
public partial class admin_Employee
{

    public admin_Employee()
    {

        this.admin_Login = new HashSet<admin_Login>();

    }


    public int EmpID { get; set; }

    public string FirstName { get; set; }

    public string LastName { get; set; }

    public Nullable<int> Age { get; set; }

    public Nullable<System.DateTime> DateofBirth { get; set; }

    public string Gender { get; set; }

    public string Email { get; set; }

    public string Address { get; set; }

    public string Phone { get; set; }

    public string Mobile { get; set; }

    public string PhotoPath { get; set; }



    public virtual ICollection<admin_Login> admin_Login { get; set; }

}

}
