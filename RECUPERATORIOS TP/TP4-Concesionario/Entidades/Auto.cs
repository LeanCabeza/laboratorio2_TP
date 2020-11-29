using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum EMarcaAuto
    {
        Volkswagen,
        Ford,
        Peugeot,
        Toyota,
        Indefinido
    }

    public enum ETipoMotor
    {
        Nafta,
        Diesel,
        Indefinido
    }

    [Serializable]
    public class Auto : Vehiculo
    {

        private EMarcaAuto marcaAuto;
        private ETipoMotor tipoMotor;
        private int caballosDeFuerza;

        #region Constructor

        //Constructor sin parametros para que me permita serializar sin largar excepciones.
        public Auto()
        {

        }

        public Auto(string nombreVehiculo,int precio, int anioDeFabricacion, int kilometraje, EMarcaAuto marcaAuto, ETipoMotor tipoMotor, int caballosDeFuerza)
                    :base(nombreVehiculo,precio,anioDeFabricacion,kilometraje)
        {
            this.marcaAuto = marcaAuto;
            this.tipoMotor = tipoMotor;
            this.caballosDeFuerza = caballosDeFuerza;
        }

        #endregion

        #region Propiedades

        public string MarcaAuto
        {
            get
            {
                switch (marcaAuto)
                {
                    case EMarcaAuto.Volkswagen:
                        return "Volkswagen";
                    case EMarcaAuto.Ford:
                        return "Ford";
                    case EMarcaAuto.Peugeot:
                        return "Peugeot";
                    case EMarcaAuto.Toyota:
                        return "Toyota";
                    default:
                        return "Indefinido";
                }
            }
        }

        public string TipoMotor
        {
            get
            {
                switch (tipoMotor)
                {
                    case ETipoMotor.Nafta:
                        return "Nafta";
                    case ETipoMotor.Diesel:
                        return "Diesel";  
                    default:
                        return "Indefinido";
                }
            }
        }

        public int CaballosDeFuerza
        {
            get { return caballosDeFuerza; }
            set { this.caballosDeFuerza = value; }
        }

        #endregion
    }

}
