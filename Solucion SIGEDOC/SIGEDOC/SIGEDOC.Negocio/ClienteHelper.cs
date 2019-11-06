using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//librerias agregadas
using System.Data.SqlClient;
using MVC.Modelo;
using System.Data;
using System.IO;

namespace SIGEDOC.Negocio
{
    public class ClienteHelper
    {
        Datos cnGeneral = null;
        DataTable tblDatos = null;
        Clientes objCliente = null;
        public ClienteHelper(Clientes parObjcompras)
        {
            objCliente = parObjcompras;
        }


    }
}
