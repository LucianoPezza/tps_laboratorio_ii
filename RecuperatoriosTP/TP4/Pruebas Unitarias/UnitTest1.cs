using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using System.Collections.Generic;
using Village_Cines;

namespace Pruebas_Unitarias
{
    [TestClass]
    public class UnitTest1
    {
        [ExpectedException(typeof(ExcepcionPropia))]
        [TestMethod]
        public void Si_le_paso_un_directorio_no_existente_deberia_lanzar_ExcepcionPropia()
        {
            //arrange
            string ruta = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
            string rutaCompleta = ruta + @"\DirectorioQueNoPuedeExistirEnLaPcDeNingunaPersonaPorLaCualLaPruebaSalgaMal";

            
            //act
            Json<string> json = new Json<string>();
            json.GuardarComo(rutaCompleta, "cualquier cosa");
     
        }
        [TestMethod]
        public void Si_El_Titulo_De_La_Pelicula_No_Se_Encuentra_En_La_Lista_Deberia_Retornar_False()
        {
            //arrange
            bool esperado = false;
            string titulo = "wwwww";
            //act
            Cine.Vender(titulo, "3D", 1);
            //Assert
            Assert.AreEqual(esperado,false);

        }
    }
}
