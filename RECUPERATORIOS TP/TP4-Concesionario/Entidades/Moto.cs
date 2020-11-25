using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum EMarcaMoto
    {
        Honda,
        Yamaha,
        Suzuki,
        Indefinido
    }

    public enum EEncendido
    {
        Carburador,
        InyeccionElectronica,
        Indefinido
    }
    public class Moto :Vehiculo
    {

        private EMarcaMoto marcaMoto;
        private EEncendido tipoEncendido;
        private int cilindrada;

        #region Constructor 

        //Constructor sin parametros para que me permita serializar largar excepciones.
        public Moto()
        {

        }
        public Moto(string nombreVehiculo, int precio, int anioDeFabricacion, int kilometraje, EMarcaMoto marcaMoto, EEncendido tipoEncendido, int cilindrada)
                    : base(nombreVehiculo, precio, anioDeFabricacion, kilometraje)
        {
            this.marcaMoto = marcaMoto;
            this.tipoEncendido = tipoEncendido;
            this.cilindrada = cilindrada;
        }

        #endregion

        #region Propiedades

        public string MarcaMoto
        {
            get
            {
                switch (marcaMoto)
                {
                    case EMarcaMoto.Honda:
                        return "Honda";
                    case EMarcaMoto.Yamaha:
                        return "Yamaha";
                    case EMarcaMoto.Suzuki:
                        return "Suzuki";
                    default:
                        return "Indefinido";
                }
            }
        }

        public string TipoEncendido
        {
            get
            {
                switch (tipoEncendido)
                {
                    case EEncendido.InyeccionElectronica:
                        return "Inyeccion Electronica";
                    case EEncendido.Carburador:
                        return "Carburador";
                    default:
                        return "Indefinido";
                }
            }
        }

        public int Cilindrada
        {
            get { return cilindrada; }
            set { this.cilindrada = value; }
        }

        #endregion



    }
}
