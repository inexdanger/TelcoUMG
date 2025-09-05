using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaLogica
{
    public class CL_Empleados
    {

        /*
        Gerente
        Supervisor
        Informatica
        Contabilidad
        */
        public double MtdSalarioBase(string TipoEmpleado)
        {
            if (TipoEmpleado == "Gerente") return 45000;
            if (TipoEmpleado == "Supervisor") return 20000;
            if (TipoEmpleado == "Informatica") return 15000;
            if (TipoEmpleado == "Contabilidad") return 9000;
            else
            {
                return 0;
            }
        }

    }
}
