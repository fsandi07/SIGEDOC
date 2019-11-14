using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
//librerias agrgadas 
using System.Data.SqlClient;
using MVC.Modelo;
using System.Data;
using System.IO;


namespace SIGEDOC.Negocio
{
    public class CrearDocHelper
    {
        Datos cnGneral = null;
        DataTable tbldatos = null;
        CrearDocumento objdocCreado;

        public CrearDocHelper(CrearDocumento parObjdocCreado)
        {
            objdocCreado = parObjdocCreado;
        }


    }
}
