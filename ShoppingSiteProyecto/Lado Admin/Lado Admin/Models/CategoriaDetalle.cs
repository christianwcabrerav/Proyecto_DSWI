using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.Web.Mvc;

namespace Proyecto_Ecom_v01.Models
{
    public class CategoriaDetalle
    {
        public int CategoryId { get; set; }
        [Required(ErrorMessage = "Nombre de Categoría obligatorio")]
        [StringLength(100, ErrorMessage = "Mínimo 3 y máximo 100 caracteres son permitidos", MinimumLength = 3)]
        public string CategoryName { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDelete { get; set; }
    }

    public class ProductoDetalle    {
        public int ProductId { get; set; }
        [Required(ErrorMessage = "Nombre de Producto es obligatorio")]
        [StringLength(100, ErrorMessage = "Mínimo 3 y máximo 100 caracteres son permitidos", MinimumLength = 3)]
        public string ProductName { get; set; }
        [Required]
        [Range(1, 50)]
        public Nullable<int> CategoryId { get; set; }
        public Nullable<bool> IsActive { get; set; }
        public Nullable<bool> IsDelete { get; set; }
        public Nullable<System.DateTime> CreatedDate { get; set; }
        public Nullable<System.DateTime> ModifiedDate { get; set; }
        [Required(ErrorMessage = "Descripción es obligatorio")]
        public Nullable<System.DateTime> Description { get; set; }
        public string ProductImage { get; set; }
        public Nullable<bool> IsFeatured { get; set; }
        [Required]
        [Range(typeof(int), "1", "500", ErrorMessage = "Cantidad no válida")]
        public Nullable<int> Quantity { get; set; }
        [Required]
        [Range(typeof(decimal), "1", "200000", ErrorMessage = "Precio no válido")]
        public Nullable<decimal> Price { get; set; }
        public SelectList Categories { get; set; }
    }
}