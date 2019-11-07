using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGEDOC.Negocio
{
   public class Clientes
    {
        // opcion para el procedimiento almacenado.
        private int opc;

        private string nombre_Cliente;
        private string nombre_de_Contacto;
        private int telefono_contacto;
        private string correo_cliente;
        private string detalle_Cliente;
        private string estado_cliente;
        private int idcliente;
        // Get y Set para usar las varibles de la clase.
        public int Opc { get => opc; set => opc = value; }
        public string Nombre_Cliente { get => nombre_Cliente; set => nombre_Cliente = value; }
        public string Nombre_de_Contacto { get => nombre_de_Contacto; set => nombre_de_Contacto = value; }
        public int Telefono_contacto { get => telefono_contacto; set => telefono_contacto = value; }
        public string Correo_cliente { get => correo_cliente; set => correo_cliente = value; }
        public string Detalle_Cliente { get => detalle_Cliente; set => detalle_Cliente = value; }
        public string Estado_cliente { get => estado_cliente; set => estado_cliente = value; }
        public int Idcliente { get => idcliente; set => idcliente = value; }

        // constructores con parametros.
        public Clientes(int opc, string nombre_Cliente, string nombre_de_Contacto, int telefono_contacto, string correo_cliente, string detalle_Cliente, string estado_cliente, int idcliente)
        {
            this.Opc = opc;
            Nombre_Cliente = nombre_Cliente;
            Nombre_de_Contacto = nombre_de_Contacto;
            Telefono_contacto = telefono_contacto;
            Correo_cliente = correo_cliente;
            Detalle_Cliente = detalle_Cliente;
            Estado_cliente = estado_cliente;
           this.idcliente= idcliente;
        }
        // contructores sin parametros.
        public Clientes()
        {
            this.Opc = 0;
            Nombre_Cliente = "";
            Nombre_de_Contacto = "";
            Telefono_contacto = 0;
            Correo_cliente = "";
            Detalle_Cliente = "";
            Estado_cliente = "";
            idcliente = 0;
        }
    }
}
