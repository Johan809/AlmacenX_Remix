using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace AlmacenX_Remix.Models
{
    public class Cliente
    {
        [Key] 
        public int ClienteID { get; set; }
        [Column(TypeName = "varchar(20)")] 
        [Required(ErrorMessage = "Ingrese una Cedula valida")]
        public string Cedula { get; set; }
        [Column(TypeName = "varchar(25)")]
        [DisplayName("Nombre Completo")] 
        public string Nombre { get; set; }
        [Column(TypeName = "varchar(40)")]
        public string Direccion { get; set; }
        [Column(TypeName = "varchar(25)")]
        [DisplayName("Correo Electronico")]
        public string Correo { get; set; }
        [Column(TypeName = "varchar(2)")]
        public string Genero { get; set; }

    }
}
