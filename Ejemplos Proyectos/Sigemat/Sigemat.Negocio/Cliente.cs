using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// Esta es una extructura Normal de una clase, en este caso del cliente.
namespace Progra6.Negocio
{
    public class Cliente // clase cliente son sus atributos
    {
        private int opc;
        private string nombre;
        private string apellido;
        private string direccion;
        private string identificacion;
        private string email;
        private decimal salario;
        private decimal aporte;

        public int Opc { get => opc; set => opc = value; } // GET Y SET
        public string Nombre { get => nombre; set => nombre = value; }
        public string Apellido { get => apellido; set => apellido = value; }
        public string Direccion { get => direccion; set => direccion = value; }
        public string Identificacion { get => identificacion; set => identificacion = value; }
        public string Email { get => email; set => email = value; }
        public decimal Salario { get => salario; set => salario = value; }
        public decimal Aporte { get => aporte; set => aporte = value; }

        public Cliente(int opc, string nombre, string apellido, string direccion, string identificacion,
                       string email, decimal salario, decimal aporte) // Constructor conm Parametros
        {
            this.opc = opc;
            Nombre = nombre;
            Apellido = apellido;
            Direccion = direccion;
            Identificacion = identificacion;
            Email = email;
            Salario = salario;
            Aporte = aporte;
        }
        public Cliente() // Constructor Sin parametros
        {
            this.opc = 0;
            Nombre = "";
            Apellido = "";
            Direccion = "";
            Identificacion = "";
            Email = "";
            Salario = 0;
            Aporte = 0;
        }
                     
        
    }
}
