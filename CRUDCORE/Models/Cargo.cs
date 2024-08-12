using System;
using System.Collections.Generic;

namespace CRUDCORE.Models
{
    public partial class Cargo
    {
        public int Idcargo { get; set; }
        public string? Descripcion { get; set; }

        public virtual ICollection<Empleado> Empleados { get; set; }
    }
}
