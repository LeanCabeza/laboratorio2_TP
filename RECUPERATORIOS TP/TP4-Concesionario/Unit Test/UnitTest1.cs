using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Entidades;

namespace UnitTest
{
    [TestClass]
    public class PruebaUnitaria
    {

        [TestClass]
        public class Tests
        {
            [TestMethod]
            public void CrearAuto()
            {
                Auto testAuto = new Auto("Gol Power", 380000, 2008, 145000, EMarcaAuto.Volkswagen, ETipoMotor.Nafta, 90);

                Assert.IsNotNull(testAuto);

            }

            [TestMethod]
            public void CrearMoto()
            {
                Moto testMoto = new Moto("CG Titan", 160000, 2020, 0, EMarcaMoto.Honda, EEncendido.Carburador, 150);

                Assert.IsNotNull(testMoto);

            }

            [TestMethod]
            public void GuardarTxtAuto()
            {
                Auto autoPrueba = new Auto("Gol Power", 380000, 2008, 145000, EMarcaAuto.Volkswagen, ETipoMotor.Nafta, 90);

                bool retorno = GuardaString.GuardarAuto(autoPrueba);

                Assert.IsTrue(retorno);
            }

            [TestMethod]
            public void GuardarTxtMoto()
            {
                Moto motoPrueba = new Moto("CG Titan", 160000, 2020, 0, EMarcaMoto.Honda, EEncendido.Carburador, 150);

                bool retorno = GuardaString.GuardarMoto(motoPrueba);

                Assert.IsTrue(retorno);
            }
        }
    }
}
