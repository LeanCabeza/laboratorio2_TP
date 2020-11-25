using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public abstract class Vehiculo
    {
        private string nombreVehiculo;
        private int precio;
        private int anioDeFabricacion;
        private int kilometraje;

        #region Constructor
        protected Vehiculo(string nombreVehiculo, int precio, int anioDeFabricacion, int kilometraje)
        {
            this.nombreVehiculo = nombreVehiculo;
            this.precio = precio;
            this.anioDeFabricacion = anioDeFabricacion;
            this.kilometraje = kilometraje;
        }
        #endregion

        #region Propiedades

        public string NombreVehiculo
        {
            get { return this.nombreVehiculo; }
        }

        public int Precio
        {
            get { return this.precio; }
            set { this.precio = value; }
        }

        public int AnioDeFabricacion
        {
            get { return this.anioDeFabricacion; }
            set { this.anioDeFabricacion = value; }
        }

        public int Kilometraje
        {
            get { return this.kilometraje; }
            set { this.kilometraje = value; }
        }

        #endregion


    }
}
