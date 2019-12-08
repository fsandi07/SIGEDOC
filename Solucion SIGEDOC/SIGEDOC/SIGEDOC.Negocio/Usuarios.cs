using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SIGEDOC.Negocio
{
     public class Usuarios
    {
        // opcion para el procedimiento almacenado;
        private int opc;
        private string cedula_usuario;
        private string nombre_usuario;
        private string apellidos;
        private string nicname_usuario;
        private string correo_usuario;
        private string clave_usuario;
        private int rol_usuario;
        private int estado_usuarios;
        private int contacto_usuario;
        // el idusuario tiene que agrgarse para el uso de lo dispardores 
        private string idusuario;
        // variables globales
        public static string GloUsuario;
        public static string GloNicname;
        public static string GloApellidos;
        public static int GlotIdRol;
        public static string GloIdUsuario;
        public static int GloContacto;
        public static string GloCorreo;
        // creacion de set y get para el uso de las variables.
        public int Opc { get => opc; set => opc = value; }
        public string Cedula_usuario { get => cedula_usuario; set => cedula_usuario = value; }
        public string Nombre_usuario { get => nombre_usuario; set => nombre_usuario = value; }
        public string Nicname_usuario { get => nicname_usuario; set => nicname_usuario = value; }
        public string Correo_usuario { get => correo_usuario; set => correo_usuario = value; }
        public string Clave_usuario { get => clave_usuario; set => clave_usuario = value; }
        public int Rol_usuario { get => rol_usuario; set => rol_usuario = value; }
        public int Contacto_usuario { get => contacto_usuario; set => contacto_usuario = value; }
        public string Apellidos { get => apellidos; set => apellidos = value; }
        public string Idusuario { get => idusuario; set => idusuario = value; }
        public int Estado_usuarios { get => estado_usuarios; set => estado_usuarios = value; }

        // contructor con parametros
        public Usuarios(int opc, string cedula_usuario, string nombre_usuario, string nicname_usuario, string correo_usuario, string clave_usuario, int rol_usuario, int estado_usuarios, int contacto_usuario, string apellidos, string idusuario)
        {
            this.Opc = opc;
            this.Cedula_usuario= cedula_usuario;
            this.Nombre_usuario = nombre_usuario;
            this.Nicname_usuario = nicname_usuario;
            this.Correo_usuario = correo_usuario;
            this.Clave_usuario = clave_usuario;
            this.Rol_usuario = rol_usuario;
            this.Estado_usuarios = estado_usuarios;
            this.Contacto_usuario = contacto_usuario;
            this.apellidos = apellidos;
            this.idusuario = idusuario;
        }

        // contructor sin parametros
        public Usuarios()
        {
            this.Opc = 0;
            this.Cedula_usuario = "";
            this.Nombre_usuario = "";
            this.Nicname_usuario = "";
            this.Correo_usuario = "";
            this.Clave_usuario = "";
            this.Rol_usuario = 0;
            this.Estado_usuarios = 0;
            this.Contacto_usuario = 0;
            this.apellidos = "";
            this.Idusuario = "";
        }

        // con estos metodos capturo los valores que ingresne a los get y set 
        public static void SetNombre(string nombre_usuario)
        {
            GloUsuario = nombre_usuario;
        }
        public static void SetNicName(string nicname_usuario)
        {
            GloNicname = nicname_usuario;
        }
        public static void SetIdRol(int rol_usuario)
        {
            GlotIdRol = rol_usuario;
        }
        public static void SetIdUsuario(string cedula_usuario)
        {
            GloIdUsuario = cedula_usuario;
        }

        public static void SetApellidos(string apellidos)
        {
            GloApellidos = apellidos;
        }
        public static void SetCorreo(string correo_usuario)
        {
            GloCorreo = correo_usuario;
        }
        public static void SetContacto(int contacto_usuario)
        {
            GloContacto = contacto_usuario;
        }



    }
}
