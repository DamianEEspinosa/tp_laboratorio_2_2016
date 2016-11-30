using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using EntidadesAbstractas;
using EntidadesInstanciables;
using Excepciones;

namespace TestsUnitarios
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void DniNoNumericoTest()
        {
            try
            {
                string dni = "unodostres";
                Alumno alumno = new Alumno(200, "pepe", "lopez", dni, Persona.ENacionalidad.Argentino, Gimnasio.EClases.Natacion);
            }
            catch (Exception e)
            {                
                Assert.IsInstanceOfType(e, typeof(NacionalidadInvalidaException));
            }
        }
      
    }
}
