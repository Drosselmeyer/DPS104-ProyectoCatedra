using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClinicaDental.Models
{
    [Table("pacientes")]
    public partial class Paciente
    {
        public Paciente()
        {
            Cita = new HashSet<Cita>();
        }

        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Required]
        [Column("nombre")]
        [StringLength(50)]
        public string Nombre { get; set; }
        [Column("direccion")]
        [StringLength(100)]
        public string Direccion { get; set; }
        [Column("telefono")]
        [StringLength(20)]
        public string Telefono { get; set; }
        [Column("fecha_nacimiento", TypeName = "date")]
        public DateTime? FechaNacimiento { get; set; }
        [Column("fecha_registro", TypeName = "datetime")]
        public DateTime? FechaRegistro { get; set; }

        [InverseProperty("Paciente")]
        public virtual ICollection<Cita> Cita { get; set; }
    }
}
