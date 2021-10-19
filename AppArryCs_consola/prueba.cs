using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AppArryCs_consola
{
    class prueba
    {

        private DateTime? fecha;

        public DateTime? Fecha
        {
            get { return fecha; }
            set { fecha = value; }
        }

        private string Escuela;

        public string escuela
        {
            get { return Escuela; }
            set { Escuela = value; }
        }

        private string Nombre;

        public string nombre
        {
            get { return Nombre; }
            set { Nombre = value; }
        }

        private string Carrera;

        public string carrera
        {
            get { return Carrera; }
            set { Carrera = value; }
        }



        public prueba() 
        {
            Nombre = "";
            Escuela = "";
            Fecha = null ;
            Carrera = "";

        }


        public override string ToString()
        {
            return Nombre + " " + Escuela + " " + Fecha + " " + Carrera + "";

        }






    }
}
