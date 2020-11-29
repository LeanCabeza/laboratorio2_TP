using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using Archivo;
using Excepciones;
using System.Data.SqlClient;
using System.Data;

namespace PruebaConsola
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Title = "Leandro.Cabeza.2D.TP4";
            Auto a1 = new Auto("Gol Power", 380000, 2008, 145000, EMarcaAuto.Volkswagen, ETipoMotor.Nafta, 90);
            Auto a2 = new Auto("Senda", 180000, 2004, 195000, EMarcaAuto.Volkswagen, ETipoMotor.Nafta,60);
            Auto a3 = new Auto("Gol g1", 200000, 1999, 125000, EMarcaAuto.Volkswagen, ETipoMotor.Nafta, 60);
            Moto m1 = new Moto("Dax", 160000, 2020, 0, EMarcaMoto.Honda, EEncendido.Carburador, 150);
            Moto m2 = new Moto("PSX", 160000, 2020, 0, EMarcaMoto.Honda, EEncendido.Carburador, 150);
            Moto m3 = new Moto("cb190", 160000, 2020, 0, EMarcaMoto.Honda, EEncendido.InyeccionElectronica, 150);
          
            if( a1 != null && a2 != null && a3 != null)
            {
                Console.WriteLine("\nAutos Generados con exito");
            }

            if (m1 != null && m2 != null && m3 != null)
            {
                Console.WriteLine("\nMotos generadas con exito");
            }


            // Pruebo la carga de datos del xml

            try
            {
                Concesionario.CargaAutosDelXml();
                Console.WriteLine("\nAutos por defecto cargados del Xml");
            }
            catch (ArchivoException e)
            {
                Console.WriteLine(e.Message);
            }

            try
            {
                Concesionario.CargarMotosDelXml();
                Console.WriteLine("\nMotos por defecto cargados del Xml");
            }
            catch (ArchivoException e)
            {
                Console.WriteLine(e.Message);
            }

            
            // Prueba de guardado en txt 

            bool pruebaMoto = GuardaString.GuardarMoto(m1);
            
            if (pruebaMoto == true )
            {
                Console.WriteLine("\nMotos agregadaCorrectamente al Txt");
            }


            // Preba de guardado de auto 

            bool pruebaAuto = GuardaString.GuardarAuto(a1);

            if (pruebaAuto == true)
            {
                Console.WriteLine("\nAuto agregadaCorrectamente al Txt");
            }

            // Probando que conecte correctamente a la bdd

            try
            {
                SqlConnection conexionBD = new SqlConnection("Data Source = DESKTOP-DCNPJDC\\SQLEXPRESS ; Initial Catalog = Concesionario;Integrated Security=true");
                SqlCommand comando = new SqlCommand();
                comando.Connection = conexionBD;
                comando.CommandType = CommandType.Text;
                comando.CommandText = "INSERT INTO [dbo].[Autos] VALUES (@nombre,@precio,@anio,@kilometraje,@marca,@motor,@caballosDeFuerza) ";


                comando.Parameters.Add(new SqlParameter("@nombre", "Prueba"));
                comando.Parameters.Add(new SqlParameter("@precio",1));
                comando.Parameters.Add(new SqlParameter("@anio",1));
                comando.Parameters.Add(new SqlParameter("@kilometraje", 1));
                comando.Parameters.Add(new SqlParameter("@marca", 1));
                comando.Parameters.Add(new SqlParameter("@motor","Prueba"));
                comando.Parameters.Add(new SqlParameter("@caballosDeFuerza",1));

                conexionBD.Open();
                if(comando.ExecuteNonQuery() == 0)
                {
                    Console.WriteLine("\nSe pudo insetar en la tabla con exito");
                }
            }
            catch (Exception e)
            {
                throw new ArchivoException("\nError al intentar conectar con la base de datos", e);
            }

            Console.ReadKey();
        }
    }
}
