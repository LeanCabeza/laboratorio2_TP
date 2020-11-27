using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;
using Excepciones;

namespace Entidades
{
    public static class ConexionBD
    {
        static SqlConnection conexionBD;


        static ConexionBD()
        {
            conexionBD = new SqlConnection("Data Source = DESKTOP-DCNPJDC\\SQLEXPRESS ; Initial Catalog = Concesionario;Integrated Security=true");
        }                                                       
   
        public static void SubirAuto(Auto auxAuto)
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexionBD;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO [dbo].[Autos] VALUES (@nombre,@precio,@anio,@kilometraje,@marca,@motor,@caballosDeFuerza) ";
 

                comando.Parameters.Add(new SqlParameter("@nombre", auxAuto.NombreVehiculo));
                comando.Parameters.Add(new SqlParameter("@precio", auxAuto.Precio));
                comando.Parameters.Add(new SqlParameter("@anio", auxAuto.AnioDeFabricacion));
                comando.Parameters.Add(new SqlParameter("@kilometraje", auxAuto.Kilometraje));
                comando.Parameters.Add(new SqlParameter("@marca", auxAuto.MarcaAuto));
                comando.Parameters.Add(new SqlParameter("@motor", auxAuto.TipoMotor));
                comando.Parameters.Add(new SqlParameter("@caballosDeFuerza", auxAuto.CaballosDeFuerza));


                if (conexionBD.State != ConnectionState.Open)
                {
                    conexionBD.Open();
                }
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new ArchivoException("Error al intentar conectar con la base de datos", e);
            }
            finally
            {
                conexionBD.Close();
            }
        }

        public static void SubirMoto(Moto auxMoto)
        {
            try
            {
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexionBD;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO [dbo].[Motos] VALUES (@nombre,@precio,@anio,@kilometraje,@marca,@encendido,@cilindrada) ";


                comando.Parameters.Add(new SqlParameter("@nombre", auxMoto.NombreVehiculo));
                comando.Parameters.Add(new SqlParameter("@precio", auxMoto.Precio));
                comando.Parameters.Add(new SqlParameter("@anio", auxMoto.AnioDeFabricacion));
                comando.Parameters.Add(new SqlParameter("@kilometraje", auxMoto.Kilometraje));
                comando.Parameters.Add(new SqlParameter("@marca", auxMoto.MarcaMoto));
                comando.Parameters.Add(new SqlParameter("@encendido", auxMoto.TipoEncendido));
                comando.Parameters.Add(new SqlParameter("@cilindrada", auxMoto.Cilindrada));


                if (conexionBD.State != ConnectionState.Open)
                {
                    conexionBD.Open();
                }
                comando.ExecuteNonQuery();
            }
            catch (Exception e)
            {
                throw new ArchivoException("Error al intentar conectar con la base de datos", e);
            }
            finally
            {
                conexionBD.Close();
            }

        }


    }
}