using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Semana09
{
    class Alumno
    {
        public string codigo, nombres, apaterno, amaterno, telefono;

        public Alumno(string codigo, string nombres, string apaterno, string amaterno, string telefono)
        {
            this.codigo = codigo;
            this.nombres = nombres;
            this.apaterno = apaterno;
            this.amaterno = amaterno;
            this.telefono = telefono;
        }
    }
}
