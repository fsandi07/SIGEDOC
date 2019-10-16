using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sigemat.Negocio
{
    public class Usuario
    {
        public int    opc;
        public string nombreUsuario;
        public string apellidosUsuario;
        public string correoElectronico;
        public string contactoUsuario;
        public string identificacionUsuario;
        public string direccionUsuario;
        public string clave;
        public int    perfil;
        // esta variable globales son para capturara valores que se denben utilizar en los diferentes modulos, 
        //pero que a nivel de usuario no se deben insetar(solo capturar el valor)
        public static string GlonombreUsuario;
        public static string GloapellidoUsuario;
        public static int GlotipoUsu;
        public static string GloIdentificacion;
        public static string GlocorreoUsuario;
        public static int GlocontactUsu;
        public static string Gloclave;

        public int Opc { get => opc; set => opc = value; }
        public string NombreUsuario { get => nombreUsuario; set => nombreUsuario = value; }
        public string ApellidosUsuario { get => apellidosUsuario; set => apellidosUsuario = value; }
        public string CorreoElectronico { get => correoElectronico; set => correoElectronico = value; }
        public string ContactoUsuario { get => contactoUsuario; set => contactoUsuario = value; }
        public string IdentificacionUsuario { get => identificacionUsuario; set => identificacionUsuario = value; }
        public string DireccionUsuario { get => direccionUsuario; set => direccionUsuario = value; }
        public string Clave { get => clave; set => clave = value; }
        public int Perfil { get => perfil; set => perfil = value; }

        public Usuario(int opc, string nombreUsuario, string apellidosUsuario, string correoElectronico, 
            string contactoUsuario, string identificacionUsuario, string direccionUsuario, 
            string clave, int perfil)
        {
            this.opc = opc;
            this.nombreUsuario = nombreUsuario;
            this.apellidosUsuario = apellidosUsuario;
            this.correoElectronico = correoElectronico;
            this.contactoUsuario = contactoUsuario;
            this.identificacionUsuario = identificacionUsuario;
            this.direccionUsuario = direccionUsuario;
            this.clave = clave;
            this.perfil = perfil;
        }

        public Usuario()
        {
            this.opc = 0;
            this.nombreUsuario = "";
            this.apellidosUsuario = "";
            this.correoElectronico = "";
            this.contactoUsuario = "";
            this.identificacionUsuario = "";
            this.direccionUsuario = "";
            this.clave = "";
            this.perfil = 0;
        }

        // con estos metodos capturo los valores que ingresne a los get y set 
        public static void SetNombre(string nombreResgistrado)
        {
            GlonombreUsuario = nombreResgistrado;
        }
        public static void SetApellidos(string apellidosRegistrado)
        {
            GloapellidoUsuario = apellidosRegistrado;
        }

        public static void SetIdentificacion(string identificacionResgitrado)
        {
            GloIdentificacion = identificacionResgitrado;
        }
        public static void SetCorreo(string correoResgistrado)
        {
            GlocorreoUsuario = correoResgistrado;
        }

        public static void SetTipo(int usuarioResgitrado)
        {
            GlotipoUsu = usuarioResgitrado;

        }
        public static void SetContacto(int contactoRegistrado)
        {
            GlocontactUsu = contactoRegistrado;

        }
        public static void SetClave(string claveRegistrado)
        {
            Gloclave = claveRegistrado;

        }

    }
}
