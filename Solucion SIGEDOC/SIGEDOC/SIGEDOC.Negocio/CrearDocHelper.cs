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
   public class CrearDocHelper
    {
        Datos cnGeneral = null;
        DataTable tblDatos = null;
        CrearDocumento objdocCreado = null;

        public CrearDocHelper (CrearDocumento parObjdocCreado)
        {
            objdocCreado = parObjdocCreado;
        }


    }
}
