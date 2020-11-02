using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonasMedicosPacientes
{
    class Persona
    {

        protected string nombre;
        protected int dni;
        protected double telefono;
        protected bool sexo;

        public Persona()
        {
            nombre = "";
            dni = 0;
            telefono = 0;
            sexo = true;
        }
        public Persona(string nombre, int dni, double telefono, bool sexo)
        {
            this.nombre = nombre;
            this.dni = dni;
            this.telefono = telefono;
        }

        public bool Sexo
        {
            get { return sexo; }
            set { sexo = value; }
        }
        public double Telefono
        {
            get { return telefono; }
            set { telefono = value; }
        }
        public int Dni
        {
            get { return dni; }
            set { dni = value; }
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string MostrarSexo()
        {
            string sSexo;
            if (Sexo)
                sSexo = "Masculino";
            else
                sSexo = "Femenino";
            return sSexo;
        }
        public string ShowInfoPersona()
        {
            return $"Nombre: {Nombre}\n" +
                $"Dni: {Dni}\n" +
                $"Telefono: {Telefono}\n" +
                $"Sexo: {MostrarSexo()}";
        }


    }
}
