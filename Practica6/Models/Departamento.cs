using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using Microsoft.EntityFrameworkCore;

namespace Practica6.Models
{
    [Keyless]
    public partial class Departamento
    {
        [Column("intId")]
        public int IntId { get; set; }
        [Column("strDepartamento")]
        [StringLength(50)]
        public string? StrDepartamento { get; set; }
    }
}
