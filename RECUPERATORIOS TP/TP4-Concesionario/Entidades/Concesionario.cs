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
        static Queue<Auto> autoFabricandose;
        static Queue<Auto> autoEntregado;

        static Queue<Moto> motoFabricandose;
        static Queue<Moto> motoEntregada;


        static Concesionario()
        {
            autoFabricandose = new Queue<Auto>();
            autoEntregado = new Queue<Auto>();

            motoFabricandose = new Queue<Moto>();
            motoEntregada = new Queue<Moto>();

        }

        public static Queue<Auto> AutoFabricandose
        {
            get { return autoFabricandose; }
        }

        public static Queue<Moto> MotoFabricandose
        {
            get { return motoFabricandose; }
        }


        public static Queue<Auto> AutoEntregado
        {
            get { return autoEntregado; }
        }

        public static Queue<Moto> MotoEntregada
        {
            get { return motoEntregada; }
        }

        /// <summary>
        /// Carga motos del xml ubicado en bin.
        /// </summary>
        /// <returns>True si pudo cargarlo correctamente ,false delo contrario</returns>
        public static bool CargarMotosDelXml()
        {

            List<Moto> listaAux = new List<Moto>();

            string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "ListaPedidosMoto.xml");

            Xml<List<Moto>> auxPedidos = new Xml<List<Moto>>();

            if (auxPedidos.Leer(path, out listaAux))
            {
                ///Si entro hasta aca es porque se pudo leer bien el xml ,ahi carga en la cola la lista de vehiculos.
                foreach (Moto m in listaAux)
                {
                    motoFabricandose.Enqueue(m);
                }
                return true;
            }
            else
            {
                return false;
            }
        }

        /// <summary>
        /// Carga autos del xml ubicado en bin.
        /// </summary>
        /// <returns>True si pudo cargarlo correctamente ,false delo contrario</returns>

        public static bool CargaAutosDelXml()
        {

            List<Auto> listaAux = new List<Auto>();

            string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "ListaPedidosAutos.xml");

            Xml<List<Auto>> auxPedidos = new Xml<List<Auto>>();

            if (auxPedidos.Leer(path, out listaAux))
            {
                ///Si entro hasta aca es porque se pudo leer bien el xml ,ahi carga en la cola la lista de vehiculos.
                foreach (Auto a in listaAux)
                {
                    autoFabricandose.Enqueue(a);
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
        /// <returns>Nro de objetos de tipo auto en string</returns>
        public static string Count(this Queue<Auto> colaVehiculos)
        {
            int contador = 0;

            foreach (var c in colaVehiculos)
            {
                contador++;
            }

            return contador.ToString();
        }

        /// <summary>
        /// Extension de count que me cuenta los elementos de la queue y me los retorna en string
        /// </summary>
        /// <param name="colaVehiculos"></param>
        /// <returns>Nro de objetos de tipo auto en string</returns>
        /// 
        public static string Count(this Queue<Moto> colaMotos)
        {
            int contador = 0;

            foreach (var c in colaMotos)
            {
                contador++;
            }

            return contador.ToString();
        }




        //SERIALIZO PEDIDOS PARA GENERAR EL XML QUE DESPUES VOY A CARGAR :D 

        public static bool SerializarPedidosAutos()
                {
                    string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "ListaPedidosAutos.xml");
                    Xml<List<Auto>> auxPedidos = new Xml<List<Auto>>();

                    List<Auto> pedidos = new List<Auto>();

                    pedidos.Add(new Auto("Gol Power",380000,2008,145000,EMarcaAuto.Volkswagen,ETipoMotor.Nafta,90));
                    pedidos.Add(new Auto("Bora",580000,2012,50000,EMarcaAuto.Volkswagen,ETipoMotor.Nafta,120));
                    pedidos.Add(new Auto("Vento",980000,2015,1250000,EMarcaAuto.Volkswagen,ETipoMotor.Nafta,160));
                    pedidos.Add(new Auto("Amarok",2080000,2020,2000000, EMarcaAuto.Volkswagen, ETipoMotor.Nafta, 130));
                    pedidos.Add(new Auto("Gol G4", 380000, 2008, 145000, EMarcaAuto.Volkswagen, ETipoMotor.Nafta, 90));
                    pedidos.Add(new Auto("Passat", 580000, 2012, 50000, EMarcaAuto.Volkswagen, ETipoMotor.Nafta, 120));
                    pedidos.Add(new Auto("Gol G5", 980000, 2015, 1250000, EMarcaAuto.Volkswagen, ETipoMotor.Nafta, 160));
                    pedidos.Add(new Auto("UP", 2080000, 2020, 2000000, EMarcaAuto.Volkswagen, ETipoMotor.Nafta, 130));
                    pedidos.Add(new Auto("Tiguan", 2080000, 2020, 2000000, EMarcaAuto.Volkswagen, ETipoMotor.Nafta, 130));
                    pedidos.Add(new Auto("Gol G3", 580000, 2012, 50000, EMarcaAuto.Volkswagen, ETipoMotor.Nafta, 120));
                    pedidos.Add(new Auto("Vento", 980000, 2015, 1250000, EMarcaAuto.Volkswagen, ETipoMotor.Nafta, 160));
                    pedidos.Add(new Auto("Amarok", 2080000, 2020, 2000000, EMarcaAuto.Volkswagen, ETipoMotor.Nafta, 130));
                    pedidos.Add(new Auto("Passat", 380000, 2008, 145000, EMarcaAuto.Volkswagen, ETipoMotor.Nafta, 90));
                    pedidos.Add(new Auto("Bora", 580000, 2012, 50000, EMarcaAuto.Volkswagen, ETipoMotor.Nafta, 120));
                    pedidos.Add(new Auto("Vento", 980000, 2015, 1250000, EMarcaAuto.Volkswagen, ETipoMotor.Nafta, 160));
                    pedidos.Add(new Auto("Amarok", 2080000, 2020, 2000000, EMarcaAuto.Volkswagen, ETipoMotor.Nafta, 130));
                    pedidos.Add(new Auto("T- CROSS", 2080000, 2020, 2000000, EMarcaAuto.Volkswagen, ETipoMotor.Nafta, 130));




            return auxPedidos.Guardar(path, pedidos);
                }

                public static bool SerializarPedidosMotos()
                {
                    string path = String.Concat(AppDomain.CurrentDomain.BaseDirectory, "ListaPedidosMoto.xml");
                    Xml<List<Moto>> auxPedidos = new Xml<List<Moto>>();

                    List<Moto> pedidos = new List<Moto>();

                    pedidos.Add(new Moto("CG Titan",160000,2020,0,EMarcaMoto.Honda,EEncendido.Carburador,150));
                    pedidos.Add(new Moto("Wave", 100000, 2020, 0, EMarcaMoto.Honda, EEncendido.Carburador,110));
                    pedidos.Add(new Moto("Twister", 160000, 2020, 0, EMarcaMoto.Honda, EEncendido.InyeccionElectronica,250));
                    pedidos.Add(new Moto("Tornado",400000, 2020, 0, EMarcaMoto.Honda, EEncendido.Carburador,250));
                    pedidos.Add(new Moto("CG Titan", 160000, 2020, 0, EMarcaMoto.Honda, EEncendido.Carburador, 150));
                    pedidos.Add(new Moto("Wave", 100000, 2020, 0, EMarcaMoto.Honda, EEncendido.Carburador, 110));
                    pedidos.Add(new Moto("CB125", 160000, 2020, 0, EMarcaMoto.Honda, EEncendido.InyeccionElectronica, 250));
                    pedidos.Add(new Moto("Storm", 400000, 2020, 0, EMarcaMoto.Honda, EEncendido.Carburador, 250));
                    pedidos.Add(new Moto("XR125", 160000, 2020, 0, EMarcaMoto.Honda, EEncendido.Carburador, 150));
                    pedidos.Add(new Moto("XR150", 100000, 2020, 0, EMarcaMoto.Honda, EEncendido.Carburador, 110));
                    pedidos.Add(new Moto("XRE300", 160000, 2020, 0, EMarcaMoto.Honda, EEncendido.InyeccionElectronica, 250));
                    pedidos.Add(new Moto("Falcon", 400000, 2020, 0, EMarcaMoto.Honda, EEncendido.Carburador, 250));
                    pedidos.Add(new Moto("CBR1000", 160000, 2020, 0, EMarcaMoto.Honda, EEncendido.Carburador, 150));
                    pedidos.Add(new Moto("XtZ 125", 100000, 2020, 0, EMarcaMoto.Yamaha, EEncendido.Carburador, 110));
                    pedidos.Add(new Moto("XTZ150", 160000, 2020, 0, EMarcaMoto.Yamaha, EEncendido.InyeccionElectronica, 250));
                    pedidos.Add(new Moto("YBR 125", 400000, 2020, 0, EMarcaMoto.Yamaha, EEncendido.Carburador, 250));



            return auxPedidos.Guardar(path, pedidos);
                }

        
    }
}
