using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using System.Text;

namespace tecnired.test
{
    [TestClass]
    public class formRegEmpleadoTest
    {
        [TestMethod]
        [DataRow(1, 400, DisplayName = "cedula numerica")]
        public void registrarEmpleadoTest(int index,int exp)
        {
            switch (index)
            {
                case 1:

                default:
                    break;
            }
        }
    }
    
}
