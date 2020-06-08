using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Ejercicio_42;

namespace Ejercicio_45
{
    [TestClass]
    public class UnitTest1
    {
        // ---->>>>>  arrange  - act - assert 

        [TestMethod]
        [ExpectedException (typeof(DivideByZeroException))]
        public void TestCtor()
        {
            int a = 0;
            MiClase mi = new MiClase(a);

        }

        [TestMethod]
        [ExpectedException(typeof(UnaExcepcion))]
        public void TestCtorWithoutParametros()
        {
            
            new MiClase();

        }

        [TestMethod]
        [ExpectedException(typeof(DivideByZeroException))]
        public void TestLanzar()
        {
            MiClase.LanzarExcepcion();

        }


        [TestMethod] 
        [ExpectedException(typeof(MiExcepcion))]
        public void TestCtorOtraClase()
        {
            OtraClase otraClase = new OtraClase();

        }



    }
}
