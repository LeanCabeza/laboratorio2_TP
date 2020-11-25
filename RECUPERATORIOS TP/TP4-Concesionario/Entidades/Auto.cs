using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public enum EMarca
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


    public class Auto : Vehiculo
    {

        private EMarca marcaAuto;
        private ETipoMotor tipoMotor;
        private int caballosDeFuerza;

        #region Constructor
        public Auto(string nombreVehiculo,int precio, int anioDeFabricacion, int kilometraje, EMarca marcaAuto, ETipoMotor tipoMotor, int caballosDeFuerza)
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
                    case EMarca.Volkswagen:
                        return "Volkswagen";
                    case EMarca.Ford:
                        return "Ford";
                    case EMarca.Peugeot:
                        return "Peugeot";
                    case EMarca.Toyota:
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
                        return "Comida Rapida";
                    case ETipoMotor.Diesel:
                        return "Comida Gurmet";  
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
