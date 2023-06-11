using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

#nullable disable

namespace ClinicaDental.Models
{
    [Table("doctores")]
    public partial class Doctore
    {
        public Doctore()
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
        [Column("especialidad")]
        [StringLength(50)]
        public string Especialidad { get; set; }

        [InverseProperty("Doctor")]
        public virtual ICollection<Cita> Cita { get; set; }
    }
}
