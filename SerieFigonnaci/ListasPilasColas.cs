using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SerieFigonnaci
{
    internal class ListasPilasColas
    {
        private string nombre;
        private string apellido;
        private int edad;

        public string GetNombre()
        {
            return nombre;
        }
        public void SetNombre(string value)
        {
            nombre = value;
        }
        public string GetApellido()
        {
            return apellido;
        }
        public void SetApellido(string value)
        {
            apellido = value;
        }
        public int GetEdad()
        {
            return edad;
        }
        public void SetEdad(int value)
        {
            edad = value;
        }


    }
}
