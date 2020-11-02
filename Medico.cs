using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonasMedicosPacientes
{
    class Medico : Persona
    {
        private int especialidad;
        private double costoConsulta;
        private Paciente paciente;
        private string mensaje;

        public Medico() :base()
        {
            especialidad = 0;
            costoConsulta = 0;
            paciente = null;
            mensaje = "";
        }

        public Medico(double costoConsulta, int especialidad, string mensaje, Paciente paciente, string nombre, int dni, double telefono, bool sexo) :base(nombre, dni, telefono, sexo)
        {
            this.costoConsulta = costoConsulta;
            this.especialidad = especialidad;
            this.paciente=paciente;
            this.mensaje = mensaje;
        }
        public string  Mensaje
        {
            get { return mensaje; }
            set { mensaje = value; }
        }
         public Paciente Paciente 
        {
            get { return paciente; }
            set { paciente = value; }
        }
        public double CostoConsulta
        {
            get { return costoConsulta; }
            set { costoConsulta = value; }
        }
        public int Especialidad
        {
            get { return especialidad; }
            set { especialidad = value; }
        }

        public string ShowEspecialidad()
        {
            switch (Especialidad)
            {
                case 1: mensaje = "Cardiologia"; break;
                case 2: mensaje = "Odontologia"; break;
                case 3: mensaje = "Pediatria"; break;
                case 4: mensaje = "Enfermeria"; break;
            }
            return mensaje;
        }
        public string ShowInfoMedico()
        {
            return $"{base.ShowInfoPersona()}\n" +
                $"Especialidad: {ShowEspecialidad()}\n" +
                $"Precio de la Consulta: {CostoConsulta}\n" +
                $"{Paciente.ShowInfoPaciente()}"; 
        }

            
    }
}
