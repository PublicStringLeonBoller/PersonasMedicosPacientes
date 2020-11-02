namespace PersonasMedicosPacientes
{
    partial class Form1
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnUpload = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rbtFemenino = new System.Windows.Forms.RadioButton();
            this.rbtMasculino = new System.Windows.Forms.RadioButton();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.txtDni = new System.Windows.Forms.TextBox();
            this.txtNombre = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.cboEspecialidad = new System.Windows.Forms.ComboBox();
            this.txtCostoConsulta = new System.Windows.Forms.TextBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.cboObraSocial = new System.Windows.Forms.ComboBox();
            this.txtHistoriaClinica = new System.Windows.Forms.TextBox();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.lblContEnferm = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.lblContPedia = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.lblConsultaBarata = new System.Windows.Forms.Label();
            this.lblPorcCardiologia = new System.Windows.Forms.Label();
            this.lblConsultaCara = new System.Windows.Forms.Label();
            this.lblPromCostoConsulta = new System.Windows.Forms.Label();
            this.lblContCardio = new System.Windows.Forms.Label();
            this.lblContOdonto = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnUpload
            // 
            this.btnUpload.Location = new System.Drawing.Point(317, 125);
            this.btnUpload.Name = "btnUpload";
            this.btnUpload.Size = new System.Drawing.Size(96, 33);
            this.btnUpload.TabIndex = 0;
            this.btnUpload.Text = "Upload";
            this.btnUpload.UseVisualStyleBackColor = true;
            this.btnUpload.Click += new System.EventHandler(this.btnUpload_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 13);
            this.label1.TabIndex = 1;
            this.label1.Text = "Nombre";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(34, 59);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(26, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "DNI";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(11, 91);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(49, 13);
            this.label3.TabIndex = 1;
            this.label3.Text = "Telefono";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(29, 123);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(31, 13);
            this.label4.TabIndex = 1;
            this.label4.Text = "Sexo";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(19, 28);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(67, 13);
            this.label5.TabIndex = 1;
            this.label5.Text = "Especialidad";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(8, 62);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(78, 13);
            this.label6.TabIndex = 1;
            this.label6.Text = "Costo Consulta";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(28, 28);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(62, 13);
            this.label7.TabIndex = 1;
            this.label7.Text = "Obra Social";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 62);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(76, 13);
            this.label8.TabIndex = 1;
            this.label8.Text = "Historia Clinica";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rbtFemenino);
            this.groupBox1.Controls.Add(this.rbtMasculino);
            this.groupBox1.Controls.Add(this.txtTelefono);
            this.groupBox1.Controls.Add(this.txtDni);
            this.groupBox1.Controls.Add(this.txtNombre);
            this.groupBox1.Controls.Add(this.label4);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Location = new System.Drawing.Point(38, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(241, 176);
            this.groupBox1.TabIndex = 2;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "General";
            // 
            // rbtFemenino
            // 
            this.rbtFemenino.AutoSize = true;
            this.rbtFemenino.Location = new System.Drawing.Point(75, 142);
            this.rbtFemenino.Name = "rbtFemenino";
            this.rbtFemenino.Size = new System.Drawing.Size(71, 17);
            this.rbtFemenino.TabIndex = 4;
            this.rbtFemenino.TabStop = true;
            this.rbtFemenino.Text = "Femenino";
            this.rbtFemenino.UseVisualStyleBackColor = true;
            // 
            // rbtMasculino
            // 
            this.rbtMasculino.AutoSize = true;
            this.rbtMasculino.Location = new System.Drawing.Point(75, 119);
            this.rbtMasculino.Name = "rbtMasculino";
            this.rbtMasculino.Size = new System.Drawing.Size(73, 17);
            this.rbtMasculino.TabIndex = 3;
            this.rbtMasculino.TabStop = true;
            this.rbtMasculino.Text = "Masculino";
            this.rbtMasculino.UseVisualStyleBackColor = true;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(75, 84);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(98, 20);
            this.txtTelefono.TabIndex = 2;
            // 
            // txtDni
            // 
            this.txtDni.Location = new System.Drawing.Point(75, 52);
            this.txtDni.Name = "txtDni";
            this.txtDni.Size = new System.Drawing.Size(98, 20);
            this.txtDni.TabIndex = 1;
            // 
            // txtNombre
            // 
            this.txtNombre.Location = new System.Drawing.Point(75, 21);
            this.txtNombre.Name = "txtNombre";
            this.txtNombre.Size = new System.Drawing.Size(98, 20);
            this.txtNombre.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.cboEspecialidad);
            this.groupBox2.Controls.Add(this.txtCostoConsulta);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Location = new System.Drawing.Point(300, 12);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(231, 91);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Medicos";
            // 
            // cboEspecialidad
            // 
            this.cboEspecialidad.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboEspecialidad.FormattingEnabled = true;
            this.cboEspecialidad.Items.AddRange(new object[] {
            "Elija especialidad",
            "Cardiologia",
            "Odontologia",
            "Pediatria",
            "Enfermeria"});
            this.cboEspecialidad.Location = new System.Drawing.Point(91, 25);
            this.cboEspecialidad.Name = "cboEspecialidad";
            this.cboEspecialidad.Size = new System.Drawing.Size(123, 21);
            this.cboEspecialidad.TabIndex = 0;
            // 
            // txtCostoConsulta
            // 
            this.txtCostoConsulta.Location = new System.Drawing.Point(92, 55);
            this.txtCostoConsulta.Name = "txtCostoConsulta";
            this.txtCostoConsulta.Size = new System.Drawing.Size(123, 20);
            this.txtCostoConsulta.TabIndex = 1;
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.cboObraSocial);
            this.groupBox3.Controls.Add(this.txtHistoriaClinica);
            this.groupBox3.Controls.Add(this.label8);
            this.groupBox3.Controls.Add(this.label7);
            this.groupBox3.Location = new System.Drawing.Point(537, 12);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(227, 91);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Pacientes";
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // cboObraSocial
            // 
            this.cboObraSocial.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboObraSocial.FormattingEnabled = true;
            this.cboObraSocial.Items.AddRange(new object[] {
            "Elija O.S.",
            "OSDE",
            "PAMI",
            "OSS",
            "No Tiene Obra Social"});
            this.cboObraSocial.Location = new System.Drawing.Point(96, 25);
            this.cboObraSocial.Name = "cboObraSocial";
            this.cboObraSocial.Size = new System.Drawing.Size(112, 21);
            this.cboObraSocial.TabIndex = 0;
            // 
            // txtHistoriaClinica
            // 
            this.txtHistoriaClinica.Location = new System.Drawing.Point(96, 56);
            this.txtHistoriaClinica.Name = "txtHistoriaClinica";
            this.txtHistoriaClinica.Size = new System.Drawing.Size(112, 20);
            this.txtHistoriaClinica.TabIndex = 1;
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.lblContEnferm);
            this.groupBox4.Controls.Add(this.label12);
            this.groupBox4.Controls.Add(this.lblContPedia);
            this.groupBox4.Controls.Add(this.label11);
            this.groupBox4.Controls.Add(this.lblConsultaBarata);
            this.groupBox4.Controls.Add(this.lblPorcCardiologia);
            this.groupBox4.Controls.Add(this.lblConsultaCara);
            this.groupBox4.Controls.Add(this.lblPromCostoConsulta);
            this.groupBox4.Controls.Add(this.lblContCardio);
            this.groupBox4.Controls.Add(this.lblContOdonto);
            this.groupBox4.Controls.Add(this.label19);
            this.groupBox4.Controls.Add(this.label17);
            this.groupBox4.Controls.Add(this.label15);
            this.groupBox4.Controls.Add(this.label13);
            this.groupBox4.Controls.Add(this.label9);
            this.groupBox4.Controls.Add(this.label10);
            this.groupBox4.Location = new System.Drawing.Point(311, 177);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(403, 197);
            this.groupBox4.TabIndex = 5;
            this.groupBox4.TabStop = false;
            this.groupBox4.Text = "Informacion Obtenida ";
            this.groupBox4.Enter += new System.EventHandler(this.groupBox4_Enter);
            // 
            // lblContEnferm
            // 
            this.lblContEnferm.AutoSize = true;
            this.lblContEnferm.Location = new System.Drawing.Point(86, 100);
            this.lblContEnferm.Name = "lblContEnferm";
            this.lblContEnferm.Size = new System.Drawing.Size(13, 13);
            this.lblContEnferm.TabIndex = 1;
            this.lblContEnferm.Text = "0";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(21, 100);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(57, 13);
            this.label12.TabIndex = 1;
            this.label12.Text = "Enfermeria";
            // 
            // lblContPedia
            // 
            this.lblContPedia.AutoSize = true;
            this.lblContPedia.Location = new System.Drawing.Point(86, 76);
            this.lblContPedia.Name = "lblContPedia";
            this.lblContPedia.Size = new System.Drawing.Size(13, 13);
            this.lblContPedia.TabIndex = 1;
            this.lblContPedia.Text = "0";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(30, 76);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(48, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Pediatria";
            // 
            // lblConsultaBarata
            // 
            this.lblConsultaBarata.AutoSize = true;
            this.lblConsultaBarata.Location = new System.Drawing.Point(331, 76);
            this.lblConsultaBarata.Name = "lblConsultaBarata";
            this.lblConsultaBarata.Size = new System.Drawing.Size(13, 13);
            this.lblConsultaBarata.TabIndex = 1;
            this.lblConsultaBarata.Text = "0";
            // 
            // lblPorcCardiologia
            // 
            this.lblPorcCardiologia.AutoSize = true;
            this.lblPorcCardiologia.Location = new System.Drawing.Point(331, 100);
            this.lblPorcCardiologia.Name = "lblPorcCardiologia";
            this.lblPorcCardiologia.Size = new System.Drawing.Size(13, 13);
            this.lblPorcCardiologia.TabIndex = 1;
            this.lblPorcCardiologia.Text = "0";
            // 
            // lblConsultaCara
            // 
            this.lblConsultaCara.AutoSize = true;
            this.lblConsultaCara.Location = new System.Drawing.Point(331, 52);
            this.lblConsultaCara.Name = "lblConsultaCara";
            this.lblConsultaCara.Size = new System.Drawing.Size(13, 13);
            this.lblConsultaCara.TabIndex = 1;
            this.lblConsultaCara.Text = "0";
            // 
            // lblPromCostoConsulta
            // 
            this.lblPromCostoConsulta.AutoSize = true;
            this.lblPromCostoConsulta.Location = new System.Drawing.Point(331, 28);
            this.lblPromCostoConsulta.Name = "lblPromCostoConsulta";
            this.lblPromCostoConsulta.Size = new System.Drawing.Size(13, 13);
            this.lblPromCostoConsulta.TabIndex = 1;
            this.lblPromCostoConsulta.Text = "0";
            // 
            // lblContCardio
            // 
            this.lblContCardio.AutoSize = true;
            this.lblContCardio.Location = new System.Drawing.Point(86, 28);
            this.lblContCardio.Name = "lblContCardio";
            this.lblContCardio.Size = new System.Drawing.Size(13, 13);
            this.lblContCardio.TabIndex = 1;
            this.lblContCardio.Text = "0";
            // 
            // lblContOdonto
            // 
            this.lblContOdonto.AutoSize = true;
            this.lblContOdonto.Location = new System.Drawing.Point(86, 52);
            this.lblContOdonto.Name = "lblContOdonto";
            this.lblContOdonto.Size = new System.Drawing.Size(13, 13);
            this.lblContOdonto.TabIndex = 1;
            this.lblContOdonto.Text = "0";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Location = new System.Drawing.Point(178, 76);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(121, 13);
            this.label19.TabIndex = 1;
            this.label19.Text = "Costo Consulta + Barata";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Location = new System.Drawing.Point(178, 100);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(128, 13);
            this.label17.TabIndex = 1;
            this.label17.Text = "Porcentaje de Cardiologia";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(178, 52);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(112, 13);
            this.label15.TabIndex = 1;
            this.label15.Text = "Costo Consulta + Cara";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(178, 28);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(122, 13);
            this.label13.TabIndex = 1;
            this.label13.Text = "Pomedio Costo Consulta";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(19, 28);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(59, 13);
            this.label9.TabIndex = 1;
            this.label9.Text = "Cardiologia";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(14, 52);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 1;
            this.label10.Text = "Odontologia";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(779, 396);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btnUpload);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.groupBox4.ResumeLayout(false);
            this.groupBox4.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button btnUpload;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.RadioButton rbtFemenino;
        private System.Windows.Forms.RadioButton rbtMasculino;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.TextBox txtDni;
        private System.Windows.Forms.TextBox txtNombre;
        private System.Windows.Forms.TextBox txtCostoConsulta;
        private System.Windows.Forms.TextBox txtHistoriaClinica;
        private System.Windows.Forms.ComboBox cboEspecialidad;
        private System.Windows.Forms.ComboBox cboObraSocial;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Label lblContEnferm;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label lblContPedia;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label lblContCardio;
        private System.Windows.Forms.Label lblContOdonto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label lblPromCostoConsulta;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label lblConsultaBarata;
        private System.Windows.Forms.Label lblPorcCardiologia;
        private System.Windows.Forms.Label lblConsultaCara;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label15;
    }
}

