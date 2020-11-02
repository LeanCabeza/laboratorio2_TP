using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Excepciones;
using Clases_Instanciables;
using Archivos;
using Clases_Abstractas;
using System.Collections.Generic;

namespace TestUnitarios
{
    [TestClass]
    public class PruebasUnitarias
    {
        /// <summary>
        /// Testea que se lance la excepcion DniInvalidoException.
        /// </summary>
        [TestMethod]
        [ExpectedException(typeof(DniInvalidoException))]
        public void DniInvalidoTest()
        {
            Alumno alumno = new Alumno(123, "Pruebita", "Unitaria", "9999999a", Persona.ENacionalidad.Argentino, Universidad.EClases.Laboratorio);
        }


        /// <summary>
        /// Verifica que se instancien las colecciones de la clase universidad
        /// </summary>
        [TestMethod]
        public void TestMethodColeccionInstanciadaCorrectamente()
        {
            
            Universidad universidad = new Universidad();
            Assert.IsNotNull(universidad.Alumnos);
            Assert.IsNotNull(universidad.Instructores);
            Assert.IsNotNull(universidad.Jornadas);
        }

        /// <summary>
        /// Testea que el atributo Alumnos se haya instanciado.
        /// </summary>
        [TestMethod]
        public void InstanciaColeccionTest()
        {
            Universidad universidad = new Universidad();
            Assert.IsInstanceOfType(universidad.Alumnos, typeof(List<Alumno>));
        }
    }
}
    