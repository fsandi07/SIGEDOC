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
        private string nombre_cliente;
        private string nombre_de_Contacto;
        private int telefono_contacto;
        private string correo_cliente;
        private string detalle_cliente;
        private string estado_cliente;
        
        // Get y Set para usar las varibles de la clase.
        public int Opc { get => opc; set => opc = value; }
        public string Nombre_cliente { get => nombre_cliente; set => nombre_cliente = value; }
        public string Nombre_de_Contacto { get => nombre_de_Contacto; set => nombre_de_Contacto = value; }
        public int Telefono_contacto { get => telefono_contacto; set => telefono_contacto = value; }
        public string Correo_cliente { get => correo_cliente; set => correo_cliente = value; }
        public string Detalle_cliente { get => detalle_cliente; set => detalle_cliente = value; }
        public string Estado_cliente { get => estado_cliente; set => estado_cliente = value; }


        public Clientes(int opc, string nombre_cliente, string nombre_de_Contacto, int telefono_contacto, string correo_cliente, string detalle_cliente, string estado_cliente)
        {
            this.opc = opc;
            this.nombre_cliente = nombre_cliente;
            this.nombre_de_Contacto = nombre_de_Contacto;
            this.telefono_contacto = telefono_contacto;
            this.correo_cliente = correo_cliente;
            this.detalle_cliente = detalle_cliente;
            this.estado_cliente = estado_cliente;
 
        }
        public Clientes()
        {
            this.opc = 0;
            this.nombre_cliente ="" ;
            this.nombre_de_Contacto = "";
            this.telefono_contacto = 0;
            this.correo_cliente = "";
            this.detalle_cliente = "";
            this.estado_cliente = "";
        }
       

    }
}
