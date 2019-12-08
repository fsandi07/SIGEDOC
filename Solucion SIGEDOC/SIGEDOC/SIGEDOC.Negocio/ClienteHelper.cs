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
        public ClienteHelper(Clientes parObjclientes)
        {
            objCliente = parObjclientes;
        }

        public void Agregar_Cliente()
        {
            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[8];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objCliente.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@nombreCliente";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 50;
                parParameter[1].SqlValue = objCliente.Nombre_cliente;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@nombreContacto";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 30;
                parParameter[2].SqlValue = objCliente.Nombre_de_Contacto;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@telefonoContacto";
                parParameter[3].SqlDbType = SqlDbType.Int;
                parParameter[3].SqlValue = objCliente.Telefono_contacto;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@correoElect";
                parParameter[4].SqlDbType = SqlDbType.VarChar;
                parParameter[4].Size = 50;
                parParameter[4].SqlValue = objCliente.Correo_cliente;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@detalleCliente";
                parParameter[5].SqlDbType = SqlDbType.VarChar;
                parParameter[5].Size = 100;
                parParameter[5].SqlValue = objCliente.Detalle_cliente;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@estadoCliente";
                parParameter[6].SqlDbType = SqlDbType.NChar;
                parParameter[6].Size = 1;
                parParameter[6].SqlValue = objCliente.Estado_cliente;

                parParameter[7] = new SqlParameter();
                parParameter[7].ParameterName = "@idUusario";
                parParameter[7].SqlDbType = SqlDbType.VarChar;
                parParameter[7].Size = 50;
                parParameter[7].SqlValue = objCliente.Idusuario;


                cnGeneral.EjecutarSP(parParameter,"SPCliente");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }

        // Actualizar cliente

        public void Actualizar_Cliente()
        {
            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[9];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objCliente.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@idCliente ";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = objCliente.Idcliente;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@nombreCliente";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 50;
                parParameter[2].SqlValue = objCliente.Nombre_cliente;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@nombreContacto";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 30;
                parParameter[3].SqlValue = objCliente.Nombre_de_Contacto;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@telefonoContacto";
                parParameter[4].SqlDbType = SqlDbType.Int;
                parParameter[4].SqlValue = objCliente.Telefono_contacto;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@correoElect";
                parParameter[5].SqlDbType = SqlDbType.VarChar;
                parParameter[5].Size = 50;
                parParameter[5].SqlValue = objCliente.Correo_cliente;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@detalleCliente";
                parParameter[6].SqlDbType = SqlDbType.VarChar;
                parParameter[6].Size = 100;
                parParameter[6].SqlValue = objCliente.Detalle_cliente;

                parParameter[7] = new SqlParameter();
                parParameter[7].ParameterName = "@estadoCliente";
                parParameter[7].SqlDbType = SqlDbType.NChar;
                parParameter[7].Size = 1;
                parParameter[7].SqlValue = objCliente.Estado_cliente;

                parParameter[8] = new SqlParameter();
                parParameter[8].ParameterName = "@idUusario";
                parParameter[8].SqlDbType = SqlDbType.VarChar;
                parParameter[8].Size = 50;
                parParameter[8].SqlValue = objCliente.Idusuario;

                cnGeneral.EjecutarSP(parParameter, "SPCliente");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }
        public DataTable Listar_Cliente()
        {
            tblDatos = new DataTable();
            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[1];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objCliente.Opc;
                tblDatos = cnGeneral.RetornaTabla(parParameter,"SPCliente");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tblDatos;
        }

        public DataTable Busqueda()
        {
            tblDatos = new DataTable();
            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[2];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objCliente.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@nombreCliente";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 50;
                parParameter[1].SqlValue = objCliente.Nombre_cliente;

                tblDatos = cnGeneral.RetornaTabla(parParameter, "SPBusquedas");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);
            }

            return tblDatos;
        }


    }
}
