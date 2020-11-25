using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Archivo;

namespace Entidades
{
    public static class Concesionario
    {
        static Queue<Vehiculo> fabricandose;
        static Queue<Vehiculo> entregado;


        static Concesionario()
        {
            fabricandose = new Queue<Vehiculo>();
            entregado = new Queue<Vehiculo>();
        }

        public static Queue<Vehiculo> Fabricandose
        {
            get { return fabricandose; }
        }

        public static Queue<Vehiculo> Preparado
        {
            get { return entregado; }
        }



        /// <summary>
        /// Carga los pedidos de vehiculos que estan guardadas en el xml
        /// </summary>
        /// <returns></returns>
        /// 
        public static bool CargarVehiculosDelXml()
        {

            List<Vehiculo> listaAux = new List<Vehiculo>();

            string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "ListaPedidos.xml");

            Xml<List<Vehiculo>> auxPedidos = new Xml<List<Vehiculo>>();

            if (auxPedidos.Leer(path, out listaAux))
            {
                ///Si entro hasta aca es porque se pudo leer bien el xml ,ahi carga en la cola la lista de vehiculos.
                foreach (Vehiculo c in listaAux)
                {
                    fabricandose.Enqueue(c);
                }
                return true;
            }
            else
            {
                return false;
            }
        }



        /// <summary>
        /// Extension que ademas de contar los pedidos los guarda en un string.
        /// </summary>
        /// <param name="colaVehiculos"></param>
        /// <returns></returns>
        public static string Count(this Queue<Vehiculo> colaVehiculos)
        {
            int contador = 0;

            foreach (var c in colaVehiculos)
            {
                contador++;
            }

            return contador.ToString();
        }


  
         //SERIALIZO PEDIDOS PARA GENERAR EL XML QUE DESPUES VOY A CARGAR :D 
          
                public static bool SerializarPedidosAutos()
                {
                    string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "ListaPedidos.xml");
                    Xml<List<Auto>> auxPedidos = new Xml<List<Auto>>();

                    List<Auto> pedidos = new List<Auto>();

                    pedidos.Add(new Auto("Gol Power",380000,2008,145000,EMarcaAuto.Volkswagen,ETipoMotor.Nafta,90));
                    //pedidos.Add(new Moto("CG Titan",160000,2020,0,EMarcaMoto.Honda,EEncendido.Carburador,150));
                    pedidos.Add(new Auto("Bora",580000,2012,50000,EMarcaAuto.Volkswagen,ETipoMotor.Nafta,120));
                    //pedidos.Add(new Moto("Wave", 100000, 2020, 0, EMarcaMoto.Honda, EEncendido.Carburador,110));
                    pedidos.Add(new Auto("Vento",980000,2015,1250000,EMarcaAuto.Volkswagen,ETipoMotor.Nafta,160));
                    //pedidos.Add(new Moto("Twister", 160000, 2020, 0, EMarcaMoto.Honda, EEncendido.InyeccionElectronica,250));
                    pedidos.Add(new Auto("Amarok",2080000,2020,2000000, EMarcaAuto.Volkswagen, ETipoMotor.Nafta, 130));
                    //pedidos.Add(new Moto("Tornado",400000, 2020, 0, EMarcaMoto.Honda, EEncendido.Carburador,250));


                    return auxPedidos.Guardar(path, pedidos);
                }

                public static bool SerializarPedidosMotos()
                {
                    string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "ListaPedidosMoto.xml");
                    Xml<List<Moto>> auxPedidos = new Xml<List<Moto>>();

                    List<Moto> pedidos = new List<Moto>();

                    //pedidos.Add(new Auto("Gol Power", 380000, 2008, 145000, EMarcaAuto.Volkswagen, ETipoMotor.Nafta, 90));
                    pedidos.Add(new Moto("CG Titan",160000,2020,0,EMarcaMoto.Honda,EEncendido.Carburador,150));
                    //pedidos.Add(new Auto("Bora", 580000, 2012, 50000, EMarcaAuto.Volkswagen, ETipoMotor.Nafta, 120));
                    pedidos.Add(new Moto("Wave", 100000, 2020, 0, EMarcaMoto.Honda, EEncendido.Carburador,110));
                    //pedidos.Add(new Auto("Vento", 980000, 2015, 1250000, EMarcaAuto.Volkswagen, ETipoMotor.Nafta, 160));
                    pedidos.Add(new Moto("Twister", 160000, 2020, 0, EMarcaMoto.Honda, EEncendido.InyeccionElectronica,250));
                    //pedidos.Add(new Auto("Amarok", 2080000, 2020, 2000000, EMarcaAuto.Volkswagen, ETipoMotor.Nafta, 130));
                    pedidos.Add(new Moto("Tornado",400000, 2020, 0, EMarcaMoto.Honda, EEncendido.Carburador,250));


                    return auxPedidos.Guardar(path, pedidos);
                }

                public static bool SerializarPedidosVehiculos()
                {
                    string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "ListaPedidosMotoYAuto.xml");
                    Xml<List<Vehiculo>> auxPedidos = new Xml<List<Vehiculo>>();

                    List<Vehiculo> pedidos = new List<Vehiculo>();

                    pedidos.Add(new Auto("Gol Power", 380000, 2008, 145000, EMarcaAuto.Volkswagen, ETipoMotor.Nafta, 90));
                    pedidos.Add(new Moto("CG Titan", 160000, 2020, 0, EMarcaMoto.Honda, EEncendido.Carburador, 150));
                    pedidos.Add(new Auto("Bora", 580000, 2012, 50000, EMarcaAuto.Volkswagen, ETipoMotor.Nafta, 120));
                    pedidos.Add(new Moto("Wave", 100000, 2020, 0, EMarcaMoto.Honda, EEncendido.Carburador, 110));
                    pedidos.Add(new Auto("Vento", 980000, 2015, 1250000, EMarcaAuto.Volkswagen, ETipoMotor.Nafta, 160));
                    pedidos.Add(new Moto("Twister", 160000, 2020, 0, EMarcaMoto.Honda, EEncendido.InyeccionElectronica, 250));
                    pedidos.Add(new Auto("Amarok", 2080000, 2020, 2000000, EMarcaAuto.Volkswagen, ETipoMotor.Nafta, 130));
                    pedidos.Add(new Moto("Tornado", 400000, 2020, 0, EMarcaMoto.Honda, EEncendido.Carburador, 250));


                    return auxPedidos.Guardar(path, pedidos);
                }

    }
}
