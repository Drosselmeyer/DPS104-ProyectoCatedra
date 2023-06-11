using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClinicaDental.Models
{
    [Table("citas")]
    public partial class Cita
    {
        [Key]
        [Column("id")]
        public int Id { get; set; }
        [Column("paciente_id")]
        public int PacienteId { get; set; }
        [Column("doctor_id")]
        public int DoctorId { get; set; }
        [Column("fecha_hora", TypeName = "datetime")]
        public DateTime FechaHora { get; set; }
        [Column("observaciones", TypeName = "text")]
        public string Observaciones { get; set; }

        [ForeignKey(nameof(DoctorId))]
        [InverseProperty(nameof(Doctore.Cita))]
        public virtual Doctore Doctor { get; set; }
        [ForeignKey(nameof(PacienteId))]
        [InverseProperty("Cita")]
        public virtual Paciente Paciente { get; set; }
    }
}
