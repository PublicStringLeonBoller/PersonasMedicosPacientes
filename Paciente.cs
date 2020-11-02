using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PersonasMedicosPacientes
{
    class Paciente 
    {

        private int obraSocial;
        private string historiaClinica;
        private string mensaje;

        public Paciente()
        {
            obraSocial = 0;
            historiaClinica = "";
            mensaje = "";
        }

        public Paciente(string mensaje, string historiaClinica, int obraSocial)
        {
            this.mensaje = mensaje;
            this.historiaClinica = historiaClinica;
            this.obraSocial = obraSocial;
        }
        public int MyProperty { get; set; }

        public string Mensaje
        {
            get { return mensaje; }
            set { mensaje = value; }
        }
        public string HistoriaClinica
        {
            get { return historiaClinica; }
            set { historiaClinica = value; }
        }
        public int ObraSocial
        {
            get { return obraSocial; }
            set { obraSocial = value; }
        }

        public string ShowObraSocial()
        {
            switch (ObraSocial)
            {
                case 1: mensaje = "OSPE"; break;
                case 2: mensaje = "PAMI"; break;
                case 3: mensaje = "OSS"; break;
                case 4: mensaje = "No Tiene Obra Social"; break;
            }
            return mensaje;
        }
        public string ShowInfoPaciente()
        {
            return 
                $"Obra Social: {ShowObraSocial()}\n" +
                $"Historia Clinica: {HistoriaClinica}";
        }
    }
}
