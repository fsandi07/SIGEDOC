using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGEDOC.Negocio
{
    public class Proyectos
    {
        // opcion para los procedimientos almacenados.
        private int opc;

        private string nombre_Proyecto;
        private int centro_costos;
        private string numero_Licitacion;
        private string detalle_del_proyecto;
        private int id_cliente;
        private string usuario;
        private string estado_Proyecto;
        private DateTime fecha_Proyecto;
        private string status_proyecto;

        public int Opc { get => opc; set => opc = value; }
        public string Nombre_Proyecto { get => nombre_Proyecto; set => nombre_Proyecto = value; }
        public string Numero_Licitacion { get => numero_Licitacion; set => numero_Licitacion = value; }
        public string Detalle_del_proyecto { get => detalle_del_proyecto; set => detalle_del_proyecto = value; }
        public int Id_cliente { get => id_cliente; set => id_cliente = value; }
        public string Usuario { get => usuario; set => usuario = value; }
        public string Estado_Proyecto { get => estado_Proyecto; set => estado_Proyecto = value; }
        public DateTime Fecha_Proyecto { get => fecha_Proyecto; set => fecha_Proyecto = value; }
        public string Status_proyecto { get => status_proyecto; set => status_proyecto = value; }
        public int Centro_costos { get => centro_costos; set => centro_costos = value; }

        public Proyectos(int opc, string nombre_Proyecto, string numero_Licitacion, string detalle_del_proyecto, int id_cliente, string usuario, string estado_Proyecto, DateTime fecha_Proyecto, string status_proyecto, int centro_costos)
        {
            this.Opc = opc;
            Nombre_Proyecto = nombre_Proyecto;
            Numero_Licitacion = numero_Licitacion;
            Detalle_del_proyecto = detalle_del_proyecto;
            this.Id_cliente = id_cliente;
            Usuario = usuario;
            this.Estado_Proyecto = estado_Proyecto;
            this.Fecha_Proyecto = fecha_Proyecto;
            this.Status_proyecto = status_proyecto;
            Centro_costos = centro_costos;
        }
        public Proyectos()
        {
            this.Opc = 0;
            Nombre_Proyecto = "";
            Numero_Licitacion = "";
            Detalle_del_proyecto = "";
            this.Id_cliente = 0;
            Usuario = "";
            this.Estado_Proyecto = "";
            this.Fecha_Proyecto = DateTime.Today;
            this.Status_proyecto = "";
            Centro_costos = 0;
        }
    }
}
