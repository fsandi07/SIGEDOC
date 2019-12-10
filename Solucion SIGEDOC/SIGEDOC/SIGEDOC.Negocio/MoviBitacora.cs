using System;
namespace SIGEDOC.Negocio
{
    public class MoviBitacora
    {
        private int opc;
        private string accion;
        private string idUsuario;
        private DateTime fecha;
        private string tipo;
        // GET Y SET de las variables
        public int Opc { get => opc; set => opc = value; }
        public string Accion { get => accion; set => accion = value; }
        public string IdUsuario { get => idUsuario; set => idUsuario = value; }
        public DateTime Fecha { get => fecha; set => fecha = value; }
        public string Tipo { get => tipo; set => tipo = value; }
        // Constructor con parametros
        public MoviBitacora(int opc, string accion, string idUsuario, DateTime fecha, string tipo)
        {
            this.opc = opc;
            this.accion = accion;
            this.idUsuario = idUsuario;
            this.fecha = fecha;
            this.tipo = tipo;
        }
        //Constructor  sin parametros
        public MoviBitacora()
        {
            this.opc = 0;
            this.accion = "";
            this.idUsuario = "";
            this.fecha = DateTime.Now;
            this.Tipo = "";
        }
    }
}