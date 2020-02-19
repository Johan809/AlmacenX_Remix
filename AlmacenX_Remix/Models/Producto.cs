using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AlmacenX_Remix.Models
{
    public class Producto
    {
        [Key] 
        public int ProductID { get; set; }

        [Column(TypeName = "varchar(30)")]
        [Required(ErrorMessage = "Este campo es obligatorio")]
        [DisplayName("Nombre Producto")]
        public string NombreProduct { get; set; }

        [Column(TypeName = "varchar(50)")]
        public string Descripcion { get; set; }

        [Column(TypeName = "int")]
        [DisplayName("Cantidad en Stock")]
        public int stock { get; set; }

        [Column(TypeName = "int")]
        [DisplayName("Precio Producto")]
        public int PrecioProd { get; set; }
    }
}
