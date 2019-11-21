using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGEDOC.Negocio
{
    public class Permisos
    {
        // opcion para el procedimiento almacenado;
        private int opc;
        private int estado_rol;
        private string nombre_rol;  
        private string detalle_rol;
        private string consultar_cliente;
        private string crear_cliente;
        private string crear_documento;
        private string subir_documento;
        private string consultar_documento;
        private string usuarios;
        private string roles;
        private string bitacora;
        private string reportes_auditoria;
        private string reportes_de_movimientos;
        private string reportes_de_proyectos;
        private string nombre_permiso;
        private int opcconsultar_cliente;
        private int opccrear_cliente;
        private int opccrear_documento;
        private int opcsubir_documento;
        private int opcusuarios;
        private int opcroles;
        private int opcbitacora;
        private int opcreportes_auditoria;
        private int opcreportes_de_movimientos;
        private int opcreportes_de_proyectos;
        private int id_rol;
        private int opcconsultar_documento;

        // creacion de set y get para el uso de las variables.
        public int Opc { get => opc; set => opc = value; }
        public int Estado_rol { get => estado_rol; set => estado_rol = value; }
        public string Nombre_rol { get => nombre_rol; set => nombre_rol = value; }
        public string Detalle_rol { get => detalle_rol; set => detalle_rol = value; }
        public string Consultar_cliente { get => consultar_cliente; set => consultar_cliente = value; }
        public string Crear_cliente { get => crear_cliente; set => crear_cliente = value; }
        public string Crear_documento { get => crear_documento; set => crear_documento = value; }
        public string Subir_documento { get => subir_documento; set => subir_documento = value; }
        public string Consultar_documento { get => consultar_documento; set => consultar_documento = value; }
        public string Usuarios { get => usuarios; set => usuarios = value; }
        public string Roles { get => roles; set => roles = value; }
        public string Bitacora { get => bitacora; set => bitacora = value; }
        public string Reportes_auditoria { get => reportes_auditoria; set => reportes_auditoria = value; }
        public string Reportes_de_movimientos { get => reportes_de_movimientos; set => reportes_de_movimientos = value; }
        public string Reportes_de_proyectos { get => reportes_de_proyectos; set => reportes_de_proyectos = value; }
        public int Opcconsultar_cliente { get => opcconsultar_cliente; set => opcconsultar_cliente = value; }
        public int Opccrear_cliente { get => opccrear_cliente; set => opccrear_cliente = value; }
        public int Opccrear_documento { get => opccrear_documento; set => opccrear_documento = value; }
        public int Opcsubir_documento { get => opcsubir_documento; set => opcsubir_documento = value; }
        public int Opcusuarios { get => opcusuarios; set => opcusuarios = value; }
        public int Opcroles { get => opcroles; set => opcroles = value; }
        public int Opcbitacora { get => opcbitacora; set => opcbitacora = value; }
        public int Opcreportes_auditoria { get => opcreportes_auditoria; set => opcreportes_auditoria = value; }
        public int Opcreportes_de_movimientos { get => opcreportes_de_movimientos; set => opcreportes_de_movimientos = value; }
        public int Opcreportes_de_proyectos { get => opcreportes_de_proyectos; set => opcreportes_de_proyectos = value; }
        public int Id_rol { get => id_rol; set => id_rol = value; }
        public int Opcconsultar_documento { get => opcconsultar_documento; set => opcconsultar_documento = value; }
        public string Nombre_permiso { get => nombre_permiso; set => nombre_permiso = value; }

        // contructor con parametros
        public Permisos(int opc, int estado_rol, string nombre_rol, string detalle_rol, string consultar_cliente, string crear_cliente,
            string crear_documento, string subir_documento, string consultar_documento, string usuarios, string roles, string bitacora,
            string reportes_auditoria, string reportes_de_movimientos, string reportes_de_proyectos, int opcconsultar_cliente,
            int opccrear_cliente, int opccrear_documento, int opcsubir_documento, int opcusuarios, int opcroles, int opcbitacora,
            int opcreportes_auditoria, int opcreportes_de_movimientos, int opcreportes_de_proyectos, int id_rol,int opcconsultar_documento,
            string nombre_permiso)
        {
            this.opc = opc;
            this.estado_rol = estado_rol;
            this.nombre_rol = nombre_rol;
            this.detalle_rol = detalle_rol;
            this.consultar_cliente = consultar_cliente;
            this.crear_cliente = crear_cliente;
            this.crear_documento = crear_documento;
            this.subir_documento = subir_documento;
            this.consultar_documento = consultar_documento;
            this.usuarios = usuarios;
            this.roles = roles;
            this.bitacora = bitacora;
            this.reportes_auditoria = reportes_auditoria;
            this.reportes_de_movimientos = reportes_de_movimientos;
            this.reportes_de_proyectos = reportes_de_proyectos;
            this.opcconsultar_cliente = opcconsultar_cliente;
            this.opccrear_cliente = opccrear_cliente;
            this.opccrear_documento = opccrear_documento;
            this.opcsubir_documento = opcsubir_documento;
            this.opcusuarios = opcusuarios;
            this.opcroles = opcroles;
            this.opcbitacora = opcbitacora;
            this.opcreportes_auditoria = opcreportes_auditoria;
            this.opcreportes_de_movimientos = opcreportes_de_movimientos;
            this.opcreportes_de_proyectos = opcreportes_de_proyectos;
            this.id_rol = id_rol;
            this.opcconsultar_documento = opcconsultar_documento;
            this.nombre_permiso = nombre_permiso;
        }
        // contructor sin parametros
        public Permisos()
        {
            this.opc = 0;
            this.estado_rol = 0;
            this.nombre_rol = "";
            this.detalle_rol = "";
            this.consultar_cliente = "";
            this.crear_cliente = "";
            this.crear_documento = "";
            this.subir_documento = "";
            this.consultar_documento = "";
            this.usuarios = "";
            this.roles = "";
            this.bitacora = "";
            this.reportes_auditoria = "";
            this.reportes_de_movimientos = "";
            this.reportes_de_proyectos = "";
            this.opcconsultar_cliente =0;
            this.opccrear_cliente = 0;
            this.opccrear_documento = 0;
            this.opcsubir_documento = 0;
            this.opcusuarios = 0;
            this.opcroles = 0;
            this.opcbitacora = 0;
            this.opcreportes_auditoria = 0;
            this.opcreportes_de_movimientos = 0;
            this.opcreportes_de_proyectos = 0;
            this.id_rol = 0;
            this.opcconsultar_documento = 0;
            this.nombre_permiso = "";
        }



    }
}
