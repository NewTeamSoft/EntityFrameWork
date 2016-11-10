using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BussinesEntity
{
    public  class AlumnoDto
    {
        public int i_IdPersona { get; set; }
        public string v_NombresApellidos { get; set; }
        public string v_DNI { get; set; }
        public string v_Direccion { get; set; }
        public Nullable<System.DateTime> t_FechaNacimiento { get; set; }
        public string v_Telefono { get; set; }
    }
}
