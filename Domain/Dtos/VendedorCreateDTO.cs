using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace TostiElotes.Domain.Dtos
{
    public class VendedorCreateDTO
    {
        [Required(ErrorMessage = "El campo Nombre es obligatorio.")]
        public string Nombre { get; set; } = null!;

        [Required(ErrorMessage = "El campo Apellido es obligatorio.")]
        public string Apellido { get; set; } = null!;

        [Required(ErrorMessage = "El campo Telefono es obligatorio.")]
        [StringLength(10, ErrorMessage = "El campo Telefono no puede tener más de 10 caracteres.")]
        [MinLength(10, ErrorMessage = "El Telefono debe tener al menos 10 caracteres.")]
        public string? Telefono { get; set; }

        [Required(ErrorMessage = "El campo CorreoElectronico es obligatorio.")]
        [EmailAddress(ErrorMessage = "El campo CorreoElectronico debe ser una dirección de correo electrónico válida.")]
        public string CorreoElectronico { get; set; } = null!;

        [Required(ErrorMessage = "El campo Contrasena es obligatorio.")]
        [MinLength(8, ErrorMessage = "La contraseña debe tener al menos 8 caracteres.")]
        public string Contraseña { get; set; } = null!;
    }

    public class VendedorDTO
    {
        public int IdVendedor { get; set; }

        public string Nombre { get; set; } = null!;

        public string Apellido { get; set; } = null!;

        public string Telefono { get; set; } = null!;

        public string CorreoElectronico { get; set; } = null!;

        public string Contraseña { get; set; } = null!;
    }
}