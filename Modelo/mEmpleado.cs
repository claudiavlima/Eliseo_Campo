using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Modelo
{
    class mEmpleado
    {
        public Int32 Id_Emp { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }
        public string Direc_Calle { get; set; }
        public Int32 Direc_Nro { get; set; }
        public string Direc_Ciudad { get; set; }
        public Int32 Telefono { get; set; }
        public string Email { get; set; }
    }
}
