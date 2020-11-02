using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml.Schema;

namespace PersonasMedicosPacientes
{
    public partial class Form1 : Form
    {
        double cc, co, cp, ce, contProm;
        double acuProm, porcCardio;
        double max, min;
        bool flagOne, flagTwo;


        public Form1()
        {
            InitializeComponent();
            cc = co = cp = ce = contProm = 0;
            acuProm = porcCardio = 0;
            max = min = 0;
            flagOne = flagTwo = true;

        }

        private void groupBox3_Enter(object sender, EventArgs e)
        {

        }

        private void btnUpload_Click(object sender, EventArgs e)
        {         
            Medico c = new Medico();

            c.Nombre = txtNombre.Text;
            c.Dni = Convert.ToInt32(txtDni.Text);
            c.Telefono = Convert.ToDouble(txtTelefono.Text);
            c.Sexo = Convert.ToBoolean(rbtMasculino.Checked);

            c.Especialidad = cboEspecialidad.SelectedIndex;
            c.CostoConsulta = Convert.ToDouble(txtCostoConsulta.Text);

            Paciente x = new Paciente();
            x.ObraSocial = Convert.ToInt32(cboObraSocial.SelectedIndex);
            x.HistoriaClinica = txtHistoriaClinica.Text;

            c.Paciente = x;

            MessageBox.Show(c.ShowInfoMedico());

            if (c.Especialidad == 1)
                cc++;
            lblContCardio.Text = Convert.ToString(cc);
            if (c.Especialidad == 2)
                co++;
            lblContOdonto.Text = Convert.ToString(co);
            if (c.Especialidad == 3)
                cp++;
            lblContPedia.Text = Convert.ToString(cp);
            if (c.Especialidad == 4)
                ce++;
            lblContEnferm.Text = Convert.ToString(ce);

            contProm++;
            acuProm = acuProm + c.CostoConsulta;
            lblPromCostoConsulta.Text = Convert.ToString(acuProm / contProm);

            if (flagOne)
            {
                flagOne = false;
                max = c.CostoConsulta;
            }

            if (c.CostoConsulta > max)
                max = c.CostoConsulta;
            lblConsultaCara.Text = Convert.ToString(max);
           
            if (flagTwo)
            {
                flagTwo = false;
                min = c.CostoConsulta;
            }
            if (c.CostoConsulta < min)
                min = c.CostoConsulta;
            lblConsultaBarata.Text = Convert.ToString(min);

            if (c.Especialidad == 1)
            {
                porcCardio = (cc / (cc + co + cp + ce)) * 100;               
            }
            lblPorcCardiologia.Text = Convert.ToString(porcCardio);









        }

        private void groupBox4_Enter(object sender, EventArgs e)
        {

        }
    }
}
