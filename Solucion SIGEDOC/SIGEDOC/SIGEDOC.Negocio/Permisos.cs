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
        //Roles
        private int opc;
        private int estado_rol;
        private string nombre_rol;  
        private string detalle_rol;
        private int idRol;
        //Permisos
        private string Nom_Per;
        //clientes
        private string consultar_cliente;
        private string crear_cliente;
        private string modificar_cliente;
        //proyectos
        private string crear_proyecto;
        private string consultar_proyecto;
        private string modificar_proyecto;
        //usuarios
        private string agreagr_usuario;
        private string consultar_usuario;
        private string modificar_usuario;
        //Documentos Creados
        private string crear_documento;
        private string consultar_documento;
        private string modificar_documento;
        //Documentos Subidos
        private string subir_documento;
        private string consultar_documento_subido;
        private string modificar_documento_subido;
        //Roles
        private string crear_rol;
        private string modificar_rol;
        private string consultar_rol;
        //bitacora
        private string bitacora;
        // reportes
        private string reportes_auditoria;
        private string reportes_de_movimientos;
        private string reportes_de_proyectos;
        // estados en enteros de cada uno habilitados o no (0 o 1)
        //clientes
        private int opcconsultar_cliente;
        private int opccrear_cliente;
        private int opcmodificar_cliente;
        //proyectos
        private int opcconsultar_proyecto;
        private int opccrear_proyecto;
        private int opcmodificar_proyecto;
        //usuarios
        private int opcconsultar_usuario;
        private int opccrear_usuario;
        private int opcmodificar_usuario;
        //Documentos Creados
        private int opcconsultar_doc_creado;
        private int opccrear_doc_creado;
        private int opcmodificar_doc_creado;
        //Documentos Subidos
        private int opcconsultar_doc_subido;
        private int opccrear_doc_subido;
        private int opcmodificar_doc_subido;
        //Roles
        private int opcconsultar_rol;
        private int opccrear_rol;
        private int opcmodificar_rol;
        //bitacora
        private int opcbitacora;
        // reportes
        private int opcconsultar_repo_audi;
        private int opccrear_repo_movi;
        private int opcmodificar_repo_proye;

      
        // creacion de set y get para el uso de las variables.
        public int Opc { get => opc; set => opc = value; }
        public int Estado_rol { get => estado_rol; set => estado_rol = value; }
        public string Nombre_rol { get => nombre_rol; set => nombre_rol = value; }
        public string Detalle_rol { get => detalle_rol; set => detalle_rol = value; }
        public string Consultar_cliente { get => consultar_cliente; set => consultar_cliente = value; }
        public string Crear_cliente { get => crear_cliente; set => crear_cliente = value; }
        public string Modificar_cliente { get => modificar_cliente; set => modificar_cliente = value; }
        public string Crear_proyecto { get => crear_proyecto; set => crear_proyecto = value; }
        public string Consultar_proyecto { get => consultar_proyecto; set => consultar_proyecto = value; }
        public string Modificar_proyecto { get => modificar_proyecto; set => modificar_proyecto = value; }
        public string Agreagr_usuario { get => agreagr_usuario; set => agreagr_usuario = value; }
        public string Consultar_usuario { get => consultar_usuario; set => consultar_usuario = value; }
        public string Modificar_usuario { get => modificar_usuario; set => modificar_usuario = value; }
        public string Crear_documento { get => crear_documento; set => crear_documento = value; }
        public string Consultar_documento { get => consultar_documento; set => consultar_documento = value; }
        public string Modificar_documento { get => modificar_documento; set => modificar_documento = value; }
        public string Subir_documento { get => subir_documento; set => subir_documento = value; }
        public string Consultar_documento_subido { get => consultar_documento_subido; set => consultar_documento_subido = value; }
        public string Modificar_documento_subido { get => modificar_documento_subido; set => modificar_documento_subido = value; }
        public string Crear_rol { get => crear_rol; set => crear_rol = value; }
        public string Modificar_rol { get => modificar_rol; set => modificar_rol = value; }
        public string Consultar_rol { get => consultar_rol; set => consultar_rol = value; }
        public string Bitacora { get => bitacora; set => bitacora = value; }
        public string Reportes_auditoria { get => reportes_auditoria; set => reportes_auditoria = value; }
        public string Reportes_de_movimientos { get => reportes_de_movimientos; set => reportes_de_movimientos = value; }
        public string Reportes_de_proyectos { get => reportes_de_proyectos; set => reportes_de_proyectos = value; }
        public int Opcconsultar_cliente { get => opcconsultar_cliente; set => opcconsultar_cliente = value; }
        public int Opccrear_cliente { get => opccrear_cliente; set => opccrear_cliente = value; }
        public int Opcmodificar_cliente { get => opcmodificar_cliente; set => opcmodificar_cliente = value; }
        public int Opcconsultar_proyecto { get => opcconsultar_proyecto; set => opcconsultar_proyecto = value; }
        public int Opccrear_proyecto { get => opccrear_proyecto; set => opccrear_proyecto = value; }
        public int Opcmodificar_proyecto { get => opcmodificar_proyecto; set => opcmodificar_proyecto = value; }
        public int Opcconsultar_usuario { get => opcconsultar_usuario; set => opcconsultar_usuario = value; }
        public int Opccrear_usuario { get => opccrear_usuario; set => opccrear_usuario = value; }
        public int Opcmodificar_usuario { get => opcmodificar_usuario; set => opcmodificar_usuario = value; }
        public int Opcconsultar_doc_creado { get => opcconsultar_doc_creado; set => opcconsultar_doc_creado = value; }
        public int Opccrear_doc_creado { get => opccrear_doc_creado; set => opccrear_doc_creado = value; }
        public int Opcmodificar_doc_creado { get => opcmodificar_doc_creado; set => opcmodificar_doc_creado = value; }
        public int Opcconsultar_doc_subido { get => opcconsultar_doc_subido; set => opcconsultar_doc_subido = value; }
        public int Opccrear_doc_subido { get => opccrear_doc_subido; set => opccrear_doc_subido = value; }
        public int Opcmodificar_doc_subido { get => opcmodificar_doc_subido; set => opcmodificar_doc_subido = value; }
        public int Opcconsultar_rol { get => opcconsultar_rol; set => opcconsultar_rol = value; }
        public int Opccrear_rol { get => opccrear_rol; set => opccrear_rol = value; }
        public int Opcmodificar_rol { get => opcmodificar_rol; set => opcmodificar_rol = value; }
        public int Opcbitacora { get => opcbitacora; set => opcbitacora = value; }
        public int Opcconsultar_repo_audi { get => opcconsultar_repo_audi; set => opcconsultar_repo_audi = value; }
        public int Opccrear_repo_movi { get => opccrear_repo_movi; set => opccrear_repo_movi = value; }
        public int Opcmodificar_repo_proye { get => opcmodificar_repo_proye; set => opcmodificar_repo_proye = value; }
        public int IdRol { get => idRol; set => idRol = value; }
        public string Nom_Per1 { get => Nom_Per; set => Nom_Per = value; }




        // creacion de los construtores con parametros.

        public Permisos(int opc, int estado_rol, string nombre_rol, string detalle_rol, string consultar_cliente, string crear_cliente,
           string modificar_cliente, string crear_proyecto, string consultar_proyecto, string modificar_proyecto, string agreagr_usuario,
           string consultar_usuario, string modificar_usuario, string crear_documento, string consultar_documento,
           string modificar_documento, string subir_documento, string consultar_documento_subido, string modificar_documento_subido,
           string crear_rol, string modificar_rol, string consultar_rol, string bitacora, string reportes_auditoria,
           string reportes_de_movimientos, string reportes_de_proyectos, int opcconsultar_cliente, int opccrear_cliente,
           int opcmodificar_cliente, int opcconsultar_proyecto, int opccrear_proyecto, int opcmodificar_proyecto, int opcconsultar_usuario,
           int opccrear_usuario, int opcmodificar_usuario, int opcconsultar_doc_creado, int opccrear_doc_creado,
           int opcmodificar_doc_creado, int opcconsultar_doc_subido, int opccrear_doc_subido, int opcmodificar_doc_subido,
           int opcconsultar_rol, int opccrear_rol, int opcmodificar_rol, int opcbitacora, int opcconsultar_repo_audi,
           int opccrear_repo_movi, int opcmodificar_repo_proye, int idRol, string nom_Per)
        {
            this.opc = opc;
            this.estado_rol = estado_rol;
            this.nombre_rol = nombre_rol;
            this.detalle_rol = detalle_rol;
            this.consultar_cliente = consultar_cliente;
            this.crear_cliente = crear_cliente;
            this.modificar_cliente = modificar_cliente;
            this.crear_proyecto = crear_proyecto;
            this.consultar_proyecto = consultar_proyecto;
            this.modificar_proyecto = modificar_proyecto;
            this.agreagr_usuario = agreagr_usuario;
            this.consultar_usuario = consultar_usuario;
            this.modificar_usuario = modificar_usuario;
            this.crear_documento = crear_documento;
            this.consultar_documento = consultar_documento;
            this.modificar_documento = modificar_documento;
            this.subir_documento = subir_documento;
            this.consultar_documento_subido = consultar_documento_subido;
            this.modificar_documento_subido = modificar_documento_subido;
            this.crear_rol = crear_rol;
            this.modificar_rol = modificar_rol;
            this.consultar_rol = consultar_rol;
            this.bitacora = bitacora;
            this.reportes_auditoria = reportes_auditoria;
            this.reportes_de_movimientos = reportes_de_movimientos;
            this.reportes_de_proyectos = reportes_de_proyectos;
            this.opcconsultar_cliente = opcconsultar_cliente;
            this.opccrear_cliente = opccrear_cliente;
            this.opcmodificar_cliente = opcmodificar_cliente;
            this.opcconsultar_proyecto = opcconsultar_proyecto;
            this.opccrear_proyecto = opccrear_proyecto;
            this.opcmodificar_proyecto = opcmodificar_proyecto;
            this.opcconsultar_usuario = opcconsultar_usuario;
            this.opccrear_usuario = opccrear_usuario;
            this.opcmodificar_usuario = opcmodificar_usuario;
            this.opcconsultar_doc_creado = opcconsultar_doc_creado;
            this.opccrear_doc_creado = opccrear_doc_creado;
            this.opcmodificar_doc_creado = opcmodificar_doc_creado;
            this.opcconsultar_doc_subido = opcconsultar_doc_subido;
            this.opccrear_doc_subido = opccrear_doc_subido;
            this.opcmodificar_doc_subido = opcmodificar_doc_subido;
            this.opcconsultar_rol = opcconsultar_rol;
            this.opccrear_rol = opccrear_rol;
            this.opcmodificar_rol = opcmodificar_rol;
            this.opcbitacora = opcbitacora;
            this.opcconsultar_repo_audi = opcconsultar_repo_audi;
            this.opccrear_repo_movi = opccrear_repo_movi;
            this.opcmodificar_repo_proye = opcmodificar_repo_proye;
            this.idRol = idRol;
            this.Nom_Per = nom_Per;

        }

        // creacion de los construtores sin parametros.
        public Permisos()
        {
            this.opc = 0;
            this.estado_rol = 0;
            this.nombre_rol = "";
            this.detalle_rol = "";
            this.consultar_cliente = "";
            this.crear_cliente = "";
            this.modificar_cliente = "";
            this.crear_proyecto = "";
            this.consultar_proyecto = "";
            this.modificar_proyecto = "";
            this.agreagr_usuario = "";
            this.consultar_usuario = "";
            this.modificar_usuario = "";
            this.crear_documento = "";
            this.consultar_documento = "";
            this.modificar_documento = "";
            this.subir_documento = "";
            this.consultar_documento_subido = "";
            this.modificar_documento_subido = "";
            this.crear_rol = "";
            this.modificar_rol = "";
            this.consultar_rol = "";
            this.bitacora = "";
            this.reportes_auditoria = "";
            this.reportes_de_movimientos = "";
            this.reportes_de_proyectos = "";
            this.Nom_Per = "";
            this.opcconsultar_cliente = 0;
            this.opccrear_cliente = 0;
            this.opcmodificar_cliente = 0;
            this.opcconsultar_proyecto = 0;
            this.opccrear_proyecto = 0;
            this.opcmodificar_proyecto = 0;
            this.opcconsultar_usuario = 0;
            this.opccrear_usuario = 0;
            this.opcmodificar_usuario = 0;
            this.opcconsultar_doc_creado = 0;
            this.opccrear_doc_creado = 0;
            this.opcmodificar_doc_creado = 0;
            this.opcconsultar_doc_subido = 0;
            this.opccrear_doc_subido = 0;
            this.opcmodificar_doc_subido = 0;
            this.opcconsultar_rol = 0;
            this.opccrear_rol = 0;
            this.opcmodificar_rol = 0;
            this.opcbitacora = 0;
            this.opcconsultar_repo_audi = 0;
            this.opccrear_repo_movi = 0;
            this.opcmodificar_repo_proye = 0;
            this.idRol = 0;          
        }

    }
}
