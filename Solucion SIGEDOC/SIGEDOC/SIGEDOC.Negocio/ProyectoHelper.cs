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
   public class ProyectoHelper
    {
        Datos cnGeneral = null;
        DataTable tblDatos = null;
        Proyectos objproyecto = null;
        public ProyectoHelper(Proyectos parObjproyecto)
        {
            objproyecto = parObjproyecto;
        }
        // Agregar un Nuevo Proyecto

        public void Agregar_Proyecto()
        {
            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[9];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objproyecto.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@NombreProy";
                parParameter[1].SqlDbType = SqlDbType.VarChar;
                parParameter[1].Size = 50;
                parParameter[1].SqlValue = objproyecto.Nombre_Proyecto;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@NumLicita";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 30;
                parParameter[2].SqlValue = objproyecto.Numero_Licitacion;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@detalleProyec";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 100;
                parParameter[3].SqlValue = objproyecto.Detalle_del_proyecto;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@idCliente";
                parParameter[4].SqlDbType = SqlDbType.Int;
                parParameter[4].SqlValue = objproyecto.Id_cliente;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@idUsuario";
                parParameter[5].SqlDbType = SqlDbType.VarChar;
                parParameter[5].Size = 20;
                parParameter[5].SqlValue = objproyecto.Usuario;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@estadoProyec";
                parParameter[6].SqlDbType = SqlDbType.NChar;
                parParameter[6].Size = 10;
                parParameter[6].SqlValue = objproyecto.Estado_Proyecto;

                parParameter[7] = new SqlParameter();
                parParameter[7].ParameterName = "@fechaProy ";
                parParameter[7].SqlDbType = SqlDbType.DateTime;
                parParameter[7].SqlValue = objproyecto.Fecha_Proyecto;

                parParameter[8] = new SqlParameter();
                parParameter[8].ParameterName = "@statusProyec";
                parParameter[8].SqlDbType = SqlDbType.NChar;
                parParameter[8].Size = 1;
                parParameter[8].SqlValue = objproyecto.Status_proyecto;

                cnGeneral.EjecutarSP(parParameter, "SPProyecto");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }
        //Actualizar Proyecto
        public void Actualizar_Proyecto()
        {
            try
            {
                cnGeneral = new Datos();

                SqlParameter[] parParameter = new SqlParameter[7];

                parParameter[0] = new SqlParameter();
                parParameter[0].ParameterName = "@opcion";
                parParameter[0].SqlDbType = SqlDbType.Int;
                parParameter[0].SqlValue = objproyecto.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName ="@centroCostos";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = objproyecto.Centro_costos;

                parParameter[2] = new SqlParameter();
                parParameter[2].ParameterName = "@NombreProy";
                parParameter[2].SqlDbType = SqlDbType.VarChar;
                parParameter[2].Size = 50;
                parParameter[2].SqlValue = objproyecto.Nombre_Proyecto;

                parParameter[3] = new SqlParameter();
                parParameter[3].ParameterName = "@NumLicita";
                parParameter[3].SqlDbType = SqlDbType.VarChar;
                parParameter[3].Size = 30;
                parParameter[3].SqlValue = objproyecto.Numero_Licitacion;

                parParameter[4] = new SqlParameter();
                parParameter[4].ParameterName = "@detalleProyec";
                parParameter[4].SqlDbType = SqlDbType.VarChar;
                parParameter[4].Size = 100;
                parParameter[4].SqlValue = objproyecto.Detalle_del_proyecto;

                parParameter[5] = new SqlParameter();
                parParameter[5].ParameterName = "@idCliente";
                parParameter[5].SqlDbType = SqlDbType.Int;
                parParameter[5].SqlValue = objproyecto.Id_cliente;

                parParameter[6] = new SqlParameter();
                parParameter[6].ParameterName = "@estadoProyec";
                parParameter[6].SqlDbType = SqlDbType.VarChar;
                parParameter[6].Size = 50;
                parParameter[6].SqlValue = objproyecto.Estado_Proyecto;


                cnGeneral.EjecutarSP(parParameter, "SPProyecto");
            }
            catch (Exception ex)
            {
                throw new Exception(ex.Message);

            }
        }
        //Mostrar Todos los Proyectos
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
                parParameter[0].SqlValue = objproyecto.Opc;

                parParameter[1] = new SqlParameter();
                parParameter[1].ParameterName = "@centroCostos";
                parParameter[1].SqlDbType = SqlDbType.Int;
                parParameter[1].SqlValue = objproyecto.Centro_costos;

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
