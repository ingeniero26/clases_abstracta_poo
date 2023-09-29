using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PruebaEmpleado
{
    public class EmpleadoAsalariado: Empleado
    {
        private decimal salarioSemanal;
    

    public EmpleadoAsalariado(string nombre, string apellido, string nss,
        decimal salario) :base(nombre,apellido,nss)
    {
        SalarioSemanal = salario;
    }

        public decimal SalarioSemanal
        {
            get
            {
                return salarioSemanal;
            }
            set
            {
                salarioSemanal = ((value >= 0) ? value : 0);
            }
        }

        public override decimal Ingresos()
        {
            return SalarioSemanal;
        }

        public override string ToString()
        {
            return string.Format("Empleado asalariado: {0}\n{n}: {2:C}",
                base.ToString(), "salario semanal ", SalarioSemanal);
        }

    }

}
